using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExePABD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "admin123" && checkBox1.Checked)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
            else if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "admin123" && checkBox1.Checked)
            {
                MessageBox.Show("Username/Password Salah Ulangi lagii");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
