using System.Net;
using System.Net.Sockets;
using System.Text;
using System;

namespace Client
{
    public class Client
    {
        static void Main(string[] args)
        {
            //Wait a bit for the server
            Thread.Sleep(5000);
            
            //Console.Beep();

            try
            {
                string hi = "Helooo Internet";
                byte[] buffer = Encoding.ASCII.GetBytes(hi);

                IPEndPoint ipend = new IPEndPoint(IPAddress.Loopback, 6969);

                Socket sc = new Socket(SocketType.Stream, ProtocolType.Tcp);
                sc.Connect(ipend);
                sc.Send(buffer);
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadKey();
        }
    }
}