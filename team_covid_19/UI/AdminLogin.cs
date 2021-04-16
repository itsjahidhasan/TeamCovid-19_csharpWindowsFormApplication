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
    public partial class AdminLogin : Form
    {
        AdminLoginServices admin;


        public AdminLogin()
        {
            InitializeComponent();
            admin = new AdminLoginServices();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AdminHome admin1 = new AdminHome();
                      this.Hide();
                      admin1.ShowDialog();

            
        //    if (textBox1.Text == "" || textBox2.Text == "")
        //    {
        //        MessageBox.Show("Email or password can not be empty");

        //    }
        //    else
        //    {
        //        int result = admin.AdminLoginValidation(textBox1.Text, textBox2.Text);
        //        if (result > 0)
        //        {
        //            AdminHome admin1 = new AdminHome();
        //            this.Hide();
        //            admin1.Show();
                   
        //        }
        //        else
        //        {
        //            MessageBox.Show("Login Failed");
        //        }


        //    }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
        }

        private void AdminLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
