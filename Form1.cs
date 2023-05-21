using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab_10___21i_1239
{
    public partial class DBLAB10 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cs = new SqlCommand();
        Class1 dbcon = new Class1();
        SqlDataReader dr;

        public DBLAB10()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String _username = "", _pass = "";
            String UserType = "";
            User user = new User();
            int UserId = 0;
            try
            {
                bool found = false;
                cn.Open();
                cs = new SqlCommand("Select* from Users where Email = @username and Password = @password", cn);
                cs.Parameters.AddWithValue("@username", textBox1.Text);
                cs.Parameters.AddWithValue("@password", textBox2.Text);
                dr = cs.ExecuteReader();
                dr.Read();

                user.Email = dr["Email"].ToString();
                user.Password = dr["Password"].ToString();
                user.UserType = dr["UserType"].ToString();
                user.UserID = int.Parse(dr["UserID"].ToString());
                user.Name = dr["Name"].ToString();
            

                if (dr.HasRows)
                {
                    found = true;
                 }
                else
                {
                    found = false;
                }
                dr.Close();
                cn.Close();

                if (found == true)
                {
                    if (user.UserType == "Student")
                    {
                        this.Hide();
                        Sclass f4 = new(user);
                        f4.Show();
                        //f4.ShowDialog();
                        MessageBox.Show("Account of Student. Login", "Student Account", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                    }
                    else if (user.UserType == "Teacher")
                    {
                        this.Hide();
                        Form5 f5 = new(user);
                        f5.Show();
                        //f5.ShowDialog();
                        MessageBox.Show("Account of Teacher. Login", "Teacher Account", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                    }
                    MessageBox.Show("Welcome " + _username + "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                    textBox2.Clear();
                    //this.Hide();
                    //Form3 frm = new Form3();

                    /* frm.textBox2 = _pass;
                     frm.textBox1 = _username;*/
                    //frm.Show();
                    //frm.ShowDialog();

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 F6 = new();
            F6.Show();
            //F3.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}