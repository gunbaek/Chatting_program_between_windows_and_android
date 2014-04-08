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
using System.Net.Configuration;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace win_chat_server
{
    public partial class Chat_server : Form
    {
        int PORT;
        bool SERVER_ACT;
        Socket[] clients = new Socket[10];
        int clientNumber = 0;
        IPEndPoint ipep;
        Socket server;
        Socket client;
        Thread th;

        public Chat_server()
        {
            InitializeComponent();
            SERVER_ACT = false;
        }

        //IP주소 가져오기
        public static string get_IP
        {
            get
            {
                IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
                string IP = string.Empty;
                for (int i = 0; i < host.AddressList.Length; i++)
                {
                    if (host.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        IP = host.AddressList[i].ToString();
                    }
                }
                return IP;
            }
        }

        private void activeButton_Click(object sender, EventArgs e)
        {
            ipLabel.Text = get_IP;
            
            th = new Thread(new ThreadStart(WaitingFotClient));
            th.Start();
           
        }
        public void WaitingFotClient()
        {
            try
            {
                if (SERVER_ACT == false)
                {
                    portbox.ReadOnly = true;
                    SERVER_ACT = true;
                    statusLabel.Text = "Host starting";
                    activeButton.Text = "Stop";

                    PORT = Convert.ToInt32(portbox.Text);

                    ipep = new IPEndPoint(IPAddress.Any, PORT);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    server.Bind(ipep);
                    server.Listen(10);

                    statusLabel.Text = "in operation";
                    serverProcessBox.Text = serverProcessBox.Text + "[" + DateTime.Now.ToString("HH:mm:ss") + "]" + "Server is in operation.\n";

                    while (true)
                    {
                        serverProcessBox.Text = serverProcessBox.Text + "[" + DateTime.Now.ToString("HH:mm:ss") + "]" + "Waits for the client.\n";
                        client = server.Accept();
                        //클라이언트 접속을 기다렸다 연결 수락
                        clients[clientNumber++] = client;

                        IPEndPoint clientIp = (IPEndPoint)client.RemoteEndPoint;
                        serverProcessBox.Text = serverProcessBox.Text + "[" + DateTime.Now.ToString("HH:mm:ss") + "]" + clientIp.Address + " is connected.\n";
                        //접속했다는 메시지 출력

                        th = new Thread(new ParameterizedThreadStart(Receive));
                        th.Start(client);
                    }
                }
                else//
                {
                    portbox.ReadOnly = false;
                    SERVER_ACT = false;
                    activeButton.Text = "Start";
                    statusLabel.Text = "Server down";
                    //중단 프로세스
                    for (int i = 0; i < clientNumber; i++)
                    {
                        clients[i] = null;
                    }
                    
                    server.Close();
                    serverProcessBox.Text = serverProcessBox.Text + "[" + DateTime.Now.ToString("HH:mm:ss") + "]Server down.\n";
                    //접속했다는 메시지 출력

                }
            }
            catch
            {
                SERVER_ACT = false;
                activeButton.Text = "Start";
                statusLabel.Text = "Turn off";
                for (int i = 0; i < clientNumber; i++)
                {
                    clients[i] = null;
                }
                server.Close(); 
            }
        }
        public void Receive(Object obj)
		{
            Socket clnt = (Socket)obj;
            byte[] message;
            IPEndPoint clientIp = (IPEndPoint)clnt.RemoteEndPoint;
            try
            {
                while (client != null && client.Connected)
                {
                    message = new byte[256];
                    clnt.Receive(message);
                    SendMSG(message, message.Length);
                }
                //클라이언트가 메시지를 보낼떄까지 기다린다.
            }
            catch
            {
                serverProcessBox.Text = serverProcessBox.Text + "[" + DateTime.Now.ToString("HH:mm:ss") + "]" + clientIp.Address + " is disconnected.\n";
                //클라이언트 접속 종료 메시지 출력

                for (int i = 0; i < clientNumber - 1; i++)
                {
                    if (clnt == clients[i])
                    {
                        for (; i < clientNumber - 1; i++)
                            clients[i] = clients[i + 1];
                        break;
                    }
                }
                clientNumber--;
                clnt.Close();
                //끊어진 클라이언트 정리
            }
            
        }
        public void SendMSG(byte[] message, int len)
        {
            for (int i = 0; i < clientNumber; i++)
                clients[i].Send(message);
        }

        private void serverProcessBox_TextChanged(object sender, EventArgs e)
        {
            
            serverProcessBox.Focus();
            serverProcessBox.SelectionStart = serverProcessBox.TextLength;
             serverProcessBox.ScrollToCaret();
        }

    }
}