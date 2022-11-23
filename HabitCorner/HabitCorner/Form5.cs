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
    public partial class Form5 : Form
    {
        public static string username = "Your name here!";
        public static string birthDate = "DD/MM/YY";
        public Form5()
        {
            InitializeComponent();
        }
        //private NpgsqlConnection conn;
        //string connstring = "Host=localhost;Port=5432;Username=postgres;Password=aulianf1007;Database=Profile_HabitCorner";

        //public static NpgsqlCommand cmd;
        //private string sql = null;

        private void Form5_Load(object sender, EventArgs e)
        {
            //conn = new NpgsqlConnection(connstring);
        }

        private void btnSaveUsername_Click(object sender, EventArgs e)
        {
            username = tbUsername.Text;
            birthDate = tbBirthDate.Text;
            //conn = new NpgsqlConnection(connstring);
            //try
            //{
            //    conn.Open();
            //    sql = @"select * from st_insertUsername(:_username)";
            //    cmd = new NpgsqlCommand(sql, conn);
            //    cmd.Parameters.AddWithValue("_username", tbUsername.Text);
            //    if ((int)cmd.ExecuteScalar() == 1)
            //    {
            //        MessageBox.Show("Nama users berhasil disimpan", "Well Done!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        conn.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message, "FAIL UPDATE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //conn.Close();
            this.Close();
        }
    }
}
