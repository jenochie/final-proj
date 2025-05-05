using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;

namespace task4
{
    public partial class Form1 : Form
    {
        dbCon con = new dbCon();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int progress = 1;
        private void btnLog_Click(object sender, EventArgs e)
        {
            con.openCon();
            MySqlCommand cmd = new MySqlCommand("Select * from user where name = @un and pass = @pass", con.getCon());
            var c = cmd.Parameters;
            c.AddWithValue("un", txtUser.Text.Trim());
            c.AddWithValue("pass", txtPass.Text.Trim());

            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Succesfull log in");
                new frmMenu().Show();

            }
            else
            {

                txtUser.Focus();
                MessageBox.Show("Max attempt is 3, Your current tries is : " + progress);
                progress++;
                if (progress == 4)
                {
                    MessageBox.Show("Max security attemps application will be closed");
                    this.Close();
                }
            }
            dr.Close();
            cmd.Dispose();
            con.closeCon();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
