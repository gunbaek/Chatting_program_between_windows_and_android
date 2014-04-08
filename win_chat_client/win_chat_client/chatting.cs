using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
namespace win_chat_client
{
    public partial class chatting : Form
    {
        Socket serverSock;
        IPEndPoint serverIpep;
        int serverPort;
        IPAddress serverIP;
        bool isConnect;
        Thread th,sendTh,recvTh;
        public chatting()
        {
            InitializeComponent();
            isConnect = false; 
        }

        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            th = new Thread(new ThreadStart(ConnectWithServer));
            th.Start();
        }

        private void ConnectWithServer()
        {
            if (isConnect)
            {
                isConnect = false;
                serverSock.Close();
                if (!serverSock.Connected)
                {
                    chatBox.Text = chatBox.Text + "[" + DateTime.Now.ToString("HH:mm:ss") + "]" + "successful DIsconnection with the server,\n";
                    ConnectionStatus.Text = "오프라인";
                    ConnectionButton.Text = "연결";
                    serverIpBox.ReadOnly = false;
                    serverPortBox.ReadOnly = false;
                }
            }
            else
            {
                isConnect = true;
                serverPort = Convert.ToInt32(serverPortBox.Text);
                serverIP = IPAddress.Parse(serverIpBox.Text);
                serverIpep = new IPEndPoint(serverIP, serverPort);
                try
                {
                    serverSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    serverSock.Connect(serverIpep);

                    if (serverSock.Connected)
                    {
                        serverIpBox.ReadOnly = true;
                        serverPortBox.ReadOnly = true;
                        ConnectionButton.Text = "중단";
                        chatBox.Text = chatBox.Text + "[" + DateTime.Now.ToString("HH:mm:ss") + "]" + "successful connection with the server,\n";
                        ConnectionStatus.Text = "온라인";
                        recvTh = new Thread(new ThreadStart(RecvMsg));
                        recvTh.Start();
                    }
                }
                catch
                {
                }
            }
        }
        private void SendMsg()
        {
            if (chatContents.Text != "")
            {
                String name = "[" + nickName.Text + "]";
                byte[] msg = new byte[512];
                msg = Encoding.Default.GetBytes(name + chatContents.Text + "\n");
                serverSock.Send(msg, 0, msg.Length, SocketFlags.None);
                chatContents.Text = "";
            }
        }
        private void RecvMsg()
        {
            byte[] msg = new byte[512];
            try
            {
                while (serverSock != null && serverSock.Connected)
                {
                    msg = new byte[512];
                    serverSock.Receive(msg);
                    chatBox.Text = chatBox.Text + "[" + DateTime.Now.ToString("mm:ss") + "]:" + Encoding.Default.GetString(msg);
                }
            }
            catch
            {
                chatBox.Text = chatBox.Text + "[" + DateTime.Now.ToString("mm:ss") + "]" + "서버와 연결이 끊어짐.";
                recvTh.Abort();
            }
        }
        private void chatBox_TextChanged(object sender, EventArgs e)
        {
            chatBox.SelectionStart = chatBox.TextLength;
            chatBox.ScrollToCaret();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (isConnect)
            {
                sendTh = new Thread(new ThreadStart(SendMsg));
                sendTh.Start();
                chatContents.Focus();
            }
        }

        private void chatContents_KeyPress(object sender, KeyPressEventArgs e)
        {
              if (e.KeyChar == (char)13)
            {
                e.Handled = true; sendTh = new Thread(new ThreadStart(SendMsg));
                sendTh.Start();
            }
        }
        
    }
}
