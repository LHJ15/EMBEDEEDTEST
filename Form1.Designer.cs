namespace _01BASIC
{
    partial class Form1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.PortNumber = new System.Windows.Forms.ComboBox();
            this.conn_btn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.LED01 = new System.Windows.Forms.Button();
            this.LED02 = new System.Windows.Forms.Button();
            this.LED04 = new System.Windows.Forms.Button();
            this.LED03 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PortNumber
            // 
            this.PortNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortNumber.FormattingEnabled = true;
            this.PortNumber.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.PortNumber.Location = new System.Drawing.Point(14, 16);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(121, 26);
            this.PortNumber.TabIndex = 0;
            this.PortNumber.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // conn_btn
            // 
            this.conn_btn.Location = new System.Drawing.Point(161, 16);
            this.conn_btn.Margin = new System.Windows.Forms.Padding(4);
            this.conn_btn.Name = "conn_btn";
            this.conn_btn.Size = new System.Drawing.Size(107, 34);
            this.conn_btn.TabIndex = 1;
            this.conn_btn.Text = "연결";
            this.conn_btn.UseVisualStyleBackColor = true;
            this.conn_btn.Click += new System.EventHandler(this.conn_btn_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Location = new System.Drawing.Point(32, 358);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(223, 85);
            this.textBox.TabIndex = 2;
            this.textBox.Text = "MESSAGE :";
            // 
            // LED01
            // 
            this.LED01.Location = new System.Drawing.Point(32, 88);
            this.LED01.Name = "LED01";
            this.LED01.Size = new System.Drawing.Size(103, 61);
            this.LED01.TabIndex = 3;
            this.LED01.Text = "LED_01 ON";
            this.LED01.UseVisualStyleBackColor = true;
            this.LED01.Click += new System.EventHandler(this.LED01_Click);
            // 
            // LED02
            // 
            this.LED02.Location = new System.Drawing.Point(170, 88);
            this.LED02.Name = "LED02";
            this.LED02.Size = new System.Drawing.Size(98, 61);
            this.LED02.TabIndex = 4;
            this.LED02.Text = "LED_01 OFF";
            this.LED02.UseVisualStyleBackColor = true;
            this.LED02.Click += new System.EventHandler(this.button2_Click);
            // 
            // LED04
            // 
            this.LED04.Location = new System.Drawing.Point(170, 181);
            this.LED04.Name = "LED04";
            this.LED04.Size = new System.Drawing.Size(98, 56);
            this.LED04.TabIndex = 5;
            this.LED04.Text = "LED_02 OFF";
            this.LED04.UseVisualStyleBackColor = true;
            this.LED04.Click += new System.EventHandler(this.LED04_Click);
            // 
            // LED03
            // 
            this.LED03.Location = new System.Drawing.Point(32, 181);
            this.LED03.Name = "LED03";
            this.LED03.Size = new System.Drawing.Size(103, 56);
            this.LED03.TabIndex = 6;
            this.LED03.Text = "LED_02 ON";
            this.LED03.UseVisualStyleBackColor = true;
            this.LED03.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(372, 486);
            this.Controls.Add(this.LED03);
            this.Controls.Add(this.LED04);
            this.Controls.Add(this.LED02);
            this.Controls.Add(this.LED01);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.conn_btn);
            this.Controls.Add(this.PortNumber);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortNumber;
        private System.Windows.Forms.Button conn_btn;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button LED01;
        private System.Windows.Forms.Button LED02;
        private System.Windows.Forms.Button LED04;
        private System.Windows.Forms.Button LED03;
    }
}

