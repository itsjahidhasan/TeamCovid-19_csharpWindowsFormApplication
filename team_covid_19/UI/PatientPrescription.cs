using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using team_covid_19.Entities;

namespace team_covid_19.UI
{
    public partial class PatientPrescription : Form
    {
        User l = new User();
        public PatientPrescription()
        {
            InitializeComponent();
            label1.Text = l.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientHome form = new PatientHome();
            this.Hide();
            form.ShowDialog();
        }
        
        private void PatientPrescription_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            PatientHome form = new PatientHome();
        }

        private void PatientPrescription_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
