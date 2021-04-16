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
    public partial class DoctorHome : Form
    {
        public DoctorHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorHome form1 = new DoctorHome();
            online_consulting form = new online_consulting();

            this.Hide();

            form.ShowDialog();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorHome form1 = new DoctorHome();
            DoctorPrecription  form = new DoctorPrecription();

            this.Hide();

            form.ShowDialog();

            form1.ShowDialog();
        }

        private void DoctorHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void DoctorHome_Load(object sender, EventArgs e)
        {

        }
    }
}
