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
    public partial class wndwDefendant : Form
    {
        public static string connstr = "server = localhost; user = root; database = db_blotter; port = 3306; password = admin;";
        MySqlConnection conn = new MySqlConnection(connstr);
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataSet ds = new DataSet();

        public wndwDefendant()
        {
            InitializeComponent();
        }

        private void wndwDefendant_Load(object sender, EventArgs e)
        {
            ShowData();

            if (dgDefendants.Rows.Count != 0)
                dgDefendants.CurrentCell.Selected = false;
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            if (txtLName.Text != string.Empty)
            {
                string sqlStatement = "SELECT * FROM `defendant details` WHERE `last name` LIKE '%" + txtLName.Text + "%'";

                MySqlDataAdapter da = new MySqlDataAdapter(sqlStatement, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgDefendants.DataSource = dt;
            }

            else
            {
                ShowData();
                dgDefendants.CurrentCell.Selected = false;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            wndwForm form = new wndwForm();
            this.Hide();
            form.Show();
        }

        private void ShowData()
        {
            string sqlStatement = "SELECT * FROM `defendant details`";
            da = new MySqlDataAdapter(sqlStatement, conn);
            ds = new DataSet();
            da.Fill(ds, "`defendant details`");
            dgDefendants.DataSource = ds;
            dgDefendants.DataMember = "`defendant details`";
        }
    }
}
