using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_covid_19.UI
{
    public partial class DoctorPrecription : Form
    {
        public DoctorPrecription()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login form = new Login();

            this.Hide();

            form.ShowDialog();
        }

        private void DoctorPrecription_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.Exit();
        }

        private void DoctorPrecription_Load(object sender, EventArgs e)
        {

        }
    }
}
