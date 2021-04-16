using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using team_covid_19.Services;

namespace team_covid_19.UI
{
    public partial class Login : Form
    {
        string x;
        LoginService login;
        public Login()
        {
            InitializeComponent();
            login = new LoginService();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminLogin form = new AdminLogin();
           

            this.Hide();

            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetEmail = Convert.ToString( textBox1.Text);

            if(textBox1.Text==""||textBox2.Text=="")
            {
                MessageBox.Show("Email or password can not be empty");

            }
            else
            {
                int result = login.LoginValidation(textBox1.Text, textBox2.Text);
                if(result>0)
                {
                    if(result == 1)
                    {
                        DoctorHome doctor = new DoctorHome();
                        this.Hide();
                        doctor.ShowDialog();
                    }
                    else if(result==2)
                    {
                        PatientHome patient = new PatientHome();
                        this.Hide();
                        patient.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed");
                    }

                }
                else
                {
                    MessageBox.Show("Login Failed");
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup form = new Signup(this);

            this.Hide();

            form.ShowDialog();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLogin admin = new AdminLogin();
            this.Hide();
            admin.ShowDialog();
        }

        public string GetEmail { get { return x; } set {  x = value; } }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
