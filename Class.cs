using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10___21i_1239
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
    }

    public class Class
    {
        public int ClassroomID { get; set; }
        public string ClassroomCode { get; set; }
        public string ClassName { get; set; }
        public int TeacherID { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<Announcement> Announcements { get; set; }
        public List<Material> Materials { get; set; }

        SqlConnection cn = new SqlConnection();
        SqlCommand cs = new SqlCommand();
        Class1 dbcon = new Class1();
        SqlDataReader dr;


        public List<Assignment> GetAssignmentsForClassroom(int classroomId, int Uid)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            List<Assignment> assignments = new List<Assignment>();

            cn.Open();
            cs = new SqlCommand("SELECT * FROM Assignments WHERE ClassroomID = @ClassroomId;", cn);
            cs.Parameters.AddWithValue("@ClassroomId", classroomId);
            dr = cs.ExecuteReader();

            while (dr.Read())
            {
                int AID = dr.GetInt32(dr.GetOrdinal("AssignmentID"));
                assignments.Add(new Assignment(AID,Uid)
                {
                    AssignmentID = AID,
                    ClassroomID = dr.GetInt32(dr.GetOrdinal("ClassroomID")),
                    Title = dr["Title"].ToString(),
                    Description = dr["Description"].ToString(),
                    Deadline = dr.GetDateTime(dr.GetOrdinal("Deadline"))
                }); 
            }
            return assignments;
        }

        public List<Announcement> GetAnnouncementsForClassroom(int classroomId, int Uid)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            List<Announcement> announcements = new List<Announcement>();

            using (SqlConnection connection = cn)
            {
                string query = "SELECT * FROM Announcements WHERE ClassroomID = @ClassroomId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClassroomId", classroomId);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int AID = reader.GetInt32(reader.GetOrdinal("AnnouncementID"));
                            announcements.Add(new Announcement(AID,Uid)
                            {
                                AnnouncementID = AID,
                                ClassroomID = reader.GetInt32(reader.GetOrdinal("ClassroomID")),
                                Title = reader.GetString(reader.GetOrdinal("Title")),
                                Content = reader.GetString(reader.GetOrdinal("Content"))
                            });
                        }
                    }
                }
            }

            return announcements;
        }

        public List<Material> GetMaterialsForClassroom(int classroomId, int Uid)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            List<Material> materials = new List<Material>();

            using (SqlConnection connection = cn)
            {
                string query = "SELECT * FROM Materials WHERE ClassroomID = @ClassroomId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClassroomId", classroomId);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int MID = reader.GetInt32(reader.GetOrdinal("MaterialID"));
                            materials.Add(new Material(MID,Uid)
                            {
                                MaterialID = MID,
                                ClassroomID = reader.GetInt32(reader.GetOrdinal("ClassroomID")),
                                Title = reader.GetString(reader.GetOrdinal("Title")),
                                Content = reader.GetString(reader.GetOrdinal("Content"))
                            });
                        }
                    }
                }
            }
            cn.Close();
            return materials;
        }
    }

    public class Assignment
    {
        public int AssignmentID { get; set; }
        public int ClassroomID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public List<Submission> Submissions { get; set; }
        public List<Comment> Comments { get; set; }

        SqlConnection cn = new SqlConnection();
        SqlCommand cs = new SqlCommand();
        Class1 dbcon = new Class1();
        SqlDataReader dr;

        

        public List<Comment> GetCommentsForAssignment(int id)
        {

            cn = new SqlConnection(dbcon.MyConnection());
            List<Comment> comment = new List<Comment>();

            using (SqlConnection connection = cn)
            {
                Console.WriteLine("Running MyFunction...");
                string query = "Select * From Users u Join Comments c on c.UserID = u.UserID Where c.ContextType = 'Assignment' AND c.ContextID = @ID";
                cs = new SqlCommand(query, connection);

                connection.Open();
                cs.Parameters.AddWithValue("@ID", id);
                    //cs.Parameters.AddWithValue("@UID", uid);
                    dr = cs.ExecuteReader();
                    

                  
                        while (dr.Read())
                        {
                            comment.Add(new Comment
                            {
                                CommentID = dr.GetInt32(dr.GetOrdinal("CommentID")),
                                UserID = dr.GetInt32(dr.GetOrdinal("UserID")),
                                ContextID = dr.GetInt32(dr.GetOrdinal("ContextID")),
                                Content = dr.GetString(dr.GetOrdinal("Content")),
                                ContextType = dr.GetString(dr.GetOrdinal("ContextType"))
                            });
                        }
                    dr.Close();
                
            }
            //cn.Close();
            return comment;
        }

        public List<Submission> GetSubmissionsForAssignment()
        {
            cn = new SqlConnection(dbcon.MyConnection());
            List<Submission> submission = new List<Submission>();

            using (SqlConnection connection = cn)
            {
                Console.WriteLine("Running MyFunction...");
                string query = "Select * From Submissions s  where s.AssignmentID = @ID;";
                cs = new SqlCommand(query, connection);

                connection.Open();
                cs.Parameters.AddWithValue("@ID", AssignmentID);
                dr = cs.ExecuteReader();
                int temp;


                while (dr.Read())
                {
                    if (dr.IsDBNull(dr.GetOrdinal("Grade")))
                    {
                        temp = -1;
                    }
                    else
                    {
                        temp = dr.GetInt32(dr.GetOrdinal("Grade"));
                    }
                    submission.Add(new Submission
                    {
                        SubmissionID = dr.GetInt32(dr.GetOrdinal("SubmissionID")),
                        AssignmentID = dr.GetInt32(dr.GetOrdinal("AssignmentID")),
                        StudentID = dr.GetInt32(dr.GetOrdinal("StudentID")),
                        Content = dr.GetString(dr.GetOrdinal("Content")),
                        Timestamp = dr.GetDateTime(dr.GetOrdinal("Timestamp")),
                        Grade = temp
                    });
                }
                dr.Close();

            }
            //cn.Close();
            return submission;
        }

        public List<Submission> GetSubmissionsForStudent(int id)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            List<Submission> submission = new List<Submission>();

            using (SqlConnection connection = cn)
            {
                Console.WriteLine("Running MyFunction...");
                string query = "Select * From Submissions s  where s.AssignmentID = @ID And s.StudentID = @SID;";
                cs = new SqlCommand(query, connection);

                connection.Open();
                cs.Parameters.AddWithValue("@ID", AssignmentID);
                cs.Parameters.AddWithValue("@SID", id);
                dr = cs.ExecuteReader();
                int temp;


                while (dr.Read())
                {
                    if (dr.IsDBNull(dr.GetOrdinal("Grade")))
                    {
                        temp = -1;
                    }
                    else
                    {
                        temp = dr.GetInt32(dr.GetOrdinal("Grade"));
                    }
                    submission.Add(new Submission
                    {
                        SubmissionID = dr.GetInt32(dr.GetOrdinal("SubmissionID")),
                        AssignmentID = dr.GetInt32(dr.GetOrdinal("AssignmentID")),
                        StudentID = dr.GetInt32(dr.GetOrdinal("StudentID")),
                        Content = dr.GetString(dr.GetOrdinal("Content")),
                        Timestamp = dr.GetDateTime(dr.GetOrdinal("Timestamp")),
                        Grade = temp
                    });
                }
                dr.Close();

            }
            //cn.Close();
            return submission;
        }

        public Assignment(int id, int uid)
        {
            GetCommentsForAssignment(id);
        }
    }

    public class Announcement
    {
        public int AnnouncementID { get; set; }
        public int ClassroomID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<Comment> Comments { get; set; }

        SqlConnection cn = new SqlConnection();
        SqlCommand cs = new SqlCommand();
        Class1 dbcon = new Class1();
        SqlDataReader dr;



        public List<Comment> GetCommentsForAnnouncement(int id)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            List<Comment> comment = new List<Comment>();

            using (SqlConnection connection = cn)
            {
                string query = "Select *\r\nFrom Users u\r\nJoin Comments c on c.UserID = u.UserID\r\nWhere c.ContextType = 'Announcement' AND c.ContextID = @ID;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comment.Add(new Comment
                            {
                                CommentID = reader.GetInt32(reader.GetOrdinal("CommentID")),
                                UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                ContextID = reader.GetInt32(reader.GetOrdinal("ContextID")),
                                Content = reader.GetString(reader.GetOrdinal("Content")),
                                ContextType = reader.GetString(reader.GetOrdinal("ContextType"))
                            });
                        }
                    }
                }
            }

            return comment;
        }

        public Announcement(int id, int uid)
        {
            GetCommentsForAnnouncement(id);
        }
    }

    public class Material
    {
        public int MaterialID { get; set; }
        public int ClassroomID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<Comment> Comments { get; set; }

        SqlConnection cn = new SqlConnection();
        SqlCommand cs = new SqlCommand();
        Class1 dbcon = new Class1();
        SqlDataReader dr;



        public List<Comment> GetCommentsForMaterial(int id)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            List<Comment> comment = new List<Comment>();

            using (SqlConnection connection = cn)
            {
                string query = "Select *\r\nFrom Users u\r\nJoin Comments c on c.UserID = u.UserID\r\nWhere c.ContextType = 'Material' AND c.ContextID = @ID;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comment.Add(new Comment
                            {
                                CommentID = reader.GetInt32(reader.GetOrdinal("CommentID")),
                                UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                ContextID = reader.GetInt32(reader.GetOrdinal("ContextID")),
                                Content = reader.GetString(reader.GetOrdinal("Content")),
                                ContextType = reader.GetString(reader.GetOrdinal("ContextType"))
                            });
                        }
                    }
                }
            }

            return comment;
        }

        public Material(int id, int uid)
        {
            GetCommentsForMaterial(id);
        }
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public int ClassroomID { get; set; }
    }

    public class Submission
    {
        public int SubmissionID { get; set; }
        public int AssignmentID { get; set; }
        public int StudentID { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public int Grade { get; set; }
    }

    public class Comment
    {
        public int CommentID { get; set; }
        public int UserID { get; set; }
        public string Content { get; set; }
        public int ContextID { get; set; }
        public string ContextType { get; set; }
    }

}
