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
    public partial class PatientHome : Form
    {
        public PatientHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientHome form1 = new PatientHome();
            web_update form = new web_update();

            this.Hide();

            form.ShowDialog();

            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientHome form1 = new PatientHome();
            Information form = new Information();


            this.Hide();

            form.ShowDialog();

            form1.ShowDialog();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            PatientHome form1 = new PatientHome();
            Symptom form = new Symptom();

            this.Hide();

            form.ShowDialog();
            form1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PatientHome form1 = new PatientHome();
            PatientPrescription form = new PatientPrescription();

            this.Hide();


            form.ShowDialog();
            form1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PatientHome form1 = new PatientHome();
            online_consulting form = new online_consulting();
           

            this.Hide();

            form.ShowDialog();
         
            form1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login form = new Login();

            this.Hide();

            form.ShowDialog();
        }

        private void PatientHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientHome form = new PatientHome();
            TestYourHealth health = new TestYourHealth();
            this.Hide();
            health.ShowDialog();
            form.ShowDialog();
        }
    }
}
