using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using team_covid_19.UI;

namespace team_covid_19
{
    public partial class web_update : Form
    {
        public web_update()
        {
            InitializeComponent();
        }

        private void web_update_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.worldometers.info/coronavirus/country/bangladesh/");
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.Text = e.Url.ToString() + "It's loading....";
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientHome form = new PatientHome();

            this.Hide();

            form.ShowDialog();
        }

        private void web_update_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
