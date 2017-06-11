namespace WifiCOM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ReciveBox = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.SendBox = new System.Windows.Forms.TextBox();
            this.PortsCbx = new System.Windows.Forms.ComboBox();
            this.BaudRateCbx = new System.Windows.Forms.ComboBox();
            this.ConectBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialReceived);
            // 
            // ReciveBox
            // 
            this.ReciveBox.Location = new System.Drawing.Point(62, 127);
            this.ReciveBox.Name = "ReciveBox";
            this.ReciveBox.Size = new System.Drawing.Size(95, 20);
            this.ReciveBox.TabIndex = 0;
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(62, 33);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 1;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // SendBox
            // 
            this.SendBox.Location = new System.Drawing.Point(62, 75);
            this.SendBox.Name = "SendBox";
            this.SendBox.Size = new System.Drawing.Size(95, 20);
            this.SendBox.TabIndex = 2;
            // 
            // PortsCbx
            // 
            this.PortsCbx.FormattingEnabled = true;
            this.PortsCbx.Location = new System.Drawing.Point(27, 65);
            this.PortsCbx.Name = "PortsCbx";
            this.PortsCbx.Size = new System.Drawing.Size(121, 21);
            this.PortsCbx.TabIndex = 4;
            // 
            // BaudRateCbx
            // 
            this.BaudRateCbx.FormattingEnabled = true;
            this.BaudRateCbx.Items.AddRange(new object[] {
            "9600",
            "56000",
            "115200"});
            this.BaudRateCbx.Location = new System.Drawing.Point(27, 109);
            this.BaudRateCbx.Name = "BaudRateCbx";
            this.BaudRateCbx.Size = new System.Drawing.Size(121, 21);
            this.BaudRateCbx.TabIndex = 5;
            // 
            // ConectBtn
            // 
            this.ConectBtn.Location = new System.Drawing.Point(27, 23);
            this.ConectBtn.Name = "ConectBtn";
            this.ConectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConectBtn.TabIndex = 6;
            this.ConectBtn.Text = "Conect";
            this.ConectBtn.UseVisualStyleBackColor = true;
            this.ConectBtn.Click += new System.EventHandler(this.ConectBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(27, 202);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 7;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(462, 365);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ConectBtn);
            this.tabPage1.Controls.Add(this.CloseBtn);
            this.tabPage1.Controls.Add(this.PortsCbx);
            this.tabPage1.Controls.Add(this.BaudRateCbx);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(454, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SendBtn);
            this.tabPage2.Controls.Add(this.SendBox);
            this.tabPage2.Controls.Add(this.ReciveBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(454, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 389);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox ReciveBox;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TextBox SendBox;
        private System.Windows.Forms.ComboBox PortsCbx;
        private System.Windows.Forms.ComboBox BaudRateCbx;
        private System.Windows.Forms.Button ConectBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

