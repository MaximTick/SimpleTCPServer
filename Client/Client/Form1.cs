using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {
        Socket socket;
        byte[] buffer;
        MemoryStream stream;
        public Client()
        {
            InitializeComponent();

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

           buffer = new byte[1000];
            stream = new MemoryStream(buffer);

            try
            {
                socket.Connect("localhost", 3000);
            }
            catch
            {
                MessageBox.Show("Connection Error");
                Client.ActiveForm.Close();
                //Application.Exit();
            }
        }

        private void LoadImage_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog()
            {
                Filter = "Images only. |*.jpg; *.png; *.gif; *.jpeg"
            };

            fileDialog.ShowDialog();
            pictureBox.Image = Image.FromFile(fileDialog.FileName);
        }

        private void SendImage_Click(object sender, EventArgs e)
        {
            if(pictureBox.Image != null)
            {
                pictureBox.Image.Save(stream, ImageFormat.Png);
                socket.Send(buffer);
            }
        }
    }
}
