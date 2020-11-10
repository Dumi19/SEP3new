using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Database.Model;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            DataModel dataModel = new DataModel();
            Server server = new Server(dataModel);
            server.start();
        }
    }
}