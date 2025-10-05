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
    public partial class wndwLogin : Form
    {
        public static string connstr = "server = localhost; user = root; database = db_blotter; port = 3306; password = admin;";
        MySqlConnection conn = new MySqlConnection(connstr);

        public wndwLogin()
        {
            InitializeComponent();
        }

        private void wndwLogin_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if ((txtUsername.Text != string.Empty) && (txtPassword.Text != string.Empty))
                btnLogin.Enabled = true;

            else
                btnLogin.Enabled = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';

            if ((txtUsername.Text != string.Empty) && (txtPassword.Text != string.Empty))
                btnLogin.Enabled = true;

            else
                btnLogin.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text != string.Empty) && (txtPassword.Text != string.Empty))
            {
                conn.Open();

                string sqlstatement = "SELECT * FROM login WHERE username = @user AND password = @pass";

                MySqlCommand comm = new MySqlCommand(sqlstatement, conn);
                comm.Parameters.AddWithValue("@user", txtUsername.Text);
                comm.Parameters.AddWithValue("@pass", txtPassword.Text);

                MySqlDataReader dr = comm.ExecuteReader();

                int count = 0;

                while (dr.Read())
                {
                    count += 1;
                }

                if (count == 1)
                {
                    MessageBox.Show("Successfully logged in.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                    wndwHome home = new wndwHome();
                    this.Hide();
                    home.Show();
                }
                else
                    MessageBox.Show("Invalid username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                conn.Close();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            wndwRegister register = new wndwRegister();
            this.Hide();
            register.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
