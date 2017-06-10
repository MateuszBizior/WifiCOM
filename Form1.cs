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

        public static SerialPort SerialPort1 = new System.IO.Ports.SerialPort("COM3");

        public Form1()
        {

            InitializeComponent();
        }

        private void SerialReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            ReciveBox.Text = serialPort1.ReadExisting();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            
            {
                SerialPort1.Write(SendBox.Text);
                
            }
            
            {
                
            }
        }
    }
}
