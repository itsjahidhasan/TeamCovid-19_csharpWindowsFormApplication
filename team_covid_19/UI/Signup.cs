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
    public partial class Signup : Form
    {
        SignupService signup;
        Login loginForm;
        public Signup(Login login)
        {
            InitializeComponent();
            signup = new SignupService();
            loginForm = login;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login form = new Login();

            this.Hide();

            form.ShowDialog();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            //Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int type = 0;
            if(textBox1.Text ==""||textBox2.Text ==""||textBox4.Text==""||textBox5.Text==""||textBox3.Text==""||textBox6.Text=="")
            {
               
                MessageBox.Show("One or more field is empty.Please fullfill the required field");
            

            }
            else
            {
                if(radioButton1.Checked==true)
                {
                    type = 1;
                }
                else { type = 2; }
                int result = signup.UserSignup(textBox1.Text,textBox2.Text,textBox4.Text,textBox5.Text,dateTimePicker1.Text,comboBox1.Text,textBox3.Text,textBox6.Text,type);
                if(result > 0)
                {
                    MessageBox.Show("Signup successfull.");
                    this.Hide();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("Signup error");
                }


            }

        }
    }
}
