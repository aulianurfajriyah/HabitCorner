using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HabitCorner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form4 = new Form4();
            form4.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.Show();
        }
    }
}
