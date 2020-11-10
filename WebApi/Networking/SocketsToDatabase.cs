using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using Models;

namespace WebApi.Networking {
class SocketsToDatabase {
    public Object getUsers() {
        Console.WriteLine("Starting client..");

        TcpClient client = new TcpClient("127.0.0.1", 2920);

        NetworkStream stream = client.GetStream();

        byte[] dataToServer = Encoding.ASCII.GetBytes("GetUsers");
        stream.Write(dataToServer, 0, dataToServer.Length);

        byte[] dataFromServer = new byte[1024];
        int bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
        string response = Encoding.ASCII.GetString(dataFromServer, 0, bytesRead);
        IList<User> request = JsonSerializer.Deserialize<IList<User>>(response);
        Console.WriteLine(request);
        
        stream.Close();
        client.Close();
        return request;
    }
}
}