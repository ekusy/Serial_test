﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
namespace SerialTest
{
    class tcp
    {
        String ip;
        System.Net.IPAddress ipAdd;
        int port;
        System.Net.Sockets.TcpListener listener;
        //System.Net.Sockets.TcpClient client;
        ClientTcpIp client;
        public bool serverFlg = false;
        Thread clientThread;
        Thread myServerThread;
        public tcp()
        {
            ip = "127.0.0.1";
            port = 1000;
            openTCP(ip, port);
        }

        public void openTCP(String _ip,int _port)
        {
            IPAddress myIp = IPAddress.Parse(_ip);
            IPEndPoint myEndPoint = new IPEndPoint(myIp, _port);

            // リスナー開始
            listener = new TcpListener(myEndPoint);
            listener.Start();

            // クライアント接続待ち開始
            serverFlg = true;
            myServerThread = new Thread(new ThreadStart(ServerThread));
            myServerThread.Start();
        }

        private void ServerThread()
        {
            try
            {
                while (serverFlg == true)
                {
                    Console.WriteLine("ServerThread");
                    // ソケット接続待ち
                    if (listener.Pending())
                    {
                        TcpClient myTcpClient = listener.AcceptTcpClient();
                        // クライアントから接続有り
                        //if(myTcpClient)
                        // クライアント送受信オブジェクト生成
                        client = new ClientTcpIp();
                        client.objSck = myTcpClient;
                        client.objStm = myTcpClient.GetStream();
                        // クライアントとの送受信開始
                        client.readFlg = true;
                        if (serverFlg == true)
                        {
                            clientThread = new Thread(
                                    new ThreadStart(client.ReadWrite));
                            clientThread.Start();
                        }
                    }

                }
                Console.WriteLine("STOP Server");
            }
            catch { }
        }

        public void stopServerThread()
        {
            serverFlg = false;

            
        }

        public void stopServer()
        {
            stopServerThread();

            if (myServerThread!= null)
            {
                if (myServerThread.IsAlive)
                {
                    myServerThread.Abort();
                    serverFlg = false;
                    myServerThread.Join();
                    Console.WriteLine("stop myServerThread");
                }
                myServerThread = null;
            }

            if (clientThread != null)
            {
                if (clientThread.IsAlive)
                {

                    client.stopReadThread();
                    clientThread.Abort();
                    clientThread.Join();
                }
                clientThread = null;
            }

            if (client != null)
                client.stopReadThread();
            client = null;
        }
    }

// クライアント送受信クラス
    public class ClientTcpIp
    {
        public TcpClient objSck;
        public NetworkStream objStm;
        public bool readFlg = false;
        // クライアント送受信スレッド
        public void ReadWrite()
        {
            try
            {
                while (readFlg == true)
                {
                    if (objSck.Available > 0)
                    {
                        Console.WriteLine("ReadWrite");
                        // ソケット受信
                        Byte[] rdat = new Byte[1024];
                        int ldat = objStm.Read(rdat, 0, rdat.GetLength(0));
                        if (ldat > 0)
                        {
                            // クライアントからの受信データ有り
                            // 送信データ作成
                            char[] sdat = new char[ldat];
                            Array.Copy(rdat, sdat, ldat);

                            for (int i = 0; i < sdat.Length; i++)
                            {
                                if (sdat[i] >= 48 && sdat[i] <= 57)
                                {
                                    /*
                                    String msg = "receive";
                                    msg = msg + (sdat[i] - 48);
                                    MessageBox.Show(msg);
                                    */
                                    String num = char.ToString(sdat[i]);
                                    data.num = num;
                                    data.flg = true;
                                    break;
                                }
                            }
                            //
                            /*
                        String msg = "(" + intNo + ")" +
                            System.Text.Encoding.GetEncoding(
                                "SHIFT-JIS").GetString(sdat);
                        sdat = System.Text.Encoding.GetEncoding(
                            "SHIFT-JIS").GetBytes(msg);
                        // ソケット送信
                        objStm.Write(sdat, 0, sdat.GetLength(0));
                        */


                        }
                        else
                        {
                            // ソケット切断有り
                            // ソケットクローズ
                            objStm.Close();
                            objSck.Close();
                            Console.WriteLine("return read");
                            return;
                        }
                    }
                }
                Console.WriteLine("STOP read");
            }
            catch { }
        }
        public void stopReadThread()
        {
            readFlg = false;
        }
    }
}
