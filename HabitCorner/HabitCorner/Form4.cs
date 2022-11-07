using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HabitCorner
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
