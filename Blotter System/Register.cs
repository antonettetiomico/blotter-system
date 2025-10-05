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
    public partial class wndwRegister : Form
    {
        public static string connstr = "server = localhost; user = root; database = db_blotter; port = 3306; password = admin;";
        MySqlConnection conn = new MySqlConnection(connstr);

        public wndwRegister()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;
            txtPassword.PasswordChar = '•';
            txtConfirmPassword.PasswordChar = '•';
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if ((txtUsername.Text != string.Empty) && (txtPassword.Text != string.Empty) && (txtConfirmPassword.Text != string.Empty))
                btnRegister.Enabled = true;

            else
                btnRegister.Enabled = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if ((txtUsername.Text != string.Empty) && (txtPassword.Text != string.Empty) && (txtConfirmPassword.Text != string.Empty))
                btnRegister.Enabled = true;

            else
                btnRegister.Enabled = false;
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if ((txtUsername.Text != string.Empty) && (txtPassword.Text != string.Empty) && (txtConfirmPassword.Text != string.Empty))
                btnRegister.Enabled = true;

            else
                btnRegister.Enabled = false;
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked == true)
                txtPassword.PasswordChar = '\0';

            else
                txtPassword.PasswordChar = '•';
        }

        private void checkConfirmPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkConfirmPass.Checked == true)
                txtConfirmPassword.PasswordChar = '\0';

            else
                txtConfirmPassword.PasswordChar = '•';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                conn.Open();

                string sqlStatement = "SELECT * FROM login WHERE username = @username AND password = @password";

                MySqlCommand comm = new MySqlCommand(sqlStatement, conn);
                comm.Parameters.AddWithValue("@username", txtUsername.Text);
                comm.Parameters.AddWithValue("@password", txtPassword.Text);
                MySqlDataReader dr = comm.ExecuteReader();

                int count = 0;

                while (dr.Read())
                {
                    count += 1;
                }

                dr.Close();

                if (count == 0)
                {
                    string sqlQuery = "INSERT INTO login VALUES (@username, @password)";

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account successfully registered.", "Register Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                }

                else
                    MessageBox.Show("Account already registered.", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
                MessageBox.Show("Passwords don't match.", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            wndwLogin login = new wndwLogin();
            this.Hide();
            login.Show();
        }
    }
}
