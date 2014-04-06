package com.example.chat_client;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.net.InetSocketAddress;
import java.net.Socket;
import java.net.SocketAddress;
import java.net.UnknownHostException;
import java.util.ArrayList;
import android.os.Bundle;
import android.os.Handler;
import android.app.Activity;
import android.util.Log;
import android.view.Menu;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.ScrollView;
import android.widget.TextView;

public class MainActivity extends Activity {
	TextView chatBox;
	EditText nickName, inputText;
	Button sendBtn;
	RecvThread recvthread;
    Socket socket;
    BufferedWriter bw;
    BufferedReader br;
    ArrayList<chat_list> arItem;
    chat_list chat_contents;
    MyListAdapter MyAdapter ;
    
    
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
//		chatBox = (TextView)findViewById(R.id.chatBox);
		nickName = (EditText)findViewById(R.id.nameText);
		inputText = (EditText)findViewById(R.id.inputText);
		sendBtn = (Button)findViewById(R.id.send);
		//Views connection
		
		arItem = new ArrayList<chat_list>();
		
		MyAdapter = new MyListAdapter(this, R.layout.chat_list, arItem);

		ListView MyList;
		MyList=(ListView)findViewById(R.id.chatBox);
		MyList.setAdapter(MyAdapter);

		
        recvthread = new RecvThread();
        recvthread.setDaemon(true);
        recvthread.start();        
        //recvThread setting
        
		sendBtn.setOnClickListener(mBtnListener);
		//send button clicklistener setting

	}//END OF Oncreate
	
	 OnClickListener mBtnListener = new OnClickListener() {
 		@Override
 		public void onClick(View v) {
             try {
					bw.write("["+nickName.getText()+"] "+inputText.getText()+"\n");
					bw.flush();
					inputText.setText("");
				} catch (IOException e) {
					e.printStackTrace();
				}
 		}
 	};
	public class RecvThread extends Thread {
		Handler mHandler = new Handler();
		public void run() {   
			 try {
					socket = new Socket("192.168.43.176", 9999);
					//socket setting
			        bw = new BufferedWriter(new OutputStreamWriter(socket.getOutputStream(), "euc-kr"));
			        br = new BufferedReader(new InputStreamReader(socket.getInputStream(), "euc-kr"));
			        //write and read buffer setting
				} catch (UnknownHostException e) {
					e.printStackTrace();
				} catch (IOException e) {
					e.printStackTrace();
				}
	          while(true){
				  chat_recv();
			  } 
		}
       public void chat_recv(){
    	   try {
	             final String recvText = br.readLine();
	             //�ڵ鷯
	             mHandler.post(new Runnable() {
	                public void run() {      
//	                	chatBox.setText(chatBox.getText()+"\n"+recvText);
	                	
	                	final String[] splitRecvText = recvText.split("]");
	            		chat_contents = new chat_list(R.drawable.ic_launcher, splitRecvText[0]+"]", splitRecvText[1]);
	            		arItem.add(chat_contents);
	            		MyAdapter.notifyDataSetChanged();
	                }        
	             });
	          } catch (UnknownHostException e) {    
	             e.printStackTrace();
	          } catch (IOException e) {    
	             e.printStackTrace();
	       }      
       }//end of chat_rev();
   }//end of recvThread

}

