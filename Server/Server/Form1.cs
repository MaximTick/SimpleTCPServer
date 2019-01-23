using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        Socket client;
        Socket socket;
        byte[] buffer;

        MemoryStream stream;

        public Form1()
        {
            InitializeComponent();
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            buffer = new byte[1000000];
            stream = new MemoryStream(buffer);
        }

        private async void AcceptConnection_Click(object sender, EventArgs e)
        {
            client = await socket.AcceptAsync();
            MessageBox.Show("New connection");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            socket.Bind(new IPEndPoint(IPAddress.Any, 3000));
            socket.Listen(5);
        }

        private void ReceiveImage_Click(object sender, EventArgs e)
        {
            try
            {
                client.Receive(buffer);
                pictureBox.Image = Image.FromStream(stream);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Сan't get a picture");
            }
        }
    }
}
