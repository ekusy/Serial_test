using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SerialTest
{
    public partial class Form1 : Form
    {
        serial stream = new serial();
        tcp server;
        Thread readTcpThread;
        bool readTcpThreadFlg = false;
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void readTcp()
        {
            while (readTcpThreadFlg == true)
            {
                //Console.WriteLine("readTcp");
                if (data.flg == true)
                {
                    //String msg = data.num + "を送信しました";
                    //MessageBox.Show(msg);
                    stream.writeSerial(data.num);
                    data.flg = false;
                }
            }
            Console.WriteLine("STOP read");
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
            pompOn();
        }

        private void buttonPompOff_Click(object sender, EventArgs e)
        {
            pompOff();
        }

        private void buttonValveClose_Click(object sender, EventArgs e)
        {
            valveClose();
        }

        private void buttonValveOpen_Click(object sender, EventArgs e)
        {
            valveOpen();
        }

        private void buttonSerialClose_Click(object sender, EventArgs e)
        {
            stream.closeSerial();
            labelConnect.Text = "未接続";
        }

        private void pompOn()
        {
            stream.writeSerial(textBoxButton1.Text);
            labelPomp.Text = "Pomp ON";
        }

        private void pompOff()
        {
            stream.writeSerial(textBoxButton2.Text);
            labelPomp.Text = "Pomp OFF";
        }

        private void valveClose()
        {
            stream.writeSerial(textBoxButton3.Text);
            labelValve.Text = "Valve CLOSE";
        }

        private void valveOpen()
        {
            stream.writeSerial(textBoxButton4.Text);
            labelValve.Text = "Valve OPEN";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            server = new tcp();
            readTcpThreadFlg = true;
            readTcpThread = new Thread(
                           new ThreadStart(readTcp));
            readTcpThread.Start();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            readTcpThreadFlg = false;
            server.stopServer();
            //this.Close();
            //Application.Exit();
        }
    }
}
