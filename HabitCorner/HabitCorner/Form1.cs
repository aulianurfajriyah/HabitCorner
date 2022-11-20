using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HabitCorner_Class;
using Npgsql;

namespace HabitCorner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=Farhan011;Database=HabitCorner";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

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
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();

            /*if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from st_updatehabit(:_habitId, :_habitName, :_habitDate)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_habitid", r.Cells["_habitid"].Value.ToString());
                cmd.Parameters.AddWithValue("_habitName", tbHabitName.Text);
                cmd.Parameters.AddWithValue("_habitDate", tbHabitDate.Text);
                //cmd.Parameters.AddWithValue("_habitStatus", tbHabitStatus.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data users berhasil diupdate", "Well Done!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnRefresh.PerformClick();
                    tbHabitName.Text = tbHabitDate.Text = tbHabitStatus.Text = null;
                    r = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL UPDATE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();*/

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //var form3 = new Form3();
            //form3.Show();
            if (r==null)
            {
                MessageBox.Show("Mohon pilih baris yang akan dihapus", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Apakah benar anda ingin menghapus data " + r.Cells["_habitName"].Value.ToString()+" ?", "Hapus data terkonfirmasi", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                try
                {
                    conn.Open();
                    sql = @"select * from st_deletehabit(:_habitId)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_habitid", r.Cells["_habitid"].Value.ToString());
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data users berhasil dihapus", "Well Done!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        pictureBox5_Click(this.pictureBox5, null);
                        tbHabitName.Text = tbHabitDate.Text = tbHabitStatus.Text = null;
                        r = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "FAIL Delete!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            conn.Close();  

        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                tbHabitName.Text = r.Cells["_habitName"].Value.ToString();
                tbHabitDate.Text = r.Cells["_habitDate"].Value.ToString();
                tbHabitStatus.Text = r.Cells["_habitStatus"].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "select * from st_selecthabit()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();

            //try
            //{
            //    conn.Open();
            //    sql = @"select * from st_inserthabit(:_habitName, :_habitDate)";
            //    cmd = new NpgsqlCommand(sql, conn);
            //    cmd.Parameters.AddWithValue("_habitName", tbHabitName.Text);
            //    cmd.Parameters.AddWithValue("_habitDate", tbHabitDate.Text);
            //    if ((int)cmd.ExecuteScalar() == 1)
            //    {
            //        MessageBox.Show("Data users berhasil disimpan", "Well Done!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        conn.Close();
            //        btnRefresh.PerformClick();
            //        tbHabitName.Text = tbHabitDate.Text = null;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message, "INSERT FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    conn.Close();
            //}
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "select * from st_selecthabit()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
    }
}
