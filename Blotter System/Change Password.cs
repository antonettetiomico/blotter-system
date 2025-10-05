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
    public partial class wndwChangePassword : Form
    {
        public static string connstr = "server = localhost; user = root; database = db_blotter; port = 3306; password = admin;";
        MySqlConnection conn = new MySqlConnection(connstr);

        public wndwChangePassword()
        {
            InitializeComponent();
        }

        private void wndwChangePassword_Load(object sender, EventArgs e)
        {
            btnChange.Enabled = false;
            txtOldPassword.PasswordChar = '•';
            txtNewPassword.PasswordChar = '•';
        }

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {
            if ((txtOldPassword.Text != string.Empty) && (txtNewPassword.Text != string.Empty))
                btnChange.Enabled = true;

            else
                btnChange.Enabled = false;
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if ((txtOldPassword.Text != string.Empty) && (txtNewPassword.Text != string.Empty))
                btnChange.Enabled = true;

            else
                btnChange.Enabled = false;
        }

        private void checkOldPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOldPass.Checked == true)
                txtOldPassword.PasswordChar = '\0';

            else
                txtOldPassword.PasswordChar = '•';
        }

        private void checkNewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNewPass.Checked == true)
                txtNewPassword.PasswordChar = '\0';

            else
                txtNewPassword.PasswordChar = '•';
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            conn.Open();

            string sqlStatement = "SELECT * FROM login WHERE password = @oldpass";

            MySqlCommand comm = new MySqlCommand(sqlStatement, conn);
            comm.Parameters.AddWithValue("@oldpass", txtOldPassword.Text);
            MySqlDataReader dr = comm.ExecuteReader();

            int count = 0;

            while (dr.Read())
            {
                count += 1;
            }

            dr.Close();

            if (count == 1)
            {
                if (MessageBox.Show("Are you sure you want to change your password?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sqlQuery = "UPDATE login SET password = @newpass WHERE password = @oldpass";

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

                    cmd.Parameters.AddWithValue("@newpass", txtNewPassword.Text);
                    cmd.Parameters.AddWithValue("@oldpass", txtOldPassword.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Password successfully changed.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }

            else
            {
                MessageBox.Show("Old password doesn't match our record.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
