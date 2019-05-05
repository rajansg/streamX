using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Client
{
    public partial class Form1 : Form
    {

        private readonly TcpClient client = new TcpClient();
        private NetworkStream mainSteam;

        private int PortNumber;

        private static Image GrabDesktop()
        {

            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            Bitmap screenshot = new Bitmap(bounds.Width, bounds.Height);
            Graphics graphic = Graphics.FromImage(screenshot);
            graphic.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy);
            return screenshot;

        }

        private void SendDesktopImage()
        {

            BinaryFormatter binFormatter = new BinaryFormatter();
            mainSteam = client.GetStream();
            binFormatter.Serialize(mainSteam, GrabDesktop());

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void connectBTN_Click(object sender, EventArgs e)
        {

            PortNumber = int.Parse(PortTXT.Text);

            try
            {

                client.Connect(IpTXT.Text, PortNumber);
                MessageBox.Show("Connected!");

            }
            catch
            {

                MessageBox.Show("Failed to Connect!");

            }

        }

        private void shareBTN_Click(object sender, EventArgs e)
        {

            if (shareBTN.Text.StartsWith("share"))
            {

                timer1.Start();
                shareBTN.Text = "stop sharing";

            }
            else
            {

                timer1.Stop();
                shareBTN.Text = "share Screen";

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            SendDesktopImage();

        }
    }
}
