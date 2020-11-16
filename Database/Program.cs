using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Database.Model;
using Database.DataModel;
using Database.Networking;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            DataModel dataModel = new DataModel();
            ServerToJava server = new ServerToJava();
            Server serverc = new Server(dataModel);
            server.start();
            serverc.start();
        }
    }
}