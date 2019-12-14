using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Sudoku
{
    internal class Communicator
    {
        private Socket S1;

        private byte[] buff;

        private string buff_s;

        public string Status;

        public delegate void MethodDelegate();

        public event MethodDelegate StatusChange;

        public Communicator()
        {
            S1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Status = "";

            buff = new byte[1024];

            buff_s = "";
        }

        private void ChangeStatus(string newstatus)
        {
            Status = newstatus;

            if (StatusChange != null) StatusChange();
        }

        public void Connect()
        {
            IPEndPoint EP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9991);

            ChangeStatus("Connecting");

            S1.Connect(EP);

            string x = "Hello There!";

            S1.Send(Encoding.ASCII.GetBytes(x));

            S1.Disconnect(true);

            ChangeStatus("Done!");
        }

        public void Listen()
        {
            S1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            ChangeStatus("Listening");

            IPEndPoint EP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9991);

            S1.Bind(EP);

            S1.Listen(1);

            S1.BeginAccept(new AsyncCallback(OnConnect), null);
        }

        private void OnConnect(IAsyncResult R)
        {
            Socket temp = S1.EndAccept(R);

            S1.Close();

            S1 = temp;

            ChangeStatus("Connected");

            S1.Send(Encoding.ASCII.GetBytes("Welcome"));

            S1.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(OnReceive), null);
        }

        private void OnReceive(IAsyncResult R)
        {
            for (int i = 0; buff[i] != 0; i++)
            {
                buff_s += ((char)buff[i]).ToString();
                buff[i] = 0;
            }

            S1.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(OnReceive), null);

            // MethodDelegate D = new MethodDelegate(BufferUpdated);
        }
    }
}