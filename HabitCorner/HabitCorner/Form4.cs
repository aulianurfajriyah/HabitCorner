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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            DataGridView _dgv = new DataGridView() { Dock = DockStyle.Fill };
            Controls.Add(_dgv);
        }

        public void CorrectWindowSize()
        {
            int width = WinObjFunctions.CountGridWidth(_dgv);
            ClientSize = new Size(width, ClientSize.Height);
        }

        DataGridView _dgv;

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=HabitCorner";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Form4_Load(object sender, EventArgs e)
        {
            int screenwidth = Screen.PrimaryScreen.Bounds.Size.Width;
            int formwidth = this.Width;
            this.Location = new Point(screenwidth - formwidth, 0);

            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                dgvData_deploy.DataSource = null;
                sql = "select * from st_selectHabit()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData_deploy.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void dgvData_deploy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData_deploy.Rows[e.RowIndex];
            }
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvData_deploy.DataSource = null;
                sql = "select * from st_selecthabit()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData_deploy.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }
    }

    public static class WinObjFunctions
    {
        public static int CountGridWidth(DataGridView dgv)
        {
            int width = 0;
            foreach (DataGridViewColumn column in dgv.Columns)
                if (column.Visible == true)
                    width += column.Width;
            return width += 20;
        }
    }
}
