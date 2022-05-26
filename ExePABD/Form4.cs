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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {        
                Form5 detail = new Form5();
                detail.textBoxNIM.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                detail.textBoxNamaMhs.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                detail.textBoxAlamat.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                detail.textBoxGender.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                detail.textBoxNoTelp.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                detail.ShowDialog();
        }
    }
}
