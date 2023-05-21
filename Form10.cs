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
    public partial class Form10 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cs = new SqlCommand();
        Class1 dbcon = new Class1();
        SqlDataReader dr;
        Assignment assignment;
        Class class1;
        FlowLayoutPanel f = new FlowLayoutPanel();
        FlowLayoutPanel fs = new FlowLayoutPanel();
        int SubCount = 0;
        int ComCount = 0;
        User user1 = new User();
        public Form10(Assignment a, Class c, User u)
        {
            user1 = u;
            assignment = a;
            class1 = c;
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            title.Text = assignment.Title;
            classLabel.Text = "Classroom Code: " + class1.ClassroomCode + "\n" +
                             "Class Name: " + class1.ClassName + "\n";

            //assignment Pannel being set
            Label assignmentLabel = new Label();
            assignmentLabel.Text = "Assignment ID: " + assignment.AssignmentID + "\n" +
                                 "Classroom ID: " + assignment.ClassroomID + "\n" +
                                 "Title: " + assignment.Title + "\n" +
                                 "Description: " + assignment.Description + "\n" +
                                 "Deadline: " + assignment.Deadline + "\n\n";
            List<Comment> commentForAssignment = assignment.GetCommentsForAssignment(assignment.AssignmentID);
            assignment.Comments = commentForAssignment;
            assignment.Submissions = assignment.GetSubmissionsForStudent(user1.UserID);
            assignmentLabel.AutoSize = true;
            assignmentLabel.BorderStyle = BorderStyle.FixedSingle;
            assignmentPanel.Controls.Add(assignmentLabel);


            //comment Pannel being set

            f.FlowDirection = FlowDirection.TopDown;
            f.Width = 600;
            f.WrapContents = false;
            f.AutoSize = true;
            commentPanel.AutoScroll = true;

            foreach (Comment comment in assignment.Comments)
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
                if (user1.UserID == comment.UserID)
                {

                    Button deleteComment = new Button();
                    deleteComment.Text = "Delete";


                    f3.Controls.Add(deleteComment);

                    deleteComment.Click += (sender, e) =>
                    {
                        //string query = "DELETE FROM Comments\r\nWHERE CommentID = @CommentID;\r\n";
                        cn.Open();
                        cs = new SqlCommand("DELETE FROM Comments WHERE CommentID = @CommentID;", cn);
                        cs.Parameters.AddWithValue("@CommentID", comment.CommentID);
                        assignment.Comments.Remove(comment);
                        cs.ExecuteNonQuery();
                        MessageBox.Show("Delete comment!");
                        f3.Controls.Remove(commentLabel); f3.Controls.Remove(deleteComment);
                        cn.Close();
                        ComCount--;
                    };
                }


                commentLabel.Cursor = Cursors.Hand;




                f.Controls.Add(f3);

            }

            commentPanel.Controls.Add(f);

            fs.FlowDirection = FlowDirection.TopDown;
            fs.Width = 600;
            fs.WrapContents = false;
            fs.AutoSize = true;
            foreach (Submission submission in assignment.Submissions)
            {
                FlowLayoutPanel f3 = new FlowLayoutPanel();
                f3.FlowDirection = FlowDirection.LeftToRight;
                f3.Width = 600;
                f3.WrapContents = false;
                f3.AutoSize = true;
                ComCount++;
                Label submissionLabel = new Label();
                submissionLabel.Text = "Submission ID: " + submission.SubmissionID + "\n" +
                    "Submission: " + submission.Content + "\n" +
                    "Time: " + submission.Timestamp.ToString() + "\n" +
                    "by " + submission.StudentID + "\n\n";
                submissionLabel.AutoSize = true;

                Label grade = new Label();
                grade.BorderStyle = BorderStyle.FixedSingle;
                grade.Text = "UnMarked";
                if (submission.Grade != -1)
                {
                    grade.Text = "Grade: \n" + submission.Grade.ToString();
                }


                f3.Controls.Add(submissionLabel);
                f3.Controls.Add(grade);
                fs.Controls.Add(f3);

            }
            submissionPanel.AutoScroll = true;
            submissionPanel.Controls.Add(fs);

        }




        private void submissionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void assignmentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void submissionPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (!string.IsNullOrEmpty(text))
            {
                cn.Close();
                FlowLayoutPanel f4 = new FlowLayoutPanel();
                f4.FlowDirection = FlowDirection.LeftToRight;
                f4.Width = 600;
                f4.WrapContents = false;
                f4.AutoSize = true;
                Label submissionLabel1 = new Label();
                submissionLabel1.Text = "0000000000000000000000";
                Button deletesubmission1 = new Button();
                deletesubmission1.Text = "Delete";
                Submission submission = new Submission();


                cn.Open();
                cs = new SqlCommand("INSERT INTO Submissions (AssignmentID, StudentID, Content, Timestamp, Grade) VALUES (@AID, @SID, @Content, @Timestamp, -1)", cn);
                cs.Parameters.AddWithValue("@AID", assignment.AssignmentID);
                cs.Parameters.AddWithValue("@SID", user1.UserID);
                cs.Parameters.AddWithValue("@Content", text);
                cs.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                textBox1.Clear();
                MessageBox.Show("Add submission!");
                cs.ExecuteNonQuery();
                cn.Close();
                submissionPanel.Controls.Add(f);
                assignment.Submissions = assignment.GetSubmissionsForStudent(user1.UserID);
                int i = 0;
                foreach (Submission submission1 in assignment.Submissions)
                {
                    //if (i == ComCount)
                    //{
                    submissionLabel1.Text = "Submission ID: " + submission.SubmissionID + "\n" +
                    "Submission: " + submission.Content + "\n" +
                    "Time: " + submission.Timestamp.ToString() + "\n" +
                    "by " + submission.StudentID + "\n\n";
                    submissionLabel1.AutoSize = true;
                    submission.SubmissionID = submission1.SubmissionID;
                    submission.AssignmentID = submission1.AssignmentID;
                    submission.Content = submission1.Content;
                    submission.Timestamp = submission1.Timestamp;
                    submission.Grade = submission1.Grade;
                    //}

                    i++;
                }

                f4.Controls.Add(submissionLabel1); //f4.Controls.Add(deletesubmission1);
                f.Controls.Add(f4);

                /*deletesubmission1.Click += (sender, e) =>
                {
                    cn.Open();
                    cs = new SqlCommand("DELETE FROM submissions WHERE submissionID = @submissionID;", cn);
                    cs.Parameters.AddWithValue("@submissionID", submission.SubmissionID);

                    assignment.Submissions.Remove(submission);
                    cs.ExecuteNonQuery();
                    MessageBox.Show("Delete submission!");
                    f4.Controls.Remove(submissionLabel1); f4.Controls.Remove(deletesubmission1);
                    cn.Close();



                };*/

            }
            else
            {
                MessageBox.Show("It is empty!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (!string.IsNullOrEmpty(text))
            {
                //cn.Close();
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
                cs = new SqlCommand("INSERT INTO Comments (UserID, Content, ContextID, ContextType) VALUES (@ID, @Content, @AID, 'Assignment')", cn);
                cs.Parameters.AddWithValue("@ID", user1.UserID);
                cs.Parameters.AddWithValue("@Content", text);
                cs.Parameters.AddWithValue("@AID", assignment.AssignmentID);
                textBox1.Clear();
                MessageBox.Show("Add comment!");
                cs.ExecuteNonQuery();
                cn.Close();
                commentPanel.Controls.Add(f);
                assignment.Comments = assignment.GetCommentsForAssignment(assignment.AssignmentID);
                int i = 0;
                foreach (Comment comment1 in assignment.Comments)
                {
                    //if (i == ComCount)
                    //{
                        commentLabel1.Text = "      Comment ID: " + comment1.CommentID + "\n" +
                                            "      Comment: " + comment1.Content + "\n" +
                                            "      by " + comment1.UserID + "\n\n";
                        commentLabel1.AutoSize = true;
                        comment.CommentID = comment1.CommentID;
                        comment.UserID = comment1.UserID;
                        comment.Content = comment1.Content;
                        comment.ContextType = comment1.ContextType;
                        comment.ContextID = comment1.ContextID;
                    //}

                    i++;
                }

                f4.Controls.Add(commentLabel1); f4.Controls.Add(deleteComment1);
                f.Controls.Add(f4);

                deleteComment1.Click += (sender, e) =>
                {
                    cn.Open();
                    cs = new SqlCommand("DELETE FROM Comments WHERE CommentID = @CommentID;", cn);
                    cs.Parameters.AddWithValue("@CommentID", comment.CommentID);

                    assignment.Comments.Remove(comment);
                    cs.ExecuteNonQuery();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Sclass F5 = new(user1);
            F5.Show();
            this.Hide();
        }
    }
}
