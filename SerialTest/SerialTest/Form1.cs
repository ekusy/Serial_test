using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialTest
{
    public partial class Form1 : Form
    {
        serial stream = new serial();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSerialConnect_Click(object sender, EventArgs e)
        {
            if(stream.openSerial(textBoxPort.Text, 9600))
            {
                labelConnect.Text = textBoxPort.Text;
            }
            else
            {
                labelConnect.Text = "未接続";
            }

        }

        private void buttonPompOn_Click(object sender, EventArgs e)
        {
            stream.writeSerial("1");
            labelPomp.Text = "Pomp ON";
        }

        private void buttonPompOff_Click(object sender, EventArgs e)
        {
            stream.writeSerial("2");
            labelPomp.Text = "Pomp OFF";
        }

        private void buttonValveClose_Click(object sender, EventArgs e)
        {
            stream.writeSerial("3");
            labelValve.Text = "Valve CLOSE";
        }
        private void buttonValveOpen_Click(object sender, EventArgs e)
        {
            stream.writeSerial("4");
            labelValve.Text = "Valve OPEN";
        }

        private void buttonSerialClose_Click(object sender, EventArgs e)
        {
            stream.closeSerial();
            labelConnect.Text = "未接続";
        }
    }
}
