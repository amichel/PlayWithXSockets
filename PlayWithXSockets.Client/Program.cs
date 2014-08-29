using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XSockets.Client40;

namespace PlayWithXSockets.Client
{
    class Program
    {
        private static XSocketClient _client;
        static void Main(string[] args)
        {
            _client = new XSocketClient("ws://127.0.0.1:4502", "http://localhost", "Test");
            _client.OnConnected += client_OnOpen;
            _client.Open();

            Console.ReadKey();
        }

        static void client_OnOpen(object sender, EventArgs e)
        {
            _client.Controller("Test").Invoke("Test", new {data = "test"});
        }
    }
}
