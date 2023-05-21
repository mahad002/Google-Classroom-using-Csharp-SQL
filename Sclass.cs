using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Sclass : Form
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

        public Sclass(User UserT)
        {
            user1 = UserT;
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.UserId = UserT.UserID;
            classCount = 0;
            cn.Open();
            cs = new SqlCommand("Select *\r\nFrom Enrollments e\r\nJoin Classrooms c on c.ClassroomID = e.ClassroomID\r\nwhere e.StudentID = @ID;", cn);
            cs.Parameters.AddWithValue("@ID", UserT.UserID.ToString());
            dr = cs.ExecuteReader();
            
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
                        this.Hide();
                        Form10 f10 = new(assignment, classroom, user1);
                        f10.Show();
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



                tabControl1.TabPages.Add(tabPage);
                classCount++;
            }

            dr.Close();
            cn.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Classes_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBLAB10 F = new();
            F.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int CID = 0;
            try
            {
                cn.Open();
                cs = new SqlCommand("Select ClassroomID From Classrooms Where ClassroomCode = @Code;", cn);
                cs.Parameters.AddWithValue("@Code", textBox1.Text);
                dr = cs.ExecuteReader();

                while (dr.Read())
                {
                    CID = dr.GetInt32(dr.GetOrdinal("ClassroomID"));
                }

                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (CID == 0)
            {
                MessageBox.Show("Class not found!");
            }
            else { 
                try
                {
                    cn.Open();
                    cs = new SqlCommand("INSERT INTO Enrollments (StudentID, ClassroomID) VALUES (@SID, @CID)", cn);
                    cs.Parameters.AddWithValue("@SID", user1.UserID);
                    cs.Parameters.AddWithValue("@CID", CID);
                    cs.ExecuteNonQuery();


                    Sclass F5 = new(user1);
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
        }
    }
}
