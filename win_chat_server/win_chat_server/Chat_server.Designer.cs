namespace win_chat_server
{
    partial class Chat_server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat_server));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.activeButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serverProcessBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ipLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.activeButton);
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.portbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Setting";
            // 
            // ipLabel
            // 
            this.ipLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ipLabel.Location = new System.Drawing.Point(88, 80);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(122, 12);
            this.ipLabel.TabIndex = 6;
            this.ipLabel.Text = "0.0.0.0";
            this.ipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "IP";
            // 
            // activeButton
            // 
            this.activeButton.Location = new System.Drawing.Point(158, 18);
            this.activeButton.Name = "activeButton";
            this.activeButton.Size = new System.Drawing.Size(52, 23);
            this.activeButton.TabIndex = 4;
            this.activeButton.Text = "Start";
            this.activeButton.UseVisualStyleBackColor = true;
            this.activeButton.Click += new System.EventHandler(this.activeButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statusLabel.Location = new System.Drawing.Point(86, 52);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(124, 12);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Server down";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status";
            // 
            // portbox
            // 
            this.portbox.Location = new System.Drawing.Point(88, 20);
            this.portbox.Name = "portbox";
            this.portbox.Size = new System.Drawing.Size(64, 21);
            this.portbox.TabIndex = 1;
            this.portbox.Text = "9999";
            this.portbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // serverProcessBox
            // 
            this.serverProcessBox.AutoWordSelection = true;
            this.serverProcessBox.Location = new System.Drawing.Point(12, 150);
            this.serverProcessBox.Name = "serverProcessBox";
            this.serverProcessBox.Size = new System.Drawing.Size(233, 243);
            this.serverProcessBox.TabIndex = 1;
            this.serverProcessBox.Text = "";
            this.serverProcessBox.TextChanged += new System.EventHandler(this.serverProcessBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "Server Proccess";
            // 
            // Chat_server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 405);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.serverProcessBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Chat_server";
            this.Text = "Chat Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button activeButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox serverProcessBox;
        private System.Windows.Forms.Label label6;
    }
}

