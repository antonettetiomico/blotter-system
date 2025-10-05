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
    public partial class wndwUpdate : Form
    {
        public static string connstr = "server = localhost; user = root; database = db_blotter; port = 3306; password = admin;";
        MySqlConnection conn = new MySqlConnection(connstr);

        public wndwUpdate()
        {
            InitializeComponent();
        }

        private void wndwUpdate_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
        }

        private void txtCompNo_TextChanged(object sender, EventArgs e)
        {
            if ((txtCompNo.Text != string.Empty) && (rbtUnderObv.Checked == true || rbtCleared.Checked == true))
                btnUpdate.Enabled = true;

            else
                btnUpdate.Enabled = false;
        }

        private void rbtUnderObv_CheckedChanged(object sender, EventArgs e)
        {
            if ((txtCompNo.Text != string.Empty) && (rbtUnderObv.Checked == true || rbtCleared.Checked == true))
                btnUpdate.Enabled = true;

            else
                btnUpdate.Enabled = false;
        }

        private void rbtCleared_CheckedChanged(object sender, EventArgs e)
        {
            if ((txtCompNo.Text != string.Empty) && (rbtUnderObv.Checked == true || rbtCleared.Checked == true))
                btnUpdate.Enabled = true;

            else
                btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();

            string sqlStatement = "SELECT * FROM `complain details` WHERE `complain no` = @compno";

            MySqlCommand comm = new MySqlCommand(sqlStatement, conn);
            comm.Parameters.AddWithValue("@compno", txtCompNo.Text);
            MySqlDataReader dr = comm.ExecuteReader();

            int count = 0;

            while (dr.Read())
            {
                count += 1;
            }

            dr.Close();

            if (count == 1)
            {
                string sqlQuery = "UPDATE `complain details` SET status = @status WHERE `complain no` = @compnum";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

                if (rbtUnderObv.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@status", rbtUnderObv.Text);
                }

                else if (rbtCleared.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@status", rbtCleared.Text);
                }

                cmd.Parameters.AddWithValue("@compnum", txtCompNo.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully modified.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            else
            {
                MessageBox.Show("Complain number does not exist.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            wndwForm form = new wndwForm();
            this.Hide();
            form.Show();
        }
    }
}
