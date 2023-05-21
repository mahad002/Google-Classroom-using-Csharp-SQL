namespace Lab_10___21i_1239
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TeacherTabs = new TabControl();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            label9 = new Label();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tabControl1 = new TabControl();
            AddAssignment = new TabPage();
            label8 = new Label();
            textBox9 = new TextBox();
            button3 = new Button();
            label12 = new Label();
            label11 = new Label();
            AssignmentTitle = new Label();
            AssignmentDateTimePicker = new DateTimePicker();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            AddAnnouncement = new TabPage();
            label17 = new Label();
            textBox10 = new TextBox();
            button4 = new Button();
            label13 = new Label();
            label14 = new Label();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            AddMaterial = new TabPage();
            label18 = new Label();
            textBox11 = new TextBox();
            button5 = new Button();
            label15 = new Label();
            label16 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            tabPage3 = new TabPage();
            deleteButton = new Button();
            label4 = new Label();
            deleteBox = new TextBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            TeacherTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            AddAssignment.SuspendLayout();
            AddAnnouncement.SuspendLayout();
            AddMaterial.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(159, 40);
            label1.TabIndex = 0;
            label1.Text = "Teacher";
            // 
            // TeacherTabs
            // 
            TeacherTabs.Alignment = TabAlignment.Bottom;
            TeacherTabs.Controls.Add(tabPage1);
            TeacherTabs.Controls.Add(tabPage2);
            TeacherTabs.Controls.Add(tabPage3);
            TeacherTabs.Location = new Point(0, 77);
            TeacherTabs.Name = "TeacherTabs";
            TeacherTabs.SelectedIndex = 0;
            TeacherTabs.Size = new Size(799, 372);
            TeacherTabs.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ControlLight;
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(pictureBox3);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(791, 344);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create";
            tabPage1.Click += tabPage1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 183);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 177);
            panel2.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(112, 23);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(177, 131);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(11, 82);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 3;
            label3.Text = "Class Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(11, 35);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 2;
            label2.Text = "Classroom Code: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._13;
            pictureBox1.Location = new Point(-4, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Image = Properties.Resources.welcomeClass;
            pictureBox3.Location = new Point(272, -4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(519, 348);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ControlLight;
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(791, 344);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Update";
            tabPage2.Click += tabPage2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tabControl1);
            panel1.Location = new Point(2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 349);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("MV Boli", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(25, 198);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 5;
            label9.Text = "- Materials";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("MV Boli", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(25, 171);
            label10.Name = "label10";
            label10.Size = new Size(143, 20);
            label10.TabIndex = 4;
            label10.Text = "- Announcements";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MV Boli", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(25, 145);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 3;
            label7.Text = "- Assignments";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MV Boli", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(25, 120);
            label6.Name = "label6";
            label6.Size = new Size(170, 20);
            label6.TabIndex = 2;
            label6.Text = "Classroom by Adding";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 93);
            label5.Name = "label5";
            label5.Size = new Size(175, 20);
            label5.TabIndex = 1;
            label5.Text = "You can Update your";
            label5.Click += label5_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(AddAssignment);
            tabControl1.Controls.Add(AddAnnouncement);
            tabControl1.Controls.Add(AddMaterial);
            tabControl1.Location = new Point(264, 7);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(314, 339);
            tabControl1.TabIndex = 0;
            // 
            // AddAssignment
            // 
            AddAssignment.Controls.Add(label8);
            AddAssignment.Controls.Add(textBox9);
            AddAssignment.Controls.Add(button3);
            AddAssignment.Controls.Add(label12);
            AddAssignment.Controls.Add(label11);
            AddAssignment.Controls.Add(AssignmentTitle);
            AddAssignment.Controls.Add(AssignmentDateTimePicker);
            AddAssignment.Controls.Add(textBox5);
            AddAssignment.Controls.Add(textBox3);
            AddAssignment.Location = new Point(4, 24);
            AddAssignment.Name = "AddAssignment";
            AddAssignment.Padding = new Padding(3);
            AddAssignment.Size = new Size(306, 311);
            AddAssignment.TabIndex = 0;
            AddAssignment.Text = "Assignment";
            AddAssignment.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 13);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 9;
            label8.Text = "Classroom Code";
            label8.Click += label8_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(129, 10);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "Code";
            textBox9.Size = new Size(139, 23);
            textBox9.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(193, 275);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(29, 211);
            label12.Name = "label12";
            label12.Size = new Size(53, 15);
            label12.TabIndex = 6;
            label12.Text = "Deadline";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(29, 89);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 5;
            label11.Text = "Description";
            // 
            // AssignmentTitle
            // 
            AssignmentTitle.AutoSize = true;
            AssignmentTitle.Location = new Point(29, 45);
            AssignmentTitle.Name = "AssignmentTitle";
            AssignmentTitle.Size = new Size(29, 15);
            AssignmentTitle.TabIndex = 4;
            AssignmentTitle.Text = "Title";
            // 
            // AssignmentDateTimePicker
            // 
            AssignmentDateTimePicker.Location = new Point(29, 238);
            AssignmentDateTimePicker.Name = "AssignmentDateTimePicker";
            AssignmentDateTimePicker.Size = new Size(239, 23);
            AssignmentDateTimePicker.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(129, 86);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Description";
            textBox5.Size = new Size(139, 109);
            textBox5.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 42);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Title";
            textBox3.Size = new Size(139, 23);
            textBox3.TabIndex = 0;
            // 
            // AddAnnouncement
            // 
            AddAnnouncement.Controls.Add(label17);
            AddAnnouncement.Controls.Add(textBox10);
            AddAnnouncement.Controls.Add(button4);
            AddAnnouncement.Controls.Add(label13);
            AddAnnouncement.Controls.Add(label14);
            AddAnnouncement.Controls.Add(textBox4);
            AddAnnouncement.Controls.Add(textBox6);
            AddAnnouncement.Location = new Point(4, 24);
            AddAnnouncement.Name = "AddAnnouncement";
            AddAnnouncement.Padding = new Padding(3);
            AddAnnouncement.Size = new Size(306, 311);
            AddAnnouncement.TabIndex = 1;
            AddAnnouncement.Text = "Announcement";
            AddAnnouncement.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(29, 13);
            label17.Name = "label17";
            label17.Size = new Size(94, 15);
            label17.TabIndex = 13;
            label17.Text = "Classroom Code";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(129, 10);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = "Code";
            textBox10.Size = new Size(139, 23);
            textBox10.TabIndex = 12;
            // 
            // button4
            // 
            button4.Location = new Point(193, 275);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(29, 89);
            label13.Name = "label13";
            label13.Size = new Size(67, 15);
            label13.TabIndex = 10;
            label13.Text = "Description";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(29, 45);
            label14.Name = "label14";
            label14.Size = new Size(29, 15);
            label14.TabIndex = 9;
            label14.Text = "Title";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(129, 86);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Description";
            textBox4.Size = new Size(139, 109);
            textBox4.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(129, 42);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Title";
            textBox6.Size = new Size(139, 23);
            textBox6.TabIndex = 7;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // AddMaterial
            // 
            AddMaterial.Controls.Add(label18);
            AddMaterial.Controls.Add(textBox11);
            AddMaterial.Controls.Add(button5);
            AddMaterial.Controls.Add(label15);
            AddMaterial.Controls.Add(label16);
            AddMaterial.Controls.Add(textBox7);
            AddMaterial.Controls.Add(textBox8);
            AddMaterial.Location = new Point(4, 24);
            AddMaterial.Name = "AddMaterial";
            AddMaterial.Size = new Size(306, 311);
            AddMaterial.TabIndex = 2;
            AddMaterial.Text = "Material";
            AddMaterial.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(29, 13);
            label18.Name = "label18";
            label18.Size = new Size(94, 15);
            label18.TabIndex = 13;
            label18.Text = "Classroom Code";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(129, 10);
            textBox11.Name = "textBox11";
            textBox11.PlaceholderText = "Code";
            textBox11.Size = new Size(139, 23);
            textBox11.TabIndex = 12;
            // 
            // button5
            // 
            button5.Location = new Point(193, 275);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 11;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(29, 89);
            label15.Name = "label15";
            label15.Size = new Size(67, 15);
            label15.TabIndex = 10;
            label15.Text = "Description";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(29, 45);
            label16.Name = "label16";
            label16.Size = new Size(29, 15);
            label16.TabIndex = 9;
            label16.Text = "Title";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(129, 86);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Description";
            textBox7.Size = new Size(139, 109);
            textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(129, 42);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "Title";
            textBox8.Size = new Size(139, 23);
            textBox8.TabIndex = 7;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.ControlLight;
            tabPage3.Controls.Add(deleteButton);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(deleteBox);
            tabPage3.Location = new Point(4, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(791, 344);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Delete";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = SystemColors.ActiveCaption;
            deleteButton.Location = new Point(192, 197);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 132);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 4;
            label4.Text = "Classroom Code: ";
            // 
            // deleteBox
            // 
            deleteBox.Location = new Point(167, 129);
            deleteBox.Name = "deleteBox";
            deleteBox.Size = new Size(100, 23);
            deleteBox.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._14;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(799, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.icons8_logout_50;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(758, 22);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 9;
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(TeacherTabs);
            Controls.Add(pictureBox2);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher Class";
            Load += Form5_Load;
            TeacherTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            AddAssignment.ResumeLayout(false);
            AddAssignment.PerformLayout();
            AddAnnouncement.ResumeLayout(false);
            AddAnnouncement.PerformLayout();
            AddMaterial.ResumeLayout(false);
            AddMaterial.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl TeacherTabs;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private TabPage tabPage3;
        private Button load;
        private TextBox teacherID;
        private Panel panel1;
        private Button deleteButton;
        private Label label4;
        private TextBox deleteBox;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        internal Button button2;
        private Button button3;
        private Label label5;
        private TabControl tabControl1;
        private TabPage AddAssignment;
        private TabPage AddAnnouncement;
        private TabPage AddMaterial;
        private Label label9;
        private Label label10;
        private Label label7;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox3;
        private Label label12;
        private Label label11;
        private Label AssignmentTitle;
        private DateTimePicker AssignmentDateTimePicker;
        private Button button4;
        private Label label13;
        private Label label14;
        private TextBox textBox4;
        private TextBox textBox6;
        private Button button5;
        private Label label15;
        private Label label16;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label8;
        private TextBox textBox9;
        private Label label17;
        private TextBox textBox10;
        private Label label18;
        private TextBox textBox11;
    }
}