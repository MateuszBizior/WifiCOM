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
            this.SendBtn = new System.Windows.Forms.Button();
            this.PortsCbx = new System.Windows.Forms.ComboBox();
            this.BaudRateCbx = new System.Windows.Forms.ComboBox();
            this.ConectBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureStatus = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboParity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboStopBits = new System.Windows.Forms.ComboBox();
            this.btnDefault = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboDataBits = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.GyroZtxt = new System.Windows.Forms.TextBox();
            this.GyroYtxt = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.GyroXtxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Acc2Ztxt = new System.Windows.Forms.TextBox();
            this.Acc2Ytxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Acc2Xtxt = new System.Windows.Forms.TextBox();
            this.SelectCombo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.AccZText = new System.Windows.Forms.TextBox();
            this.AccYText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.AccXText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MagnXtxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PathTxt = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Ztext = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MagnZtxt = new System.Windows.Forms.TextBox();
            this.MagnYtxt = new System.Windows.Forms.TextBox();
            this.RollTxt = new System.Windows.Forms.TextBox();
            this.PitchTxt = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStatus)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialReceived);
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(6, 13);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 1;
            this.SendBtn.Text = "Odczyt";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // PortsCbx
            // 
            this.PortsCbx.FormattingEnabled = true;
            this.PortsCbx.Location = new System.Drawing.Point(190, 42);
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
            this.BaudRateCbx.Location = new System.Drawing.Point(190, 69);
            this.BaudRateCbx.Name = "BaudRateCbx";
            this.BaudRateCbx.Size = new System.Drawing.Size(121, 21);
            this.BaudRateCbx.TabIndex = 5;
            // 
            // ConectBtn
            // 
            this.ConectBtn.Location = new System.Drawing.Point(198, 209);
            this.ConectBtn.Name = "ConectBtn";
            this.ConectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConectBtn.TabIndex = 6;
            this.ConectBtn.Text = "Conect";
            this.ConectBtn.UseVisualStyleBackColor = true;
            this.ConectBtn.Click += new System.EventHandler(this.ConectBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(279, 209);
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
            this.tabControl1.Size = new System.Drawing.Size(743, 339);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureStatus);
            this.tabPage1.Controls.Add(this.lblStatus);
            this.tabPage1.Controls.Add(this.ConectBtn);
            this.tabPage1.Controls.Add(this.CloseBtn);
            this.tabPage1.Controls.Add(this.PortsCbx);
            this.tabPage1.Controls.Add(this.comboParity);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.BaudRateCbx);
            this.tabPage1.Controls.Add(this.comboStopBits);
            this.tabPage1.Controls.Add(this.btnDefault);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.comboDataBits);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(735, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureStatus
            // 
            this.pictureStatus.BackColor = System.Drawing.Color.Red;
            this.pictureStatus.Location = new System.Drawing.Point(36, 251);
            this.pictureStatus.Name = "pictureStatus";
            this.pictureStatus.Size = new System.Drawing.Size(18, 18);
            this.pictureStatus.TabIndex = 42;
            this.pictureStatus.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(60, 256);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 13);
            this.lblStatus.TabIndex = 41;
            this.lblStatus.Text = "Brak połączenia";
            // 
            // comboParity
            // 
            this.comboParity.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboParity.FormattingEnabled = true;
            this.comboParity.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200",
            "230400"});
            this.comboParity.Location = new System.Drawing.Point(190, 153);
            this.comboParity.Name = "comboParity";
            this.comboParity.Size = new System.Drawing.Size(121, 21);
            this.comboParity.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Wybierz prędkość transmisji:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(117, 209);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 39;
            this.btnRefresh.Text = "Odświerz";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Wybierz bity danych: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Wybiesz port COM:";
            // 
            // comboStopBits
            // 
            this.comboStopBits.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "1.5",
            "2"});
            this.comboStopBits.FormattingEnabled = true;
            this.comboStopBits.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200",
            "230400"});
            this.comboStopBits.Location = new System.Drawing.Point(190, 126);
            this.comboStopBits.Name = "comboStopBits";
            this.comboStopBits.Size = new System.Drawing.Size(121, 21);
            this.comboStopBits.TabIndex = 36;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(36, 209);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDefault.TabIndex = 38;
            this.btnDefault.Text = "Domyślne";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Wybierz bity stopu:";
            // 
            // comboDataBits
            // 
            this.comboDataBits.AutoCompleteCustomSource.AddRange(new string[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboDataBits.FormattingEnabled = true;
            this.comboDataBits.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200",
            "230400"});
            this.comboDataBits.Location = new System.Drawing.Point(190, 97);
            this.comboDataBits.Name = "comboDataBits";
            this.comboDataBits.Size = new System.Drawing.Size(121, 21);
            this.comboDataBits.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Wybierz bity parzystości: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.GyroZtxt);
            this.tabPage2.Controls.Add(this.GyroYtxt);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.GyroXtxt);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.Acc2Ztxt);
            this.tabPage2.Controls.Add(this.Acc2Ytxt);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.Acc2Xtxt);
            this.tabPage2.Controls.Add(this.SelectCombo);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.AccZText);
            this.tabPage2.Controls.Add(this.AccYText);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.AccXText);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.MagnXtxt);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.PathTxt);
            this.tabPage2.Controls.Add(this.RegisterBtn);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.Ztext);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.MagnZtxt);
            this.tabPage2.Controls.Add(this.MagnYtxt);
            this.tabPage2.Controls.Add(this.RollTxt);
            this.tabPage2.Controls.Add(this.PitchTxt);
            this.tabPage2.Controls.Add(this.SendBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(735, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Odczyt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(386, 232);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 62;
            this.label19.Text = "Żyroskop Z:";
            // 
            // GyroZtxt
            // 
            this.GyroZtxt.Location = new System.Drawing.Point(389, 248);
            this.GyroZtxt.Name = "GyroZtxt";
            this.GyroZtxt.Size = new System.Drawing.Size(95, 20);
            this.GyroZtxt.TabIndex = 61;
            // 
            // GyroYtxt
            // 
            this.GyroYtxt.Location = new System.Drawing.Point(389, 207);
            this.GyroYtxt.Name = "GyroYtxt";
            this.GyroYtxt.Size = new System.Drawing.Size(95, 20);
            this.GyroYtxt.TabIndex = 60;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(386, 191);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 59;
            this.label20.Text = "Żyroskop Y:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(386, 152);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 13);
            this.label21.TabIndex = 58;
            this.label21.Text = "Żyroskop X:";
            // 
            // GyroXtxt
            // 
            this.GyroXtxt.Location = new System.Drawing.Point(389, 168);
            this.GyroXtxt.Name = "GyroXtxt";
            this.GyroXtxt.Size = new System.Drawing.Size(95, 20);
            this.GyroXtxt.TabIndex = 57;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(237, 232);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 56;
            this.label16.Text = "Akcelerometr Z:";
            // 
            // Acc2Ztxt
            // 
            this.Acc2Ztxt.Location = new System.Drawing.Point(240, 248);
            this.Acc2Ztxt.Name = "Acc2Ztxt";
            this.Acc2Ztxt.Size = new System.Drawing.Size(95, 20);
            this.Acc2Ztxt.TabIndex = 55;
            // 
            // Acc2Ytxt
            // 
            this.Acc2Ytxt.Location = new System.Drawing.Point(240, 207);
            this.Acc2Ytxt.Name = "Acc2Ytxt";
            this.Acc2Ytxt.Size = new System.Drawing.Size(95, 20);
            this.Acc2Ytxt.TabIndex = 54;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(237, 191);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 13);
            this.label17.TabIndex = 53;
            this.label17.Text = "Akcelerometr Y:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(237, 152);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 13);
            this.label18.TabIndex = 52;
            this.label18.Text = "Akcelerometr X:";
            // 
            // Acc2Xtxt
            // 
            this.Acc2Xtxt.Location = new System.Drawing.Point(240, 168);
            this.Acc2Xtxt.Name = "Acc2Xtxt";
            this.Acc2Xtxt.Size = new System.Drawing.Size(95, 20);
            this.Acc2Xtxt.TabIndex = 51;
            // 
            // SelectCombo
            // 
            this.SelectCombo.FormattingEnabled = true;
            this.SelectCombo.Items.AddRange(new object[] {
            "Czyste dane",
            "Dane po przeliczeniu"});
            this.SelectCombo.Location = new System.Drawing.Point(87, 13);
            this.SelectCombo.Name = "SelectCombo";
            this.SelectCombo.Size = new System.Drawing.Size(135, 21);
            this.SelectCombo.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(386, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "ZAcc";
            // 
            // AccZText
            // 
            this.AccZText.Location = new System.Drawing.Point(389, 99);
            this.AccZText.Name = "AccZText";
            this.AccZText.Size = new System.Drawing.Size(95, 20);
            this.AccZText.TabIndex = 48;
            // 
            // AccYText
            // 
            this.AccYText.Location = new System.Drawing.Point(389, 58);
            this.AccYText.Name = "AccYText";
            this.AccYText.Size = new System.Drawing.Size(95, 20);
            this.AccYText.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(386, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "RollAcc";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(386, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "PitchAcc";
            // 
            // AccXText
            // 
            this.AccXText.Location = new System.Drawing.Point(389, 19);
            this.AccXText.Name = "AccXText";
            this.AccXText.Size = new System.Drawing.Size(95, 20);
            this.AccXText.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Plik zapisu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(535, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Magnetometr X:";
            // 
            // MagnXtxt
            // 
            this.MagnXtxt.Location = new System.Drawing.Point(538, 168);
            this.MagnXtxt.Name = "MagnXtxt";
            this.MagnXtxt.Size = new System.Drawing.Size(95, 20);
            this.MagnXtxt.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PathTxt
            // 
            this.PathTxt.Location = new System.Drawing.Point(87, 123);
            this.PathTxt.Name = "PathTxt";
            this.PathTxt.Size = new System.Drawing.Size(95, 20);
            this.PathTxt.TabIndex = 38;
            this.PathTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PathTxt_KeyDown);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(9, 165);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.RegisterBtn.TabIndex = 37;
            this.RegisterBtn.Text = "Rejestruj";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(237, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Z:";
            // 
            // Ztext
            // 
            this.Ztext.Location = new System.Drawing.Point(240, 99);
            this.Ztext.Name = "Ztext";
            this.Ztext.Size = new System.Drawing.Size(95, 20);
            this.Ztext.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(535, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Magnetometr Z:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(535, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Magnetometr Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Roll:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Pitch:";
            // 
            // MagnZtxt
            // 
            this.MagnZtxt.Location = new System.Drawing.Point(538, 248);
            this.MagnZtxt.Name = "MagnZtxt";
            this.MagnZtxt.Size = new System.Drawing.Size(95, 20);
            this.MagnZtxt.TabIndex = 6;
            // 
            // MagnYtxt
            // 
            this.MagnYtxt.Location = new System.Drawing.Point(538, 207);
            this.MagnYtxt.Name = "MagnYtxt";
            this.MagnYtxt.Size = new System.Drawing.Size(95, 20);
            this.MagnYtxt.TabIndex = 5;
            // 
            // RollTxt
            // 
            this.RollTxt.Location = new System.Drawing.Point(240, 58);
            this.RollTxt.Name = "RollTxt";
            this.RollTxt.Size = new System.Drawing.Size(95, 20);
            this.RollTxt.TabIndex = 4;
            // 
            // PitchTxt
            // 
            this.PitchTxt.Location = new System.Drawing.Point(240, 19);
            this.PitchTxt.Name = "PitchTxt";
            this.PitchTxt.Size = new System.Drawing.Size(95, 20);
            this.PitchTxt.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 389);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStatus)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.ComboBox PortsCbx;
        private System.Windows.Forms.ComboBox BaudRateCbx;
        private System.Windows.Forms.Button ConectBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.ComboBox comboParity;
        private System.Windows.Forms.ComboBox comboStopBits;
        private System.Windows.Forms.ComboBox comboDataBits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MagnZtxt;
        private System.Windows.Forms.TextBox MagnYtxt;
        private System.Windows.Forms.TextBox RollTxt;
        private System.Windows.Forms.TextBox PitchTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Ztext;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.TextBox PathTxt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MagnXtxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox AccZText;
        private System.Windows.Forms.TextBox AccYText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox AccXText;
        private System.Windows.Forms.ComboBox SelectCombo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox GyroZtxt;
        private System.Windows.Forms.TextBox GyroYtxt;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox GyroXtxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Acc2Ztxt;
        private System.Windows.Forms.TextBox Acc2Ytxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Acc2Xtxt;
    }
}

