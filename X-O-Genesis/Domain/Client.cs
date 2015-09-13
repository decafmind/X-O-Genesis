using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class Client
    {
        public event EventHandler ServerReply;

        private const int PORT_NUMBER = 2099;
        private TcpClient client;
        private string address;

        public Client(string address)
        {
            this.address = address;
        }

        void OnServerReply(EventArgs e)
        {
            EventHandler onServerReply = ServerReply;
            if (onServerReply != null)
                onServerReply(this, e);
        }

        public void Speak(string message)
        {
            try
            {
                client = new TcpClient(address, PORT_NUMBER);
                using (Stream s = client.GetStream())
                {
                    StreamWriter sw = new StreamWriter(s);
                    StreamReader sr = new StreamReader(s);
                    
                    sw.AutoFlush = true;
                    sw.WriteLine(message);

                    string reply = string.Empty;
                    reply = sr.ReadLine();
                    if (!string.IsNullOrWhiteSpace(reply))
                        OnServerReply(new EventArgs());
                }
            }
            catch (SocketException)
            {
                System.Windows.Forms.MessageBox.Show("Server is not running");
            }
            catch (IOException)
            {

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }


        }

    }
}
