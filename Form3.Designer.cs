namespace Lab_10___21i_1239
{
    partial class Form3
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
            panel1 = new Panel();
            teacherButton = new RadioButton();
            studentButton = new RadioButton();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(teacherButton);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(studentButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(262, 215);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 232);
            panel1.TabIndex = 1;
            // 
            // teacherButton
            // 
            teacherButton.AutoSize = true;
            teacherButton.Location = new Point(142, 188);
            teacherButton.Name = "teacherButton";
            teacherButton.Size = new Size(65, 19);
            teacherButton.TabIndex = 9;
            teacherButton.TabStop = true;
            teacherButton.Text = "Teacher";
            teacherButton.UseVisualStyleBackColor = true;
            // 
            // studentButton
            // 
            studentButton.AutoSize = true;
            studentButton.Location = new Point(142, 159);
            studentButton.Name = "studentButton";
            studentButton.Size = new Size(66, 19);
            studentButton.TabIndex = 8;
            studentButton.TabStop = true;
            studentButton.Text = "Student";
            studentButton.UseVisualStyleBackColor = true;
            studentButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 161);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 7;
            label4.Text = "User Type: ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(142, 120);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 123);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Password: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 83);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Email: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 45);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 4;
            label1.Text = "Name: ";
            label1.Click += label1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(142, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "name";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 489);
            ControlBox = false;
            Controls.Add(panel1);
            Enabled = false;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private RadioButton teacherButton;
        private RadioButton studentButton;
    }
}