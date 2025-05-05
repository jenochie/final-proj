using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace task4
{
    public partial class task3 : Form
    {
        dbCon con = new dbCon();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;

        public task3()
        {
            InitializeComponent();
        }

        private void task3_Load(object sender, EventArgs e)
        {
            clear();
            btnSave.Text = "Save";
            loadData();
            getMax();
            txtID.Enabled = false;

        }
        private void getMax()
        {
            string getID;
            con.openCon();
            cmd.Connection = con.getCon();
            cmd.CommandText = "select max(id) from products";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    getID = dr[0].ToString();
                    txtID.Text = (Convert.ToInt32(getID) + 1).ToString();
                    //this is to add 1 to the current max ID in the table
                }
                con.closeCon();
            }
        }


        private void clear()
        {
            txtID.Text = txtName.Text = txtDesc.Text = txtQty.Text = txtPrice.Text = txtAdd.Text = "";
            txtQty.Enabled = true;
        }

        private void loadData()
        {
            con.openCon();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT id, name, `desc`, qty, p, s FROM products", con.getCon());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProd.DataSource = dt;
            dgvProd.Columns[5].Visible = false;
            con.closeCon();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.openCon();
            // check if all fields has input
            if (txtID.Text == "" || txtName.Text == "" || txtDesc.Text == "" || txtQty.Text == "")
            {
                MessageBox.Show("Fill in all fields", "Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Adding record if username does not exists
            if (btnSave.Text == "Save")
            {
                if (txtID.Text != null)
                {
                    cmd.Connection = con.getCon();
                    cmd.CommandText = "select * from products where name = '" + txtName.Text + "' ";
                    cmd.ExecuteNonQuery();
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("ItemID Already Exists", "Error Saving", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtName.Text = "";
                        con.closeCon();
                        return;
                    }
                    con.closeCon();
                }

                con.openCon();
                //add new record in database
                cmd.CommandText = "Insert into products values (@id, @name, @desc, @qty,@p,@s)";
                var c = cmd.Parameters;
                c.Clear();
                c.AddWithValue("id", txtID.Text.Trim());
                c.AddWithValue("name", txtName.Text.Trim());
                c.AddWithValue("desc", txtDesc.Text);
                c.AddWithValue("qty", txtQty.Text);
                c.AddWithValue("p", txtPrice.Text);
                c.AddWithValue("s", "Active");
                cmd.ExecuteNonQuery();
                con.closeCon();
                MessageBox.Show("Saved record successfully", "Saving New Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                loadData();
                getMax();

            }
        }

    }
}

