using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blotter_System
{
    public partial class wndwHome : Form
    {
        public wndwHome()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            wndwForm form = new wndwForm();
            this.Hide();
            form.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            wndwLogin login = new wndwLogin();
            this.Hide();
            login.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            wndwForm form = new wndwForm();
            this.Hide();
            form.Show();
        }

        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            wndwChangeUsername cu = new wndwChangeUsername();
            this.Hide();
            cu.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            wndwChangePassword cp = new wndwChangePassword();
            this.Hide();
            cp.Show();
        }
    }
}
