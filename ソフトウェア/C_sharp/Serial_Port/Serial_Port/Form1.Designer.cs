
namespace Serial_Port
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnopen = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Reaction = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Person_Names = new System.Windows.Forms.ComboBox();
            this.Message = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.COM_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnopen
            // 
            this.btnopen.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnopen.Location = new System.Drawing.Point(153, 347);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(100, 30);
            this.btnopen.TabIndex = 0;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsend
            // 
            this.btnsend.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnsend.Location = new System.Drawing.Point(481, 346);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(108, 33);
            this.btnsend.TabIndex = 1;
            this.btnsend.Text = "送信";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.button2_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.RtsEnable = true;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Tic_good);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(422, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 19);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Close";
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnclose.Location = new System.Drawing.Point(257, 347);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(100, 30);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "接続状態";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(11, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "送信内容";
            // 
            // Reaction
            // 
            this.Reaction.Location = new System.Drawing.Point(471, 302);
            this.Reaction.Name = "Reaction";
            this.Reaction.Size = new System.Drawing.Size(101, 19);
            this.Reaction.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(11, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "作業者名";
            // 
            // Person_Names
            // 
            this.Person_Names.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Person_Names.FormattingEnabled = true;
            this.Person_Names.Items.AddRange(new object[] {
            "miyoshi"});
            this.Person_Names.Location = new System.Drawing.Point(106, 125);
            this.Person_Names.Name = "Person_Names";
            this.Person_Names.Size = new System.Drawing.Size(466, 36);
            this.Person_Names.TabIndex = 12;
            // 
            // Message
            // 
            this.Message.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Message.FormattingEnabled = true;
            this.Message.Items.AddRange(new object[] {
            "ｴｸｾﾙ ｻｷﾞｮｳﾁｭｳ ﾃﾞｽ",
            "ｻｷﾞｮｳﾁｭｳ",
            "ｷｭｳｹｲﾁｭｳ",
            "ｻｷﾞｮｳ ｶﾞ ｼｭｳﾘｮｳ ｼﾏｽ",
            "ﾂｷﾞﾉ ｼｼﾞ ｦ ﾏｯﾃ ｵﾘﾏｽ",
            "ﾀｽｹﾃｸﾀﾞｻｲ"});
            this.Message.Location = new System.Drawing.Point(106, 212);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(466, 36);
            this.Message.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Reaction);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Person_Names);
            this.panel1.Controls.Add(this.Message);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 335);
            this.panel1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(50, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(478, 63);
            this.label5.TabIndex = 15;
            this.label5.Text = "作業者名を入力し、送信内容を選択してください\r\nその後、[送信]ボタンを押してください";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(357, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "受信リアクション";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(69, 353);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(78, 20);
            this.comboBox3.TabIndex = 15;
            // 
            // COM_label
            // 
            this.COM_label.AutoSize = true;
            this.COM_label.Location = new System.Drawing.Point(3, 358);
            this.COM_label.Name = "COM_label";
            this.COM_label.Size = new System.Drawing.Size(65, 12);
            this.COM_label.TabIndex = 18;
            this.COM_label.Text = "COM select";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 385);
            this.Controls.Add(this.COM_label);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.btnopen);
            this.Name = "Form1";
            this.Text = "NANISHI-TEN Serial通信APP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnsend;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Reaction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Person_Names;
        private System.Windows.Forms.ComboBox Message;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label COM_label;
    }
}

