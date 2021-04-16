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
    public partial class Symptom : Form
    {
        public Symptom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientHome form = new PatientHome();
            this.Hide();
            form.ShowDialog();
        }

        private void Symptom_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void Symptom_Load(object sender, EventArgs e)
        {

        }
    }
}
