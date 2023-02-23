using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    public class Server
    {
        static void Main(string[] args)
        {
            try
            {
                byte[] bytes = new byte[1024];

                IPEndPoint ipend = new IPEndPoint(IPAddress.Loopback, 6969);

                Socket sc = new Socket(SocketType.Stream, ProtocolType.Tcp);
                

                sc.Bind(ipend);
                Console.Beep();
                sc.Listen(6969);
                Socket mysc = sc.Accept();
                mysc.Receive(bytes);
                Console.WriteLine("Waiting for a message :P");
                Console.WriteLine();
                string hello = Encoding.ASCII.GetString(bytes);
                Console.WriteLine(hello);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
