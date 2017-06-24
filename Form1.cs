using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace WifiCOM
{
    public partial class Form1 : Form
    {
        bool flagR = false;
        string path;
        string InputData = string.Empty;
        delegate void SetTextCallback(string text);
        int time = 0;

        public Form1()
        {

            InitializeComponent();
            AvaliablePorts();
            
        }

        private void SerialReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                InputData = serialPort1.ReadTo("n");
                if (InputData != String.Empty)
                {
                    SetText(InputData);
                }
            }

            catch
            {
                MessageBox.Show("Błąd podczas odbierania");
            }
        }


        void SetText(string text)
        {
            int r = 1;
            int p = 1;
            int z = 1;
            int mx = 1;
            int my = 1;
            int mz = 1;
            StringWriter strWriter = new StringWriter();

            if (this.ReciveBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.BeginInvoke(d, new object[] { text });
            }
            else
            {
                try
                {
                    ReciveBox.Text = text;
                    PitchTxt.Text = string.Empty;
                    RollTxt.Text = string.Empty;
                    Ztext.Text = string.Empty;
                    MagnXtxt.Text = string.Empty;
                    MagnYtxt.Text = string.Empty;
                    MagnZtxt.Text = string.Empty;
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text[i] == 'P')
                        {
                            while (text[i + p] != 'z')
                            {
                                PitchTxt.Text += text[i + p];
                                p++;
                            }
                        }
                        if (text[i] == 'R')
                        {
                            while (text[i + r] != 'z')
                            {
                                RollTxt.Text += text[i + r];
                                r++;
                            }
                        }
                        if (text[i] == 'J')
                        {
                            while (text[i + z] != 'z')
                            {
                                Ztext.Text += text[i + z];
                                z++;
                            }
                        }
                        if (text[i] == 'X')
                        {
                            while (text[i + mx] != 'z')
                            {
                                MagnXtxt.Text += text[i + mx];
                                mx++;
                            }
                        }
                        if (text[i] == 'Y')
                        {
                            while (text[i + my] != 'z')
                            {
                                MagnYtxt.Text += text[i + my];
                                my++;
                            }
                        }
                        if (text[i] == 'Z')
                        {
                            while (text[i + mz] != 'z')
                            {
                                MagnZtxt.Text += text[i + mz];
                                mz++;
                            }
                        }

                    }
                }
                catch { }

                if (File.Exists(path) && flagR == true)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(path, true))
                        {
                            sw.WriteLine(time.ToString() + ";" + PitchTxt.Text + ";" + RollTxt.Text + ";" + Ztext.Text + ";" + MagnXtxt.Text + ";" + MagnYtxt.Text + ";" + MagnZtxt.Text);
                        }
                    }
                    catch { }

                }
            }
        }



        void AvaliablePorts()
        {
            PortsCbx.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            PortsCbx.Items.AddRange(ports);

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                    if (comboSelect.SelectedItem.ToString() == "Czyste dane")
                    {
                        serialPort1.Write("0");
                    }
                    else
                    if (comboSelect.SelectedItem.ToString() == "Dane po przeliczeniach")
                    {
                        serialPort1.Write("1");
                    }
                    else
                    {
                        MessageBox.Show("Nie wybrano rodzaju danych.\nWybierz i spróbuj ponownie.");
                    }


            }
            catch(UnauthorizedAccessException)
            {
                MessageBox.Show("Błąd podczas wysłania danych!!\n Upewnij się czy wybrany port jest dostępny.");
            }
        }

        private void ConectBtn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
            try
            {
                serialPort1.PortName = PortsCbx.SelectedItem.ToString(); // przypisanie nazwy portu zgodnie z tym co wybralismy
                serialPort1.BaudRate = Int32.Parse(BaudRateCbx.Text);     //ustawienie predkości transmisji
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboStopBits.Text); //ustawienie bitów stopu
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), comboParity.Text); //ustawienie bitów parzystości
                serialPort1.DataBits = Int32.Parse(comboDataBits.Text); //ustawienie bitów danych



                serialPort1.Open();
                serialPort1.DiscardInBuffer();
            }
            // jesli port jest juz otwarty wyswietlamy
            catch
            {
                MessageBox.Show("Serial port " + serialPort1.PortName + "nie moze zostac otwarty");
            }
            if (serialPort1.IsOpen) { lblStatus.Text = "Połączono"; pictureStatus.BackColor = System.Drawing.Color.Lime; }
            else { lblStatus.Text = "Brak połączenia"; pictureStatus.BackColor = System.Drawing.Color.Red; }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            if (!serialPort1.IsOpen) { lblStatus.Text = "Brak Połączenia"; pictureStatus.BackColor = System.Drawing.Color.Red; }
            else { lblStatus.Text = "Pałączona"; pictureStatus.BackColor = System.Drawing.Color.Lime; }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            AvaliablePorts();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            BaudRateCbx.Text = "9600";
            comboDataBits.Text = "8";
            comboParity.Text = "None";
            comboStopBits.Text = "1";
        }


        private void PathTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                ReciveBox.Text = PathTxt.Text;
                path = Environment.CurrentDirectory + "/" + PathTxt.Text;
                if (!File.Exists(path))
                {
                    File.CreateText(path);
                    MessageBox.Show(path);
                }
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if(flagR==false)
            {
                RegisterBtn.Text = "Zakończ";
                flagR = true;
                timer1.Enabled=true;
            }
            else 
            if(flagR==true)
            {
                RegisterBtn.Text = "Rejestruj";
                flagR = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                time++;
        }
    }
}
