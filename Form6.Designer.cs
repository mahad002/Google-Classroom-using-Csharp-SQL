namespace Lab_10___21i_1239
{
    partial class Form6
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            teacherButton = new RadioButton();
            studentButton = new RadioButton();
            label4 = new Label();
            pass = new TextBox();
            label3 = new Label();
            label2 = new Label();
            email = new TextBox();
            label1 = new Label();
            name = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.google_classroom1;
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(teacherButton);
            panel1.Controls.Add(studentButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(email);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(name);
            panel1.Location = new Point(256, 196);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 254);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(212, 215);
            button2.Name = "button2";
            button2.Size = new Size(75, 27);
            button2.TabIndex = 18;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(41, 215);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 17;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // teacherButton
            // 
            teacherButton.AutoSize = true;
            teacherButton.Location = new Point(158, 183);
            teacherButton.Name = "teacherButton";
            teacherButton.Size = new Size(65, 19);
            teacherButton.TabIndex = 16;
            teacherButton.TabStop = true;
            teacherButton.Text = "Teacher";
            teacherButton.UseVisualStyleBackColor = true;
            // 
            // studentButton
            // 
            studentButton.AutoSize = true;
            studentButton.Location = new Point(158, 154);
            studentButton.Name = "studentButton";
            studentButton.Size = new Size(66, 19);
            studentButton.TabIndex = 15;
            studentButton.TabStop = true;
            studentButton.Text = "Student";
            studentButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 156);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 14;
            label4.Text = "User Type: ";
            label4.Click += label4_Click;
            // 
            // pass
            // 
            pass.Location = new Point(158, 113);
            pass.Name = "pass";
            pass.PasswordChar = '*';
            pass.PlaceholderText = "password";
            pass.Size = new Size(104, 23);
            pass.TabIndex = 11;
            pass.UseSystemPasswordChar = true;
            pass.TextChanged += pass_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 116);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 13;
            label3.Text = "Password: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 77);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 12;
            label2.Text = "Email: ";
            // 
            // email
            // 
            email.Location = new Point(158, 74);
            email.Name = "email";
            email.PlaceholderText = "email";
            email.Size = new Size(104, 23);
            email.TabIndex = 10;
            email.TextChanged += email_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 35);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Name: ";
            label1.Click += label1_Click;
            // 
            // name
            // 
            name.Location = new Point(158, 32);
            name.Name = "name";
            name.PlaceholderText = "name";
            name.Size = new Size(104, 23);
            name.TabIndex = 0;
            name.TextChanged += textBox1_TextChanged;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private TextBox name;
        private RadioButton teacherButton;
        private RadioButton studentButton;
        private Label label4;
        private TextBox pass;
        private Label label3;
        private Label label2;
        private TextBox email;
        private Button button1;
        private Button button2;
    }
}