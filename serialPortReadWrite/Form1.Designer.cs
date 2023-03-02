namespace serialPortReadWrite
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboPortName = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBaudrate = new System.Windows.Forms.ListBox();
            this.buttonOpenClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxHexSend = new System.Windows.Forms.CheckBox();
            this.checkBoxNewlineSend = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxHexView = new System.Windows.Forms.CheckBox();
            this.checkBoxNewlineGet = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelSendCount = new System.Windows.Forms.Label();
            this.labelGetCount = new System.Windows.Forms.Label();
            this.txSend = new System.Windows.Forms.RichTextBox();
            this.txGet = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择端口：";
            // 
            // comboPortName
            // 
            this.comboPortName.FormattingEnabled = true;
            this.comboPortName.ItemHeight = 18;
            this.comboPortName.Location = new System.Drawing.Point(72, 62);
            this.comboPortName.Name = "comboPortName";
            this.comboPortName.Size = new System.Drawing.Size(168, 184);
            this.comboPortName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "选择波特率：";
            // 
            // comboBaudrate
            // 
            this.comboBaudrate.FormattingEnabled = true;
            this.comboBaudrate.ItemHeight = 18;
            this.comboBaudrate.Items.AddRange(new object[] {
            "9600"});
            this.comboBaudrate.Location = new System.Drawing.Point(72, 303);
            this.comboBaudrate.Name = "comboBaudrate";
            this.comboBaudrate.Size = new System.Drawing.Size(165, 166);
            this.comboBaudrate.TabIndex = 3;
            // 
            // buttonOpenClose
            // 
            this.buttonOpenClose.Location = new System.Drawing.Point(103, 491);
            this.buttonOpenClose.Name = "buttonOpenClose";
            this.buttonOpenClose.Size = new System.Drawing.Size(92, 28);
            this.buttonOpenClose.TabIndex = 4;
            this.buttonOpenClose.Text = "打开端口";
            this.buttonOpenClose.UseVisualStyleBackColor = true;
            this.buttonOpenClose.Click += new System.EventHandler(this.buttonOpenClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "发送模块";
            // 
            // checkBoxHexSend
            // 
            this.checkBoxHexSend.AutoSize = true;
            this.checkBoxHexSend.Location = new System.Drawing.Point(340, 67);
            this.checkBoxHexSend.Name = "checkBoxHexSend";
            this.checkBoxHexSend.Size = new System.Drawing.Size(97, 22);
            this.checkBoxHexSend.TabIndex = 6;
            this.checkBoxHexSend.Text = "HEX格式";
            this.checkBoxHexSend.UseVisualStyleBackColor = true;
            // 
            // checkBoxNewlineSend
            // 
            this.checkBoxNewlineSend.AutoSize = true;
            this.checkBoxNewlineSend.Location = new System.Drawing.Point(489, 67);
            this.checkBoxNewlineSend.Name = "checkBoxNewlineSend";
            this.checkBoxNewlineSend.Size = new System.Drawing.Size(70, 22);
            this.checkBoxNewlineSend.TabIndex = 7;
            this.checkBoxNewlineSend.Text = "换行";
            this.checkBoxNewlineSend.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "输入发送内容：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "接收模块";
            // 
            // checkBoxHexView
            // 
            this.checkBoxHexView.AutoSize = true;
            this.checkBoxHexView.Location = new System.Drawing.Point(341, 538);
            this.checkBoxHexView.Name = "checkBoxHexView";
            this.checkBoxHexView.Size = new System.Drawing.Size(97, 22);
            this.checkBoxHexView.TabIndex = 11;
            this.checkBoxHexView.Text = "HEX接收";
            this.checkBoxHexView.UseVisualStyleBackColor = true;
            // 
            // checkBoxNewlineGet
            // 
            this.checkBoxNewlineGet.AutoSize = true;
            this.checkBoxNewlineGet.Location = new System.Drawing.Point(489, 537);
            this.checkBoxNewlineGet.Name = "checkBoxNewlineGet";
            this.checkBoxNewlineGet.Size = new System.Drawing.Size(70, 22);
            this.checkBoxNewlineGet.TabIndex = 12;
            this.checkBoxNewlineGet.Text = "换行";
            this.checkBoxNewlineGet.UseVisualStyleBackColor = true;
            this.checkBoxNewlineGet.CheckedChanged += new System.EventHandler(this.checkBoxNewlineGet_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 583);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "接收监视窗口：";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(762, 464);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(145, 49);
            this.buttonSend.TabIndex = 15;
            this.buttonSend.Text = "发送1次报文";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelSendCount
            // 
            this.labelSendCount.AutoSize = true;
            this.labelSendCount.Location = new System.Drawing.Point(479, 105);
            this.labelSendCount.Name = "labelSendCount";
            this.labelSendCount.Size = new System.Drawing.Size(62, 18);
            this.labelSendCount.TabIndex = 16;
            this.labelSendCount.Text = "label7";
            // 
            // labelGetCount
            // 
            this.labelGetCount.AutoSize = true;
            this.labelGetCount.Location = new System.Drawing.Point(479, 583);
            this.labelGetCount.Name = "labelGetCount";
            this.labelGetCount.Size = new System.Drawing.Size(62, 18);
            this.labelGetCount.TabIndex = 17;
            this.labelGetCount.Text = "label7";
            // 
            // txSend
            // 
            this.txSend.Location = new System.Drawing.Point(340, 138);
            this.txSend.Name = "txSend";
            this.txSend.Size = new System.Drawing.Size(956, 307);
            this.txSend.TabIndex = 18;
            this.txSend.Text = "";
            // 
            // txGet
            // 
            this.txGet.Location = new System.Drawing.Point(340, 631);
            this.txGet.Name = "txGet";
            this.txGet.Size = new System.Drawing.Size(956, 371);
            this.txGet.TabIndex = 19;
            this.txGet.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(927, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 49);
            this.button1.TabIndex = 20;
            this.button1.Text = "每秒自动发送报文";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1143, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 49);
            this.button2.TabIndex = 21;
            this.button2.Text = "停止发送";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 1078);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txGet);
            this.Controls.Add(this.txSend);
            this.Controls.Add(this.labelGetCount);
            this.Controls.Add(this.labelSendCount);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxNewlineGet);
            this.Controls.Add(this.checkBoxHexView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxNewlineSend);
            this.Controls.Add(this.checkBoxHexSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonOpenClose);
            this.Controls.Add(this.comboBaudrate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboPortName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox comboPortName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox comboBaudrate;
        private System.Windows.Forms.Button buttonOpenClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxHexSend;
        private System.Windows.Forms.CheckBox checkBoxNewlineSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxHexView;
        private System.Windows.Forms.CheckBox checkBoxNewlineGet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelSendCount;
        private System.Windows.Forms.Label labelGetCount;
        private System.Windows.Forms.RichTextBox txSend;
        private System.Windows.Forms.RichTextBox txGet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

