using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10___21i_1239
{
    public partial class Form2 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cs = new SqlCommand();
        Class1 dbcon = new Class1();
        SqlDataReader dr;
        public Form2()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool found = false;
                cn.Open();
                cs = new SqlCommand("Insert into tblUser(username,password,role,name,isactive) values(@username,@password,@role,@name,1)", cn);
                cs.Parameters.AddWithValue("@username", textBox1.Text);
                cs.Parameters.AddWithValue("@password", textBox2.Text);
                cs.Parameters.AddWithValue("@role", comboBox1.Text);
                cs.Parameters.AddWithValue("@name", textBox4.Text);
                dr = cs.ExecuteReader();
                dr.Read();
                MessageBox.Show("New Accout Created Successfully", "Saved Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form3 f3 = new Form3();
                f3.Show();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                bool found = false;
                cn.Open();
                cs = new SqlCommand("UPDATE tblUser\r\nSET password = @password\r\nWHERE username=@username;", cn);
                cs.Parameters.AddWithValue("@username", textBox6.Text);
                cs.Parameters.AddWithValue("@password", textBox5.Text);
                dr = cs.ExecuteReader();
                dr.Read();
                MessageBox.Show("Password Updated Successfully!", "Saved Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form3 f3 = new Form3();
                f3.Show();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                bool found = false;
                cn.Open();
                cs = new SqlCommand("UPDATE tblUser\r\nSET isactive = @isactive\r\nWHERE username=@username;", cn);
                cs.Parameters.AddWithValue("@username", textBox9.Text);
                if (checkBox1.Checked)
                {
                    cs.Parameters.AddWithValue("@isactive", "1");
                }
                else
                {
                    cs.Parameters.AddWithValue("@isactive", "0");
                }
               
                dr = cs.ExecuteReader();
                dr.Read();
                MessageBox.Show("Password Updated Successfully!", "Saved Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form3 f3 = new Form3();
                f3.Show();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
