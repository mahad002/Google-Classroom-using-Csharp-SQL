using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using TextBox = System.Windows.Forms.TextBox;
using System.Drawing;

namespace Lab_10___21i_1239
{
    public partial class Form5 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cs = new SqlCommand();
        SqlCommand cs1 = new SqlCommand();
        Class1 dbcon = new Class1();
        SqlDataReader dr;
        SqlDataReader dr1;
        int UserId;
        int classCount;
        List<Class> classrooms = new List<Class>();
        User user1 = new User();

        public Form5(User UserT)
        {
            user1 = UserT;
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.UserId = UserT.UserID;
            classCount = 0;
            cn.Open();
            //cs = new SqlCommand("Select *\r\nFrom Classrooms c\r\nJoin Assignments a on a.ClassroomID = c.ClassroomID\r\nJoin Users u on u.UserID = c.TeacherID\r\nWhere c.TeacherID=@ID;", cn);
            //cs.Parameters.AddWithValue("@ID", UserT.UserID.ToString());
            cs1 = new SqlCommand("Select *\r\nFrom Classrooms\r\nWhere TeacherID = @ID;", cn);
            cs1.Parameters.AddWithValue("@ID", UserT.UserID.ToString());
            dr = cs1.ExecuteReader();


            while (dr.Read())
            {
                Class classroom = new Class()
                {
                    ClassroomID = Convert.ToInt32(dr["ClassroomID"]),
                    ClassroomCode = dr["ClassroomCode"].ToString(),
                    ClassName = dr["ClassName"].ToString(),
                    TeacherID = Convert.ToInt32(dr["TeacherID"])
                };

                classrooms.Add(classroom);

                List<Assignment> assignmentsForClassroom = classroom.GetAssignmentsForClassroom(classroom.ClassroomID, UserId);
                List<Announcement> announcementsForClassroom = classroom.GetAnnouncementsForClassroom(classroom.ClassroomID, UserId);
                List<Material> materialsForClassroom = classroom.GetMaterialsForClassroom(classroom.ClassroomID, UserId);


                FlowLayoutPanel HView = new FlowLayoutPanel();
                HView.FlowDirection = FlowDirection.LeftToRight;
                HView.WrapContents = false;

                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
                flowLayoutPanel.WrapContents = false;
                flowLayoutPanel.AutoSize = true;

                Panel newPanel = new Panel();
                newPanel.BorderStyle = BorderStyle.FixedSingle;
                newPanel.Width = 200;
                newPanel.Height = 100;

                Label label = new Label();
                label.Text = "Classroom ID: " + classroom.ClassroomID + "\n" +
                             "Classroom Code: " + classroom.ClassroomCode + "\n" +
                             "Class Name: " + classroom.ClassName + "\n" +
                             "Teacher ID: " + classroom.TeacherID + "\n\n";
                label.AutoSize = true;
                flowLayoutPanel.Controls.Add(label);

                TabPage tabPage = new TabPage(classroom.ClassroomCode);

                Panel panel2 = new Panel();
                panel2.AutoScroll = true;
                panel2.Width = 800;
                panel2.Height = 300;

                Panel panel3 = new Panel();
                panel3.AutoScroll = true;
                /*Panel panel4 = new Panel();
                panel4.AutoScroll = true;
                Panel panel5 = new Panel();
                panel5.AutoScroll = true;*/
                TabControl NewTabControl = new TabControl();
                NewTabControl.Width = 600;
                NewTabControl.Height = 400;
                TabPage t1 = new TabPage("Assignments");
                TabPage t2 = new TabPage("Announcement");
                TabPage t3 = new TabPage("Material");
                NewTabControl.Controls.Add(t1);
                NewTabControl.Controls.Add(t2);
                NewTabControl.Controls.Add(t3);

                Panel P1 = new Panel();
                P1.AutoScroll = true;
                Panel P2 = new Panel();
                P2.AutoScroll = true;
                Panel P3 = new Panel();
                P3.AutoScroll = true;

                P1.Width = 400;
                P1.Height = 600;
                P2.Width = 400;
                P2.Height = 600;
                P3.Width = 400;
                P3.Height = 600;

                t1.Controls.Add(P1);
                t2.Controls.Add(P2);
                t3.Controls.Add(P3);


                FlowLayoutPanel f1 = new FlowLayoutPanel();
                f1.FlowDirection = FlowDirection.TopDown;
                f1.Width = 600;
                f1.WrapContents = false;
                f1.AutoSize = true;
                FlowLayoutPanel f2 = new FlowLayoutPanel();
                f2.FlowDirection = FlowDirection.TopDown;
                f2.Width = 600;
                f2.WrapContents = false;
                f2.AutoSize = true;
                FlowLayoutPanel f3 = new FlowLayoutPanel();
                f3.FlowDirection = FlowDirection.TopDown;
                f3.Width = 600;
                f3.WrapContents = false;
                f3.AutoSize = true;

                foreach (Assignment assignment in assignmentsForClassroom)
                {
                    Label assignmentLabel = new Label();
                    assignmentLabel.Text = "Assignment ID: " + assignment.AssignmentID + "\n" +
                                         "Classroom ID: " + assignment.ClassroomID + "\n" +
                                         "Title: " + assignment.Title + "\n" +
                                         "Description: " + assignment.Description + "\n" +
                                         "Deadline: " + assignment.Deadline + "\n\n";
                    List<Comment> commentForAssignment = assignment.GetCommentsForAssignment(assignment.AssignmentID);
                    assignment.Comments = commentForAssignment;
                    assignmentLabel.AutoSize = true;
                    assignmentLabel.BorderStyle = BorderStyle.FixedSingle;
                   
                        assignmentLabel.Click += (sender, e) =>
                        {
                            
                            if (user1.UserType == "Teacher")
                            {
                                Form7 f7 = new(assignment, classroom, user1);
                                f7.Show();
                                this.Hide();
                            }
                            else
                            {
                                Form10 f10 = new(assignment, classroom, user1);
                                f10.Show();
                                this.Hide();
                            }
                        };
                   
                    // Set the cursor to indicate that the label is clickable
                    assignmentLabel.Cursor = Cursors.Hand;

                    f1.Controls.Add(assignmentLabel);

                    foreach (Comment comment in commentForAssignment)
                    {
                        Label commentLabel = new Label();
                        commentLabel.Text = "      Comment ID: " + comment.CommentID + "\n" +
                            "      Comment: " + comment.Content + "\n" +
                            "      by " + comment.UserID + "\n\n";
                        //assignmentLabel.Text +=  commentLabel.Text;
                        commentLabel.AutoSize = true;
                        commentLabel.Click += (sender, e) =>
                        {
                            // Define the action to be performed when the label is clicked
                            // For example, you can open a new form or display a message box
                            MessageBox.Show("Label clicked!");


                        };
                        commentLabel.Cursor = Cursors.Hand;
                        //f1.Controls.Add(commentLabel);
                    }

                }

                foreach (Announcement announcement in announcementsForClassroom)
                {
                    Label announcementLabel = new Label();
                    announcementLabel.Text = "Announcement ID: " + announcement.AnnouncementID + "\n" +
                                         "Classroom ID: " + announcement.ClassroomID + "\n" +
                                         "Title: " + announcement.Title + "\n" +
                                         "Description: " + announcement.Content + "\n\n";

                    List<Comment> commentForAnnouncement = announcement.GetCommentsForAnnouncement(announcement.AnnouncementID);
                    announcement.Comments = commentForAnnouncement;
                    announcementLabel.AutoSize = true;
                    announcementLabel.BorderStyle = BorderStyle.FixedSingle;

                    announcementLabel.Click += (sender, e) =>
                    {
                        Form8 f8 = new(announcement, classroom, user1);
                        f8.Show();
                        this.Hide();
                        //MessageBox.Show("Announcement label clicked!");
                    };

                    // Set the cursor to indicate that the label is clickable
                    announcementLabel.Cursor = Cursors.Hand;
                    f2.Controls.Add(announcementLabel);

                    foreach (Comment comment in commentForAnnouncement)
                    {
                        Label commentLabel = new Label();
                        commentLabel.Text = "      Comment ID: " + comment.CommentID + "\n" +
                            "      Comment: " + comment.Content + "\n" +
                            "      by " + comment.UserID + "\n\n";
                        commentLabel.AutoSize = true;
                        commentLabel.Click += (sender, e) =>
                        {
                            // Define the action to be performed when the label is clicked
                            // For example, you can open a new form or display a message box
                            MessageBox.Show("Label clicked!");


                        };
                        commentLabel.Cursor = Cursors.Hand;
                        //f2.Controls.Add(commentLabel);
                    }
                }

                foreach (Material material in materialsForClassroom)
                {
                    Label materialLabel = new Label();
                    materialLabel.Text = "Material ID: " + material.MaterialID + "\n" +
                                         "Classroom ID: " + material.ClassroomID + "\n" +
                                         "Title: " + material.Title + "\n" +
                                         "Description: " + material.Content + "\n\n";
                    List<Comment> commentForMaterial = material.GetCommentsForMaterial(material.MaterialID);
                    material.Comments = commentForMaterial;
                    materialLabel.AutoSize = true;
                    materialLabel.BorderStyle = BorderStyle.FixedSingle;

                    materialLabel.Click += (sender, e) =>
                    {
                        // Define the action to be performed when the label is clicked
                        Form9 f9 = new(material, classroom, user1);
                        f9.Show();
                        this.Hide();
                    };

                    // Set the cursor to indicate that the label is clickable
                    materialLabel.Cursor = Cursors.Hand;

                    f3.Controls.Add(materialLabel);

                    foreach (Comment comment in commentForMaterial)
                    {
                        Label commentLabel = new Label();
                        commentLabel.Text = "      Comment ID: " + comment.CommentID + "\n" +
                            "      Comment: " + comment.Content + "\n" +
                            "      by " + comment.UserID + "\n\n";
                        commentLabel.AutoSize = true;

                        commentLabel.Click += (sender, e) =>
                        {
                            // Define the action to be performed when the label is clicked
                            // For example, you can open a new form or display a message box
                            MessageBox.Show("Label clicked!");


                        };
                        commentLabel.Cursor = Cursors.Hand;

                        //f3.Controls.Add(commentLabel);


                    }
                }
                P1.Controls.Add(f1);
                P2.Controls.Add(f2);
                P3.Controls.Add(f3);

                t1.Controls.Add(P1);
                t2.Controls.Add(P2);
                t3.Controls.Add(P3);

                //HView.Controls.Add(panel2);
                panel3.Controls.Add(HView);
                /* HView.Controls.Add(panel4);
                 HView.Controls.Add(panel5);*/

                //panel2.Controls.Add(HView);
                panel2.Controls.Add(flowLayoutPanel);

                //tabPage.Controls.Add(panel2);
                //tabPage.Controls.Add(panel3);
                tabPage.Controls.Add(NewTabControl);



                TeacherTabs.TabPages.Add(tabPage);
                classCount++;
            }

            dr.Close();
            cn.Close();
        }



        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void load_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.WrapContents = false;
            flowLayoutPanel.AutoSize = true;
            panel1.Controls.Add(flowLayoutPanel);

