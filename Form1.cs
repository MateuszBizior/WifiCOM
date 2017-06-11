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

namespace WifiCOM
{
    public partial class Form1 : Form
    {
        string InputData = string.Empty;
        delegate void SetTextCallback(string text);

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
            if (this.ReciveBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.BeginInvoke(d, new object[] { text });
            }
            else
            {
                ReciveBox.Text = text;
            }
        }


        void AvaliablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            PortsCbx.Items.AddRange(ports);

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(serialPort1.IsOpen)
                serialPort1.Write(SendBox.Text);
                
            }
            catch(UnauthorizedAccessException)
            {
                MessageBox.Show("Błąd podczas wysłania danych!!\n Upewnij się czy wybrany port jest dostępny.");
            }
        }

        private void ConectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if( PortsCbx.Text != "" && BaudRateCbx.Text!="")
                {
                    serialPort1.PortName = PortsCbx.Text;
                    serialPort1.BaudRate = Convert.ToInt32(BaudRateCbx.Text);
                    serialPort1.Open();
                }
                else
                {
                    MessageBox.Show("Ustaw właściwości portu COM");
                }
            }
            catch(UnauthorizedAccessException)
            {
                MessageBox.Show("Błąd połączenia");
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }
    }
}
