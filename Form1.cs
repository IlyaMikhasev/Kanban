using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Kanban
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, 1);
            IPAddress dest = IPAddress.Parse("224.12.12.1"+(cb_groups.SelectedIndex+1).ToString());
            //добавляем в группу рассылки ipadress
            socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(dest));
            IPEndPoint ep = new IPEndPoint(dest, 1024);
            socket.Connect(ep);
            socket.Send(Encoding.Unicode.GetBytes(tb_broad.Text+"\r\n"));
            tb_broad.Text = string.Empty;
            socket.Close();
        }
    }
}
