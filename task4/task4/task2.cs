using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace task4
{
    public partial class task2 : Form
    {
        dbCon con = new dbCon();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;

        public task2()
        {
            InitializeComponent();
        }

        private void task2_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void getMaxID()
        {
            string getID;
            con.openCon();
            cmd.Connection = con.getCon();
            cmd.CommandText = "select max(id) from user";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                getID = dr[0].ToString();
                label5.Text = (Convert.ToInt32(getID) + 1).ToString();

            }
            con.closeCon();


        }


        void loadData()
        {
            con.openCon();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from user", con.getCon());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvUser.DataSource = dt;
            con.closeCon();
        }

        void clearData()
        {
            textBox2.Text = textBox1.Text = comboBox1.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add") { getMaxID(); }



            {
                cmd.Connection = con.getCon();
                con.openCon();
                cmd.CommandText = "Insert into user(id,name,pass,usertype) values (@id,@un,@pass,@usertype)";
                var c = cmd.Parameters;
                c.Clear();
                c.AddWithValue("id", label5.Text);
                c.AddWithValue("un", textBox1.Text.Trim());
                c.AddWithValue("pass", textBox2.Text.Trim());
                c.AddWithValue("usertype", comboBox1.Text.Trim());
                cmd.ExecuteNonQuery();
                con.closeCon();
                MessageBox.Show("Saved record");
                loadData();
                textBox1.Focus();
            }
            if (btnAdd.Text == "Update")
            {
                cmd.Connection = con.getCon();
                cmd.CommandText = "Update  user set name = @un, password = @pass, usertype = @usertype where name = @un";
                var c = cmd.Parameters;
                c.Clear();
                c.AddWithValue("id", label5.Text);
                c.AddWithValue("un", textBox1.Text.Trim());
                c.AddWithValue("pass", textBox2.Text.Trim());
                c.AddWithValue("usertype", comboBox1.Text.Trim());
                cmd.ExecuteNonQuery();
                con.closeCon();
                MessageBox.Show("Updated Record Succesfully");
                loadData();
                clearData();
                textBox1.Focus();
                getMaxID();
                btnAdd.Text = "Add";

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {





        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string valSearch = textBox3.Text;
            con.openCon();
            MySqlCommand cmd = new MySqlCommand("Select * from user where name Like '%" + textBox3.Text + "%' ", con.getCon());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvUser.DataSource = dt;
            con.closeCon();
        }
    }
}
    

