using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class MailService
    {
        public void sendEmail()
        {
            connect(timeout:1);
            authenticate();
            disconnect();
        }
        private void connect(int timeout)
        {
            Console.WriteLine("connect");
        }
        private void disconnect()
        {
            Console.WriteLine("disconnect");
        }
        private  void authenticate()
        {
            Console.WriteLine("authenticates");
        }
    }
}
