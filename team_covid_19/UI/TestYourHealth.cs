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
    public partial class TestYourHealth : Form
    {
        public TestYourHealth()
        {
            InitializeComponent();
        }

        private void TestYourHealth_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void TestYourHealth_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (radioButton1.Checked == false || radioButton2.Checked == false || radioButton3.Checked == false || radioButton4.Checked == false || radioButton5.Checked == false || radioButton6.Checked == false || radioButton7.Checked == false || radioButton8.Checked == false || radioButton9.Checked == false || radioButton10.Checked == false)
            {
                MessageBox.Show("You didn't give the answer ");
            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    sum = sum + 10;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientHome patient = new PatientHome();
            this.Hide();
            patient.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
