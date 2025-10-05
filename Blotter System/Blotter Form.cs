using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace Blotter_System
{
    public partial class wndwForm : Form
    {
        public static string connstr = "server = localhost; user = root; database = db_blotter; port = 3306; password = admin;";
        MySqlConnection conn = new MySqlConnection(connstr);
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataSet ds = new DataSet();

        int ID = 0;
        string status = "Under Observation";
        bool submitted = false;

        public wndwForm()
        {
            InitializeComponent();
        }

        private void wndwForm_Load(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            btnReset.Enabled = false;

            ShowData();

            if (dgComplains.Rows.Count != 0)
                dgComplains.CurrentCell.Selected = false;
        }

        private void txtCFName_TextChanged(object sender, EventArgs e)
        {
            EmptyString();
        }

        private void txtCMName_TextChanged(object sender, EventArgs e)
        {
            EmptyString();
        }

        private void txtCLName_TextChanged(object sender, EventArgs e)
        {
            EmptyString();
        }

        private void txtCAddress_TextChanged(object sender, EventArgs e)
        {
            EmptyString();
        }

        private void txtCNo_TextChanged(object sender, EventArgs e)
        {
            EmptyString();
        }

        private void txtDFName_TextChanged(object sender, EventArgs e)
        {
            EmptyString();
        }

        private void txtDMName_TextChanged(object sender, EventArgs e)
        {
            EmptyString();
        }

        private void txtDLName_TextChanged(object sender, EventArgs e)
        {
            EmptyString();
        }

        private void txtDAddress_TextChanged(object sender, EventArgs e)
        {
            EmptyString();
        }

        private void txtDNo_TextChanged(object sender, EventArgs e)
        {
            EmptyString();
        }

        private void txtComplain_TextChanged(object sender, EventArgs e)
        {
            EmptyString();
        }

        private void checkYes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkYes.Checked == true)
                checkNo.Checked = false;

            EmptyString();
        }

        private void checkNo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNo.Checked == true)
                checkYes.Checked = false;

            EmptyString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int n;

            if ((int.TryParse(txtCFName.Text, out n) == false) && (int.TryParse(txtCLName.Text, out n) == false) && (int.TryParse(txtDFName.Text, out n) == false) && (int.TryParse(txtDLName.Text, out n) == false))
            {
                if ((txtCNo.Text != string.Empty) || (txtDNo.Text != string.Empty) || (txtCMName.Text != string.Empty) || (txtDMName.Text != string.Empty))
                {
                    if ((int.TryParse(txtCNo.Text, out n) == true) || (int.TryParse(txtDNo.Text, out n) == true) || (int.TryParse(txtCMName.Text, out n) == false) || (int.TryParse(txtDMName.Text, out n) == false))
                    {
                        conn.Open();

                        string sqlStatement = "INSERT INTO `complain details` VALUES (@id, @complainant, @defendant, @confrontation, @complain, @date, @status); INSERT INTO `complainant details` VALUES (@id, @cfname, @cmname, @clname, @caddress, @cdob, @ctelno); INSERT INTO `defendant details` VALUES (@id, @dfname, @dmname, @dlname, @daddress, @ddob, @dtelno);";
                        MySqlCommand comm = new MySqlCommand(sqlStatement, conn);

                        comm.Parameters.AddWithValue("@id", ID);
                        comm.Parameters.AddWithValue("@complainant", (txtCFName.Text + " " + txtCMName.Text + " " + txtCLName.Text));
                        comm.Parameters.AddWithValue("@defendant", (txtDFName.Text + " " + txtDMName.Text + " " + txtDLName.Text));

                        if (checkYes.Checked == true)
                        {
                            comm.Parameters.AddWithValue("@confrontation", checkYes.Text);
                        }

                        if (checkNo.Checked == true)
                        {
                            comm.Parameters.AddWithValue("@confrontation", checkNo.Text);
                        }

                        comm.Parameters.AddWithValue("@complain", txtComplain.Text);
                        comm.Parameters.AddWithValue("@date", dtpDate.Text);
                        comm.Parameters.AddWithValue("@status", status);

                        comm.Parameters.AddWithValue("@cfname", txtCFName.Text);
                        comm.Parameters.AddWithValue("@cmname", txtCMName.Text);
                        comm.Parameters.AddWithValue("@clname", txtCLName.Text);
                        comm.Parameters.AddWithValue("@caddress", txtCAddress.Text);
                        comm.Parameters.AddWithValue("@cdob", dtpCDOB.Text);
                        comm.Parameters.AddWithValue("@ctelno", txtCNo.Text);

                        comm.Parameters.AddWithValue("@dfname", txtDFName.Text);
                        comm.Parameters.AddWithValue("@dmname", txtDMName.Text);
                        comm.Parameters.AddWithValue("@dlname", txtDLName.Text);
                        comm.Parameters.AddWithValue("@daddress", txtDAddress.Text);
                        comm.Parameters.AddWithValue("@ddob", dtpDDOB.Text);
                        comm.Parameters.AddWithValue("@dtelno", txtDNo.Text);

                        comm.ExecuteNonQuery();
                        ShowData();
                        dgComplains.CurrentCell.Selected = false;

                        submitted = true;
                        MessageBox.Show("Succesfully submitted.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.None);

                        conn.Close();

                        txtCFName.Text = "";
                        txtCMName.Text = "";
                        txtCLName.Text = "";
                        txtCAddress.Text = "";
                        txtCNo.Text = "";
                        txtDFName.Text = "";
                        txtDMName.Text = "";
                        txtDLName.Text = "";
                        txtDAddress.Text = "";
                        txtDNo.Text = "";
                        txtComplain.Text = "";
                        checkYes.Checked = false;
                        checkNo.Checked = false;
                    }

                    else
                        MessageBox.Show("Invalid input value.", "Submission Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    conn.Open();

                    string sqlStatement = "INSERT INTO `complain details` VALUES (@id, @complainant, @defendant, @confrontation, @complain, @date, @status); INSERT INTO `complainant details` VALUES (@id, @cfname, @cmname, @clname, @caddress, @cdob, @ctelno); INSERT INTO `defendant details` VALUES (@id, @dfname, @dmname, @dlname, @daddress, @ddob, @dtelno);";
                    MySqlCommand comm = new MySqlCommand(sqlStatement, conn);

                    comm.Parameters.AddWithValue("@id", ID);
                    comm.Parameters.AddWithValue("@complainant", (txtCFName.Text + " " + txtCMName.Text + " " + txtCLName.Text));
                    comm.Parameters.AddWithValue("@defendant", (txtDFName.Text + " " + txtDMName.Text + " " + txtDLName.Text));

                    if (checkYes.Checked == true)
                    {
                        comm.Parameters.AddWithValue("@confrontation", checkYes.Text);
                    }

                    if (checkNo.Checked == true)
                    {
                        comm.Parameters.AddWithValue("@confrontation", checkNo.Text);
                    }

                    comm.Parameters.AddWithValue("@complain", txtComplain.Text);
                    comm.Parameters.AddWithValue("@date", dtpDate.Text);
                    comm.Parameters.AddWithValue("@status", status);

                    comm.Parameters.AddWithValue("@cfname", txtCFName.Text);
                    comm.Parameters.AddWithValue("@cmname", txtCMName.Text);
                    comm.Parameters.AddWithValue("@clname", txtCLName.Text);
                    comm.Parameters.AddWithValue("@caddress", txtCAddress.Text);
                    comm.Parameters.AddWithValue("@cdob", dtpCDOB.Text);
                    comm.Parameters.AddWithValue("@ctelno", txtCNo.Text);

                    comm.Parameters.AddWithValue("@dfname", txtDFName.Text);
                    comm.Parameters.AddWithValue("@dmname", txtDMName.Text);
                    comm.Parameters.AddWithValue("@dlname", txtDLName.Text);
                    comm.Parameters.AddWithValue("@daddress", txtDAddress.Text);
                    comm.Parameters.AddWithValue("@ddob", dtpDDOB.Text);
                    comm.Parameters.AddWithValue("@dtelno", txtDNo.Text);

                    comm.ExecuteNonQuery();
                    ShowData();
                    dgComplains.CurrentCell.Selected = false;

                    submitted = true;
                    MessageBox.Show("Succesfully submitted.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.None);

                    conn.Close();

                    txtCFName.Text = "";
                    txtCMName.Text = "";
                    txtCLName.Text = "";
                    txtCAddress.Text = "";
                    txtCNo.Text = "";
                    txtDFName.Text = "";
                    txtDMName.Text = "";
                    txtDLName.Text = "";
                    txtDAddress.Text = "";
                    txtDNo.Text = "";
                    txtComplain.Text = "";
                    checkYes.Checked = false;
                    checkNo.Checked = false;
                }
            }

            else
                MessageBox.Show("Invalid input value.", "Submission Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if ((txtCFName.Text != string.Empty) || (txtCLName.Text != string.Empty) || (txtCMName.Text != string.Empty) || (txtCAddress.Text != string.Empty) || (txtCNo.Text != string.Empty) || (txtDFName.Text != string.Empty) || (txtDLName.Text != string.Empty) || (txtDMName.Text != string.Empty) || (txtDAddress.Text != string.Empty) || (txtDNo.Text != string.Empty) || (txtComplain.Text != string.Empty))
            {
                if (submitted == false)
                {
                    if (MessageBox.Show("Changes haven't been saved. Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        wndwHome home = new wndwHome();
                        this.Hide();
                        home.Show();
                    }
                }

                else
                    if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        wndwHome home = new wndwHome();
                        this.Hide();
                        home.Show();
                    }
            }

            else
            {
                if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    wndwHome home = new wndwHome();
                    this.Hide();
                    home.Show();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCFName.Text = "";
            txtCMName.Text = "";
            txtCLName.Text = "";
            txtCAddress.Text = "";
            txtCNo.Text = "";
            txtDFName.Text = "";
            txtDMName.Text = "";
            txtDLName.Text = "";
            txtDAddress.Text = "";
            txtDNo.Text = "";
            txtComplain.Text = "";
            checkYes.Checked = false;
            checkNo.Checked = false;
        }

        private void txtCompName_TextChanged(object sender, EventArgs e)
        {
            if (txtCompName.Text != string.Empty)
            {
                string sqlStatement = "SELECT * FROM `complain details` WHERE `complainant name` LIKE '%" + txtCompName.Text + "%'";

                MySqlDataAdapter da = new MySqlDataAdapter(sqlStatement, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgComplains.DataSource = dt;
            }

            else
            {
                ShowData();
                dgComplains.CurrentCell.Selected = false;
            }
        }

        private void txtCompNo_TextChanged(object sender, EventArgs e)
        {
            if (txtCompNo.Text != string.Empty)
            {
                string sqlStatement = "SELECT * FROM `complain details` WHERE `complain no` LIKE '%" + txtCompNo.Text + "%'";

                MySqlDataAdapter da = new MySqlDataAdapter(sqlStatement, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgComplains.DataSource = dt;
            }

            else
            {
                ShowData();
                dgComplains.CurrentCell.Selected = false;
            }
        }

        private void btnComDetails_Click(object sender, EventArgs e)
        {
            wndwComplainant comp = new wndwComplainant();
            this.Hide();
            comp.Show();
        }

        private void btnDefDetails_Click(object sender, EventArgs e)
        {
            wndwDefendant def = new wndwDefendant();
            this.Hide();
            def.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgComplains.CurrentCell.Selected != false)
            {
                if (MessageBox.Show("Are you sure you want to delete this item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();

                    int selectedRowIndex = dgComplains.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgComplains.Rows[selectedRowIndex];
                    string txt = Convert.ToString(selectedRow.Cells["Complain No"].Value);

                    string sqlStatement = "DELETE FROM `complain details` WHERE `Complain No` = @compno; DELETE FROM `complainant details` WHERE `Complain No` = @compno; DELETE FROM `defendant details` WHERE `Complain No` = @compno;";
                    MySqlCommand comm = new MySqlCommand(sqlStatement, conn);

                    comm.Parameters.AddWithValue("@compno", txt);
                    comm.ExecuteNonQuery();
                    ShowData();
                    dgComplains.CurrentCell.Selected = false;

                    MessageBox.Show("Succesfully deleted.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.None);

                    conn.Close();
                }
            }

            else
                MessageBox.Show("Please select the data you want to delete.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all the records?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();

                string sqlStatement = "TRUNCATE TABLE `complain details`; TRUNCATE TABLE `complainant details`; TRUNCATE TABLE `defendant details`;";
                MySqlCommand comm = new MySqlCommand(sqlStatement, conn);
                comm.ExecuteNonQuery();
                ShowData();

                MessageBox.Show("Succesfully deleted.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.None);

                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            wndwUpdate update = new wndwUpdate();
            this.Hide();
            update.Show();
        }

        private void EmptyString()
        {
            if (((txtCFName.Text != string.Empty) || (txtCLName.Text != string.Empty) || (txtCAddress.Text != string.Empty) || (txtDFName.Text != string.Empty) || (txtDLName.Text != string.Empty) || (txtDAddress.Text != string.Empty) || (txtComplain.Text != string.Empty)) || (checkYes.Checked == true || checkNo.Checked == true))
                btnReset.Enabled = true;

            if (((txtCFName.Text != string.Empty) && (txtCLName.Text != string.Empty) && (txtCAddress.Text != string.Empty) && (txtDFName.Text != string.Empty) && (txtDLName.Text != string.Empty) && (txtDAddress.Text != string.Empty) && (txtComplain.Text != string.Empty)) && (checkYes.Checked == true || checkNo.Checked == true))
                btnSubmit.Enabled = true;

            else
            {
                btnSubmit.Enabled = false;
                btnReset.Enabled = false;
            }
        }

        private void ShowData()
        {
            string sqlStatement = "SELECT * FROM `complain details`";
            da = new MySqlDataAdapter(sqlStatement, conn);
            ds = new DataSet();
            da.Fill(ds, "`complain details`");
            dgComplains.DataSource = ds;
            dgComplains.DataMember = "`complain details`";
        }
    }
}
