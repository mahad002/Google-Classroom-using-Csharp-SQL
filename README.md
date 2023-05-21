# Google-Classroom-using-Csharp-and-SQL
The Google Classroom application presents a comprehensive platform for teachers and  students to engage in online learning and collaboration.

Description
1. Introduction:
The Google Classroom application is an online platform created to facilitate collaboration and
learning between educators and learners. It provides two distinct perspectives: one for 
instructors and another for pupils. This report presents an overview of the features and 
functionality of the Google Classroom application, focusing on these two viewpoints.
2. Teacher View:
2.1 Class Management:
Educators possess the capability to establish, erase, and modify classes. They can create a 
virtual environment where they can interact with their students.
2.2 Assignments:
Instructors can generate assignments with specified deadlines. They can define the title, 
description, and due date for each task. Learners can submit their completed assignments, 
and instructors can evaluate and grade them.
2.3 Announcements:
Teachers can share important information with their students by creating announcements. 
These updates encompass class-related activities, events, or modifications.
2.4 Materials:
Educators have the option to upload and distribute study materials such as documents, 
presentations, or links. These resources serve as reference materials for students to access 
and review outside of the classroom.
2.5 Submissions:
For each assignment, teachers can access a compilation of student submissions. They can 
evaluate and grade these submissions based on predetermined criteria. The grading system 
allows instructors to provide feedback and assess students' work.
21i-1239 Muhammad Mahad Sheikh Google Classroom
2.6 Comments:
Assignments, announcements, and materials all allow for comments. Teachers can view and 
remove comments made by students, fostering discussion and interaction within the class.
3. Student View:
3.1 Class Enrollment:
Students can enroll in classes by joining using a specific class code provided by their teachers. 
This functionality grants students access to class content and enables participation in 
learning activities.
3.2 Assignments:
Learners can view and complete assignments assigned by their instructors. They have the 
ability to submit their finished work for assessment and receive grades and feedback.
3.3 Announcements:
Students can access announcements posted by their teachers. These announcements relay 
vital updates, reminders, or supplementary instructions relevant to the class.
3.4 Materials:
Study materials uploaded by instructors are available for students to access. These materials 
serve as references and resources to support their learning beyond regular class hours.
3.5 Comments:
Students can actively engage in discussions by leaving comments on assignments, 
announcements, and materials. However, they can only delete their own comments, allowing 
them control over their contributions to the class discussion.
3.6 Submission Resubmission:
If permitted by the instructor, students have the option to resubmit their assignments. This 
feature empowers students to enhance their work based on the feedback received, thereby 
enriching their learning experience.
4. Conclusion:
The Google Classroom application presents a comprehensive platform for teachers and 
students to engage in online learning and collaboration. The teacher view encompasses 
features for managing classes, creating assignments, making announcements, and sharing 
materials. The student view enables class enrollment, assignment submission, access to 
announcements and materials, and active participation through comments. Overall, the 
Google Classroom application enhances the teaching and learning experience by facilitating 
effective communication, assignment management, and resource sharing within a digital 
classroom environment.



Connected SQL Studio
1. User Data:
A table called "Users" was generated with fields for UserID, Name, Email, Password, and 
UserType. This table retains information concerning application users, encompassing 
teachers and students.
2. Classroom Data:
The creation of a table named "Classrooms" facilitated the administration of virtual 
classrooms. It encompassed attributes such as ClassroomID, ClassroomCode, ClassName, 
and TeacherID. The TeacherID serves as a reference to the UserID of the teacher responsible 
for the class.
3. Assignment Data:
For the purpose of managing assignments, an "Assignments" table was established. It 
comprised columns for AssignmentID, ClassroomID, Title, Description, and Deadline. The 
ClassroomID field relates to the respective class's ClassroomID.
4. Announcement Data:
To store announcements, an "Announcements" table was introduced. It comprised fields 
including AnnouncementID, ClassroomID, Title, and Content. The ClassroomID field acts as a 
reference to the ClassroomID associated with the announcement.
5. Material Data:
To facilitate the management of study materials, a "Materials" table was implemented. It 
included attributes such as MaterialID, ClassroomID, Title, and Content. The ClassroomID 
field served as a reference to the ClassroomID linked to the materials.
6. Enrollment Data:
To handle class enrollments, an "Enrollments" table was established. It consisted of columns 
for EnrollmentID, StudentID, and ClassroomID. The StudentID field refers to the UserID of 
the student, while the ClassroomID field corresponds to the ClassroomID of the enrolled 
class.
7. Submission Data:
A "Submissions" table was created to manage assignment submissions. It encompassed 
fields such as SubmissionID, AssignmentID, StudentID, Content, Timestamp, and Grade. The 
AssignmentID field referred to the AssignmentID associated with the submission, and the 
StudentID field referenced the UserID of the submitting student.
8. Comment Data:
An additional table, "Comments," was generated to store comments made on various classrelated elements. It consisted of fields like CommentID, UserID, Content, ContextID, and 
ContextType. The UserID field pointed to the UserID of the user who posted the comment, 
while the ContextID and ContextType fields were utilized to identify the specific context 
(assignment, announcement, or material) to which the comment pertained.
By implementing these tables and their respective fields, SQL Studio facilitated efficient 
storage and management of user data, classroom information, assignments, 
announcements, study materials, enrollments, submissions, and comments. This 
comprehensive setup provided a solid foundation for the Google Classroom application's 
functionalities and operations
