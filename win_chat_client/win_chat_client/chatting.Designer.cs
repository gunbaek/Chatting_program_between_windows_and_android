namespace win_chat_client
{
    partial class chatting
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chatting));
            this.sendButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serverPortBox = new System.Windows.Forms.TextBox();
            this.ConnectionStatus = new System.Windows.Forms.Label();
            this.ConnectionButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serverIpBox = new System.Windows.Forms.TextBox();
            this.chatContents = new System.Windows.Forms.TextBox();
            this.nickName = new System.Windows.Forms.TextBox();
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.chatBoxGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.chatBoxGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(417, 346);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "전송";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serverPortBox);
            this.groupBox1.Controls.Add(this.ConnectionStatus);
            this.groupBox1.Controls.Add(this.ConnectionButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.serverIpBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Setting";
            // 
            // serverPortBox
            // 
            this.serverPortBox.Location = new System.Drawing.Point(237, 20);
            this.serverPortBox.Name = "serverPortBox";
            this.serverPortBox.Size = new System.Drawing.Size(61, 21);
            this.serverPortBox.TabIndex = 5;
            this.serverPortBox.Text = "9999";
            this.serverPortBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConnectionStatus
            // 
            this.ConnectionStatus.Location = new System.Drawing.Point(412, 23);
            this.ConnectionStatus.Name = "ConnectionStatus";
            this.ConnectionStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ConnectionStatus.Size = new System.Drawing.Size(53, 12);
            this.ConnectionStatus.TabIndex = 4;
            this.ConnectionStatus.Text = "오프라인";
            this.ConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConnectionButton
            // 
            this.ConnectionButton.Location = new System.Drawing.Point(309, 18);
            this.ConnectionButton.Name = "ConnectionButton";
            this.ConnectionButton.Size = new System.Drawing.Size(55, 23);
            this.ConnectionButton.TabIndex = 3;
            this.ConnectionButton.Text = "연결";
            this.ConnectionButton.UseVisualStyleBackColor = true;
            this.ConnectionButton.Click += new System.EventHandler(this.ConnectionButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "상태";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server_IP";
            // 
            // serverIpBox
            // 
            this.serverIpBox.Location = new System.Drawing.Point(85, 20);
            this.serverIpBox.Name = "serverIpBox";
            this.serverIpBox.Size = new System.Drawing.Size(146, 21);
            this.serverIpBox.TabIndex = 0;
            this.serverIpBox.Text = "192.168.25.46";
            this.serverIpBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chatContents
            // 
            this.chatContents.Location = new System.Drawing.Point(106, 346);
            this.chatContents.Name = "chatContents";
            this.chatContents.Size = new System.Drawing.Size(305, 21);
            this.chatContents.TabIndex = 3;
            this.chatContents.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chatContents_KeyPress);
            // 
            // nickName
            // 
            this.nickName.Location = new System.Drawing.Point(12, 346);
            this.nickName.Name = "nickName";
            this.nickName.Size = new System.Drawing.Size(88, 21);
            this.nickName.TabIndex = 4;
            this.nickName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chatBox
            // 
            this.chatBox.HideSelection = false;
            this.chatBox.Location = new System.Drawing.Point(6, 20);
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(468, 290);
            this.chatBox.TabIndex = 5;
            this.chatBox.Text = "";
            this.chatBox.WordWrap = false;
            this.chatBox.TextChanged += new System.EventHandler(this.chatBox_TextChanged);
            // 
            // chatBoxGroup
            // 
            this.chatBoxGroup.Controls.Add(this.chatBox);
            this.chatBoxGroup.Location = new System.Drawing.Point(12, 12);
            this.chatBoxGroup.Name = "chatBoxGroup";
            this.chatBoxGroup.Size = new System.Drawing.Size(480, 316);
            this.chatBoxGroup.TabIndex = 6;
            this.chatBoxGroup.TabStop = false;
            this.chatBoxGroup.Text = "채 팅 창";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "닉네임";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "내용";
            // 
            // chatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 439);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chatBoxGroup);
            this.Controls.Add(this.nickName);
            this.Controls.Add(this.chatContents);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sendButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "chatting";
            this.Text = "Chat Client Ver.0.1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.chatBoxGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox chatContents;
        private System.Windows.Forms.TextBox nickName;
        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.GroupBox chatBoxGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ConnectionStatus;
        private System.Windows.Forms.Button ConnectionButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serverIpBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serverPortBox;
    }
}

