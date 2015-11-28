using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialTest
{
    
    class serial
    {
        SerialPort stream;
        String port;
        int rate;
        public serial()
        {
            stream = new SerialPort();
        }

        public bool openSerial(String _port,int _rate)
        {
            if (stream.IsOpen)
            {
                stream.Close();
            }
            stream.PortName = _port;
            stream.BaudRate = _rate;

            try
            {
                stream.Open();
            }
            catch(UnauthorizedAccessException e)
            {
                String msg = "UnauthorizedAccessException　ポート" + _port + "へのアクセスが拒否されました";
                MessageBox.Show(msg);
                stream.Close();
                return false;
            }
            catch(ArgumentException e)
            {
                String msg = "ArgumentException　ポートの指定が不正です";
                MessageBox.Show(msg);
                stream.Close();
                return false;
            }
            catch(System.IO.IOException e)
            {
                String msg = "IOException 無効なポートです";
                MessageBox.Show(msg);
                stream.Close();
                return false;
            }
            String str = "ポート" + _port + "を開きました";
            MessageBox.Show(str);
            return true;
        }

        public void closeSerial()
        {
            if (stream.IsOpen)
            {
                stream.Close();
                String msg = port + "から切断しました";
                MessageBox.Show("シリアル通信を切断しました");
            }
            else
            {
                MessageBox.Show("シリアル通信を接続していません");
            }

        }

        public bool writeSerial(String _data)
        {
            if (stream.IsOpen)
            {
                stream.Write(_data);     
            }
            return true;
        }
    }
}
