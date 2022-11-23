using Npgsql;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=aulianf1007;Database=HabitCorner";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;



        private void button1_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);

            if (String.IsNullOrEmpty(tbHabitNamef2.Text))
            {
                MessageBox.Show("Mohon isi data dengan lengkap", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(tbHabitDatef2.Text))
            {
                MessageBox.Show("Mohon isi data dengan lengkap", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tbHabitStatus.Text == "Done")
            {
                tbHabitStatus.Text = "True";
            }
            else if (tbHabitStatus.Text == "Not yet")
            {
                tbHabitStatus.Text = "False";
            }
            else
            {
                MessageBox.Show("Habit Status need to be Done or Not yet", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from st_updatehabit(:_habitId, :_habitName, :_habitDate, :_habitStatus)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_habitid", lblHabitIDUpdate.Text);
                cmd.Parameters.AddWithValue("_habitName", tbHabitNamef2.Text);
                cmd.Parameters.AddWithValue("_habitDate", tbHabitDatef2.Text);
                cmd.Parameters.AddWithValue("_habitStatus", bool.Parse(tbHabitStatus.Text));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data users berhasil diupdate", "Well Done!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    lblHabitIDUpdate.Text = tbHabitNamef2.Text = tbHabitDatef2.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL UPDATE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            lblHabitIDUpdate.Text = Form1.habitId_to_update;
            tbHabitNamef2.Text = Form1.habitName_to_update;
            tbHabitDatef2.Text = Form1.habitDeadline_to_update;
            tbHabitStatus.Text = Form1.habitStatus_to_update;
            
        }
    }
}
