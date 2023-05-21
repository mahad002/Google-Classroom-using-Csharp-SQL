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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace Lab_10___21i_1239
{
    public partial class Form8 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cs = new SqlCommand();
        Class1 dbcon = new Class1();
        SqlDataReader dr;
        Announcement announcement;
        Class class1;
        FlowLayoutPanel f = new FlowLayoutPanel();
        List<int> CID = new List<int>();
        int ComCount = 0;
        User user1 = new User();

        public Form8(Announcement a, Class c, User u)
        {
            user1 = u;
            announcement = a;
            class1 = c;
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            title.Text = announcement.Title;
            classLabel.Text = "Classroom Code: " + class1.ClassroomCode + "\n" +
                             "Class Name: " + class1.ClassName + "\n";

            //announcement Pannel being set
            Label announcementLabel = new Label();
            announcementLabel.Text = "announcement ID: " + announcement.AnnouncementID + "\n" +
                                 "Classroom ID: " + announcement.ClassroomID + "\n" +
                                 "Title: " + announcement.Title + "\n" +
                                 "Description: " + announcement.Content + "\n\n";


            List<Comment> commentForannouncement = announcement.GetCommentsForAnnouncement(announcement.AnnouncementID);
            announcement.Comments = commentForannouncement;
            announcementLabel.AutoSize = true;
            announcementLabel.BorderStyle = BorderStyle.FixedSingle;
            announcementPanel.Controls.Add(announcementLabel);


            //comment Pannel being set
            f.FlowDirection = FlowDirection.TopDown;
            f.Width = 600;
            f.WrapContents = false;
            f.AutoSize = true;
            commentPanel.AutoScroll = true;

            foreach (Comment comment in announcement.Comments)
            {
                FlowLayoutPanel f3 = new FlowLayoutPanel();
                f3.FlowDirection = FlowDirection.LeftToRight;
                f3.Width = 600;
                f3.WrapContents = false;
                f3.AutoSize = true;

                ComCount++;

                Label commentLabel = new Label();
                commentLabel.Text = "      Comment ID: " + comment.CommentID + "\n" +
                    "      Comment: " + comment.Content + "\n" +
                    "      by " + comment.UserID + "\n\n";
                commentLabel.AutoSize = true;

                f3.Controls.Add(commentLabel);
                if (user1.UserType == "Teacher" || user1.UserID == comment.UserID)
                {
                    Button deleteComment = new Button();
                    deleteComment.Text = "Delete";

                    deleteComment.Click += (sender, e) =>
                    {
                        cn.Open();
                        cs = new SqlCommand("DELETE FROM Comments WHERE CommentID = @CommentID;", cn);
                        cs.Parameters.AddWithValue("@CommentID", comment.CommentID);

                        announcement.Comments.Remove(comment);
                        cs.ExecuteNonQuery();
                        /*  dr = cs.ExecuteReader();
                        while (dr.Read()) { }*/
                        MessageBox.Show("Delete comment!");
                        f3.Controls.Remove(commentLabel); f3.Controls.Remove(deleteComment);
                        cn.Close();
                        ComCount--;
                    };

                    f3.Controls.Add(deleteComment);
                }

                commentLabel.Cursor = Cursors.Hand;


                f.Controls.Add(f3);

            }

            commentPanel.Controls.Add(f);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user1.UserType == "Teacher")
            {
                Form5 F5 = new(user1);
                F5.Show();
                this.Hide();
            }
            else
            {
                Sclass F5 = new(user1);
                F5.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (!string.IsNullOrEmpty(text))
            {
                FlowLayoutPanel f4 = new FlowLayoutPanel();
                f4.FlowDirection = FlowDirection.LeftToRight;
                f4.Width = 600;
                f4.WrapContents = false;
                f4.AutoSize = true;
                Label commentLabel1 = new Label();
                commentLabel1.Text = "000000000000000000000000";
                Button deleteComment1 = new Button();
                deleteComment1.Text = "Delete";
                Comment comment = new Comment();


                cn.Open();
                cs = new SqlCommand("INSERT INTO Comments (UserID, Content, ContextID, ContextType) VALUES (@ID, @Content, @AID, 'Announcement')", cn);
                cs.Parameters.AddWithValue("@ID", class1.TeacherID);
                cs.Parameters.AddWithValue("@Content", text);
                cs.Parameters.AddWithValue("@AID", announcement.AnnouncementID);
                textBox1.Clear();
                MessageBox.Show("Add comment!");
                cs.ExecuteNonQuery();
                cn.Close();
                commentPanel.Controls.Add(f);
                announcement.Comments = announcement.GetCommentsForAnnouncement(announcement.AnnouncementID);
                int i = 0;
                foreach (Comment comment1 in announcement.Comments)
                {
                    if (i == ComCount)
                    {
                        commentLabel1.Text = "      Comment ID: " + comment1.CommentID + "\n" +
                                            "      Comment: " + comment1.Content + "\n" +
                                            "      by " + comment1.UserID + "\n\n";
                        commentLabel1.AutoSize = true;
                        comment.CommentID = comment1.CommentID;
                        comment.UserID = comment1.UserID;
                        comment.Content = comment1.Content;
                        comment.ContextType = comment1.ContextType;
                        comment.ContextID = comment1.ContextID;
                    }

                    i++;
                }

                f4.Controls.Add(commentLabel1); f4.Controls.Add(deleteComment1);
                f.Controls.Add(f4);

                deleteComment1.Click += (sender, e) =>
                {
                    cn.Open();
                    cs = new SqlCommand("DELETE FROM Comments WHERE CommentID = @CommentID;", cn);
                    cs.Parameters.AddWithValue("@CommentID", comment.CommentID);
                    cs.ExecuteNonQuery();
                    announcement.Comments.Remove(comment);
                   
                    MessageBox.Show("Delete comment!");
                    f4.Controls.Remove(commentLabel1); f4.Controls.Remove(deleteComment1);
                    cn.Close();



                };

            }
            else
            {
                MessageBox.Show("It is empty!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cs = new SqlCommand("DeleteANnouncement", cn);
                cs.CommandType = System.Data.CommandType.StoredProcedure;
                cs.Parameters.AddWithValue("@AnnouncementID", announcement.AnnouncementID);
                cs.ExecuteNonQuery();



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
    }
}
