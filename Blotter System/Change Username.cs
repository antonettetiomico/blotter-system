using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Blotter_System
{
    public partial class wndwChangeUsername : Form
    {
        public static string connstr = "server = localhost; user = root; database = db_blotter; port = 3306; password = admin;";
        MySqlConnection conn = new MySqlConnection(connstr);
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataSet ds = new DataSet();

        public wndwChangeUsername()
        {
            InitializeComponent();
        }

        private void wndwChangeUsername_Load(object sender, EventArgs e)
        {
            btnChange.Enabled = false;
        }

        private void txtOldUsername_TextChanged(object sender, EventArgs e)
        {
            if ((txtOldUsername.Text != string.Empty) && (txtNewUsername.Text != string.Empty))
                btnChange.Enabled = true;

            else
                btnChange.Enabled = false;
        }

        private void txtNewUsername_TextChanged(object sender, EventArgs e)
        {
            if ((txtOldUsername.Text != string.Empty) && (txtNewUsername.Text != string.Empty))
                btnChange.Enabled = true;

            else
                btnChange.Enabled = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            conn.Open();

            string sqlStatement = "SELECT * FROM login WHERE username = @olduser";

            MySqlCommand comm = new MySqlCommand(sqlStatement, conn);
            comm.Parameters.AddWithValue("@olduser", txtOldUsername.Text);
            MySqlDataReader dr = comm.ExecuteReader();

            int count = 0;

            while (dr.Read())
            {
                count += 1;
            }

            dr.Close();

            if (count == 1)
            {
                if (MessageBox.Show("Are you sure you want to change your username?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sqlQuery = "UPDATE login SET username = @newuser WHERE username = @olduser";

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

                    cmd.Parameters.AddWithValue("@newuser", txtNewUsername.Text);
                    cmd.Parameters.AddWithValue("@olduser", txtOldUsername.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Username successfully changed.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }

            else
            {
                MessageBox.Show("Old username not found.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            wndwHome home = new wndwHome();
            this.Hide();
            home.Show();
        }
    }
}
