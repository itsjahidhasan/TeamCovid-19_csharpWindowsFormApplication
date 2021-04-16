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
using team_covid_19.UI;


namespace team_covid_19
{
    public partial class online_consulting : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        public online_consulting()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void online_consulting_Load(object sender, EventArgs e)
        {
            //setup socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //get userIP
            textLocalIp.Text = GetLocalIp();
            textRemoteIp.Text = GetLocalIp();
        }
        private string GetLocalIp() 
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //binding socket
            epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
            
            sck.Bind(epLocal);


            //connecying to remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(textRemoteIp.Text), Convert.ToInt32(textRemotePort.Text));
            
            sck.Connect(epRemote);

            //listing the specepic port
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0,buffer.Length,SocketFlags.None,ref epRemote,new AsyncCallback(MessageCallBack),buffer);


        }
        private void MessageCallBack(IAsyncResult aResult) 
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;

                //coonverting byte array to string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string recievedMassage = aEncoding.GetString(receivedData);

                //adding massage into listbox
                listBox1.Items.Add("Friend: " + recievedMassage);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          



        }

        private void online_consulting_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //convert string message to byte array
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(textBox5.Text);

            //sending the encoded message
            sck.Send(sendingMessage);

            //adding to the listbox
            listBox1.Items.Add("Me: " + textBox5.Text);
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
