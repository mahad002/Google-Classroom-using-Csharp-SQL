using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Lab_10___21i_1239
{
    public partial class Form6 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cs = new SqlCommand();
        Class1 dbcon = new Class1();
        SqlDataReader dr;

        User user = new User();
        public Form6()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String _email = "", _pass = "", _name = "";
            String UserType = "";

            if (string.IsNullOrEmpty(name.Text))
            {
                MessageBox.Show("Textbox is empty");
            }
            if (string.IsNullOrEmpty(email.Text))
            {
                MessageBox.Show("Textbox is empty");
            }
            if (string.IsNullOrEmpty(pass.Text))
            {
                MessageBox.Show("Textbox is empty");
            }


            if (studentButton.Checked)
            {
                UserType = "Student";
            }
            else if (teacherButton.Checked)
            {
                UserType = "Teacher";
            }
            int UserId = 0;
            try
            {
                bool found = false;
                cn.Open();
                cs = new SqlCommand("INSERT INTO Users (Name, Email, Password, UserType) VALUES (@name, @email, @pass, @UserType)", cn);
                cs.Parameters.AddWithValue("@name", name.Text);
                cs.Parameters.AddWithValue("@email", email.Text);
                cs.Parameters.AddWithValue("@pass", pass.Text);
                cs.Parameters.AddWithValue("@UserType", UserType);
                dr = cs.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    found = true;
                    user.Email = dr["Email"].ToString();
                    user.Password = dr["Password"].ToString();
                    user.UserType = dr["UserType"].ToString();
                    user.UserID = int.Parse(dr["UserID"].ToString());
                    user.Name = dr["Name"].ToString();
                }
                else
                {
                    found = true;
                }
                dr.Close();
                cn.Close();

                if (found == true)
                {
                    if (UserType == "Student")
                    {
                        this.Hide();
                        Sclass f4 = new(user);
                        f4.Show();
                        //f4.ShowDialog();
                        MessageBox.Show("Account of Student. Login", "Student Account", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                    }
                    else if (UserType == "Teacher")
                    {
                        this.Hide();
                        Form5 f5 = new(user);
                        f5.Show();
                        //f5.ShowDialog();
                        MessageBox.Show("Account of Teacher. Login", "Teacher Account", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                    }
                    MessageBox.Show("Welcome " + _name + "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    name.Clear();
                    email.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }

            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DBLAB10 F1 = new();
            F1.Show();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
