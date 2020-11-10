using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Database.Model;
using Database.DataModel;
using System.Text.Json;
using System.IO;

namespace Server
{
    class Server{

        private DataModel dataModel;
        private string content;
        public Server(DataModel dataModel){
            this.dataModel=dataModel;
        }
        public void start(){
            Console.WriteLine("Starting server...");

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ip, 2920);
            listener.Start();

            Console.WriteLine("Server started...");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("Client connected");

                NetworkStream stream = client.GetStream();
                // read
                byte[] dataFromClient = new byte[1024];
                int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
                string s = Encoding.ASCII.GetString(dataFromClient, 0, bytesRead);
                Console.WriteLine(s);

                switch(s){
                    case "GetUsers":{
                        content = File.ReadAllText("users.json");
                        break;
                    }
                }
                
                // respond
                byte[] dataToClient = Encoding.ASCII.GetBytes(content);
                stream.Write(dataToClient, 0, dataToClient.Length);
                
                // close connection
                client.Close();
            }
        }

    }
}