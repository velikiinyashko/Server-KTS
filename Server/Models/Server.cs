using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
    class Server
    {
        private IPAddress ServerAddr;
        private int ServerPorts;
        public Server(IPAddress Addr, int Ports)
        {
            TcpListener server = null;
            this.ServerAddr = Addr;
            this.ServerPorts = Ports;
            EventLogers Events = new EventLogers();
            Logers log = new Logers();
            try
            {
                server = new TcpListener(ServerAddr, ServerPorts);
                server.Start();

                Events.WriteEventLog(string.Format("start server to addr - {0} / ports - {1}", Addr.ToString(), Ports.ToString()));

                Console.WriteLine(string.Format("server {0}:{1} - start", Addr.ToString(), Ports.ToString()));

                while (true)
                {

                    TcpClient Clients = server.AcceptTcpClient();

                    ClientObject clientobject = new ClientObject(Clients);

                    Task ClientTask = new Task(clientobject.Proccess);
                    ClientTask.Start();

                }
            }
            catch (Exception ex)
            {
                log.WriteLog(ex.TargetSite.ToString(), ex.Message);
            }
            finally
            {
                if (server != null)
                    server.Stop();
            }
        }
    }

    class ClientObject
    {
        public TcpClient Client;
        Logers Log = new Logers();
        public ClientObject(TcpClient Tcpclient)
        {
            Client = Tcpclient;
        }

        public void Proccess()
        {
            NetworkStream Stream = null;
            try
            {
                Stream = Client.GetStream();
                BinaryReader reader = new BinaryReader(Stream);
                string Response = reader.ReadString();
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.TargetSite.ToString(), ex.Message);
            }
            finally
            {
                if (Stream != null)
                    Stream.Close();
                if (Client != null)
                    Client.Close();
            }
        }
    }
}