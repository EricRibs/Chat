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

namespace Chat_Client
{
    public partial class frm_client : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        public frm_client()
        {
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            txb_c1_ip.Text = GetLocalIP();
            txb_c2_ip.Text = GetLocalIP();
        }
        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if(size > 0)
                {
                    byte[] receiveData = new byte[1464];
                    receiveData = (byte[])aResult.AsyncState;
                    UTF8Encoding enc = new UTF8Encoding();
                    string receiveM = enc.GetString(receiveData);
                    Lst_msg.Items.Add("Friend: "+receiveM);
                }
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(txb_c1_ip.Text), Convert.ToInt32(txb_c1_p.Text));
                sck.Bind(epLocal);
                epRemote = new IPEndPoint(IPAddress.Parse(txb_c2_ip.Text), Convert.ToInt32(txb_c2_p.Text));
                sck.Connect(epRemote);
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
                Btn_Start.Text = "Connected";
                Btn_Start.Enabled = false;
                Btn_send.Enabled = true;
                txb_msg.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                UTF8Encoding enc = new UTF8Encoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(txb_msg.Text);
                sck.Send(msg);
                Lst_msg.Items.Add("You: " + txb_msg.Text);
                txb_msg.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
