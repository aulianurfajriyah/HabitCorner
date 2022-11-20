using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HabitCorner
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=Farhan011;Database=HabitCorner";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            
            if(String.IsNullOrEmpty(tbHabitNamef2.Text))
            {
                MessageBox.Show("Mohon isi data dengan lengkap", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(tbHabitDatef2.Text))
            {
                MessageBox.Show("Mohon isi data dengan lengkap", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conn.Open();
                sql = @"select * from st_inserthabit(:_habitName, :_habitDate)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_habitName", tbHabitNamef2.Text);
                cmd.Parameters.AddWithValue("_habitDate", tbHabitDatef2.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data users berhasil disimpan", "Well Done!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    tbHabitNamef2.Text = tbHabitDatef2.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "INSERT FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