            int UserId;
            try
            {
                bool found = false;
                cn.Open();
                cs = new SqlCommand("Select *\r\nFrom Classrooms c\r\nJoin Assignments a on a.ClassroomID = c.ClassroomID\r\nJoin Users u on u.UserID = c.TeacherID\r\nWhere c.TeacherID=@ID;", cn);
                cs.Parameters.AddWithValue("@ID", teacherID.Text);
                dr = cs.ExecuteReader();
                while (dr.Read())
                {
                    Label label = new Label();
                    label.Text = "Classroom ID: " + dr["ClassroomID"].ToString() + "\n" +
                                 "Classroom Code: " + dr["ClassroomCode"].ToString() + "\n" +
                                 "Class Name: " + dr["ClassName"].ToString() + "\n" +
                                 "Assignment Title: " + dr["Title"].ToString() + "\n" +
                                 "Teacher Name: " + dr["Name"].ToString() + "\n\n";
                    label.AutoSize = true;
                    // Add the Label to the FlowLayoutPanel
                    panel1.AutoScroll = true;
                    flowLayoutPanel.Controls.Add(label);


                    FlowLayoutPanel flowLayoutPanel1 = new FlowLayoutPanel();
                    flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                    flowLayoutPanel1.WrapContents = false;
                    flowLayoutPanel1.AutoSize = true;

                    TabPage tabPage = new TabPage(dr["ClassroomCode"].ToString());

                    // Add controls to the new TabPage
                    Label label1 = new Label();
                    label1.Text = "Classroom ID: " + dr["ClassroomID"].ToString() + "\n" +
                                   "Classroom Code: " + dr["ClassroomCode"].ToString() + "\n" +
                                   "Class Name: " + dr["ClassName"].ToString() + "\n" +
                                   "Assignment Title: " + dr["Title"].ToString() + "\n" +
                                   "Teacher Name: " + dr["Name"].ToString() + "\n\n";
                    label1.Location = new Point(10, 10);
                    label.AutoSize = true;
                    flowLayoutPanel1.Controls.Add(label1);

                    // Add the new TabPage to the TabControl
                    TeacherTabs.TabPages.Add(tabPage);

                }

                dr.Close();
                cn.Close();
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool dataExists = false;
            string classroomCode = textBox1.Text;

            try
            {
                bool found = false;
                cn.Open();

                string query = "SELECT COUNT(*) FROM Classrooms WHERE ClassroomCode = @ClassroomCode";

                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@ClassroomCode", classroomCode);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        // Data already exists in the table
                        dataExists = true;
                    }
                }

