using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class OurServer
    {
        private TcpListener server;
        public OurServer()
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), 5555);

            server.Start();

            LoopClients();

        }

        void LoopClients()
        {
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();

                Thread thread = new Thread(() => HandleClient(client));
                thread.Start();
            }
        }

        void HandleClient(TcpClient client)
        {
            StreamReader sReader = new StreamReader(client.GetStream(), Encoding.UTF8);
            StreamWriter sWriter = new StreamWriter(client.GetStream(), Encoding.UTF8);
            
            while (true)
            {
                string message = sReader.ReadLine();
                message = $"Клиент написал: {message}";
                Console.WriteLine(message);
                // sWriter.WriteLine(message);
                // sWriter.Flush();
                
                Console.Write("Дайте сообщение клиенту: ");
                string answer = Console.ReadLine();
                sWriter.WriteLine(answer);
                sWriter.Flush();
            }
}

    }
}