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
using team_covid_19.Repository;

namespace team_covid_19.UI
{
    public partial class AdminHome : Form
    {
        UserService userService;
        public AdminHome()
        {
            InitializeComponent();
            this.userService = new UserService();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login form = new Login();

            this.Hide();

            form.ShowDialog();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }

        private void AdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = userService.GetAllUser();
            ClearText();
        }
        void ClearText()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = string.Empty;
        }
        void UpdateGridView()
        {
            dataGridView1.DataSource = userService.GetAllUser();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dresult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dresult == DialogResult.Yes)
            {
                int result = userService.EditUser(Convert.ToInt32(textBox3.Text), Convert.ToString(textBox4.Text), Convert.ToString(textBox5.Text), Convert.ToString(textBox6.Text), Convert.ToString(textBox7.Text));
                if (result > 0)
                {
                    MessageBox.Show("Product updated successfully.");
                    UpdateGridView();
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Error occured..");
                    ClearText();
                }
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dresult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dresult == DialogResult.Yes)
            {
                int result = userService.RemoveUser(Convert.ToInt32(textBox4.Text));
                if (result > 0)
                {
                    MessageBox.Show("Product deleted successfully.");
                    UpdateGridView();
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Error occured..");
                    ClearText();
                }
            }
        }

    }
}