                if (dataExists)
                {
                    // Data already exists, display an appropriate message or take necessary action
                    MessageBox.Show("Class with this code already exists in the table.");
                }
                else
                {
                    cs = new SqlCommand("INSERT INTO Classrooms (ClassroomCode, ClassName, TeacherID) VALUES (@cc, @cn, @tID)", cn);
                    cs.Parameters.AddWithValue("@cc", textBox1.Text);
                    cs.Parameters.AddWithValue("@cn", textBox2.Text);
                    cs.Parameters.AddWithValue("@tID", UserId.ToString());
                    cs.ExecuteNonQuery();

                    textBox1.Clear();
                    textBox2.Clear();

                    Form5 F5 = new(user1);
                    F5.Show();
                    this.Hide();
                }

            }

            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            cn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBLAB10 F = new();
            F.Show();
            this.Hide();


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            try
            {
                cn.Open();
                cs = new SqlCommand("DELETE FROM Classrooms WHERE ClassroomCode = @ID", cn);
                cs.Parameters.AddWithValue("@ID", deleteBox.Text);

                dr = cs.ExecuteReader();
                dr.Read();

                //dr.Close();
                deleteBox.Clear();

                Form5 F5 = new(user1);
                F5.Show();
                this.Hide();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = 3;

            //TeacherTabs.TabPages.
            for (; index < classCount + 3; index++)
            {
                //TabPage tabPage = TeacherTabs.TabPages[index];
                TextBox textBox = new TextBox();
                Form6 f6 = new();
                textBox.Text = "Data for Tab Page";
                textBox.Location = new Point(100, 40);
                TeacherTabs.TabPages[index].Controls.Clear();
                TeacherTabs.TabPages[index].Controls.Add(textBox);
            }
        }

        private void teacherID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            bool check = false;
            int CID = 0;
            foreach (Class class1 in classrooms)
            {
                if (class1.ClassroomCode == textBox9.Text)
                {
                    CID = class1.ClassroomID;
                    check = true;
                    break;
                }
            }
            if (check)
            {
                try
                {
                    DateTime selectedDateTime = AssignmentDateTimePicker.Value;
                    string formattedDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                    cn.Close();
                    cn.Open();
                    cs = new SqlCommand("INSERT INTO Assignments (ClassroomID, Title, Description, Deadline) VALUES (@CID, @title, @context, @deadline)", cn);
                    cs.Parameters.AddWithValue("@CID", CID);
                    cs.Parameters.AddWithValue("@title", textBox3.Text);
                    cs.Parameters.AddWithValue("@context", textBox5.Text);
                    cs.Parameters.AddWithValue("@deadline", formattedDateTime);
                    cs.ExecuteNonQuery();

                    cn.Close();
                    Form5 F5 = new(user1);
                    F5.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Classroom Code Not Valid");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool check = false;
            int CID = 0;
            foreach (Class class1 in classrooms)
            {
                if (class1.ClassroomCode == textBox10.Text)
                {
                    CID = class1.ClassroomID;
                    check = true;
                    break;
                }
            }
            if (check)
            {
                try
                {
                    DateTime selectedDateTime = AssignmentDateTimePicker.Value;
                    string formattedDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                    cn.Close();
                    cn.Open();
                    cs = new SqlCommand("INSERT INTO Announcements (ClassroomID, Title, Content) VALUES (@CID, @title, @context)", cn);
                    cs.Parameters.AddWithValue("@CID", CID);
                    cs.Parameters.AddWithValue("@title", textBox6.Text);
                    cs.Parameters.AddWithValue("@context", textBox4.Text);
                    cs.ExecuteNonQuery();

                    cn.Close();
                    Form5 F5 = new(user1);
                    F5.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Classroom Code Not Valid");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool check = false;
            int CID = 0;
            foreach (Class class1 in classrooms)
            {
                if (class1.ClassroomCode == textBox11.Text)
                {
                    CID = class1.ClassroomID;
                    check = true;
                    break;
                }
            }
            if (check)
            {
                try
                {
                    DateTime selectedDateTime = AssignmentDateTimePicker.Value;
                    string formattedDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                    cn.Close();
                    cn.Open();
                    cs = new SqlCommand("INSERT INTO Materials (ClassroomID, Title, Content) VALUES (@CID, @title, @context)", cn);
                    cs.Parameters.AddWithValue("@CID", CID);
                    cs.Parameters.AddWithValue("@title", textBox8.Text);
                    cs.Parameters.AddWithValue("@context", textBox7.Text);
                    cs.ExecuteNonQuery();

                    cn.Close();
                    Form5 F5 = new(user1);
                    F5.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Classroom Code Not Valid");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

