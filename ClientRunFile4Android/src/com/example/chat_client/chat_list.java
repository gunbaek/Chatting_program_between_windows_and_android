package com.example.chat_client;

import java.util.ArrayList;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;


public class chat_list {
	chat_list(int aIcon, String aName, String aText) {
			Icon = aIcon;
			Name = aName;
			Text = aText;
		}
		int Icon;
		String Name;
		String Text;
	}

	//어댑터 클래스
	class MyListAdapter extends BaseAdapter {
		Context maincon;
		LayoutInflater Inflater;
		ArrayList<chat_list> arSrc;
		int layout;

		public MyListAdapter(Context context, int alayout, ArrayList<chat_list> aarSrc) {
			maincon = context;
			Inflater = (LayoutInflater)context.getSystemService(
					Context.LAYOUT_INFLATER_SERVICE);
			arSrc = aarSrc;
			layout = alayout;
		}

		public int getCount() {
			return arSrc.size();
		}

		public String getItem(int position) {
			return arSrc.get(position).Name;
		}

		public long getItemId(int position) {
			return position;
		}

		// 각 항목의 뷰 생성
		public View getView(int position, View convertView, ViewGroup parent) {
			final int pos = position;
			if (convertView == null) {
				convertView = Inflater.inflate(layout, parent, false);
			}
			ImageView img = (ImageView)convertView.findViewById(R.id.img);
			img.setImageResource(arSrc.get(position).Icon);

			TextView txt = (TextView)convertView.findViewById(R.id.text);
			txt.setText(arSrc.get(position).Text);
			
			TextView name = (TextView)convertView.findViewById(R.id.nameDisply);
			name.setText(arSrc.get(position).Name);
			
			return convertView;
		}
}
