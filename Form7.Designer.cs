namespace Lab_10___21i_1239
{
    partial class Form7
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
            title = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            submissionPanel = new Panel();
            assignmentPanel = new Panel();
            button2 = new Button();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            commentPanel = new FlowLayoutPanel();
            button3 = new Button();
            textBox1 = new TextBox();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            button1 = new Button();
            classLabel = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            assignmentPanel.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 40);
            label1.TabIndex = 0;
            label1.Text = "Assignment";
            label1.Click += label1_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BorderStyle = BorderStyle.Fixed3D;
            title.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(16, 53);
            title.Name = "title";
            title.Size = new Size(55, 27);
            title.TabIndex = 1;
            title.Text = "Title";
            title.Click += label2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(2, 90);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 360);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(submissionPanel);
            tabPage1.Controls.Add(assignmentPanel);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 332);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Assignment";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // submissionPanel
            // 
            submissionPanel.BorderStyle = BorderStyle.FixedSingle;
            submissionPanel.Location = new Point(532, 7);
            submissionPanel.Name = "submissionPanel";
            submissionPanel.Size = new Size(257, 320);
            submissionPanel.TabIndex = 1;
            submissionPanel.Paint += submissions_Paint;
            // 
            // assignmentPanel
            // 
            assignmentPanel.BorderStyle = BorderStyle.FixedSingle;
            assignmentPanel.Controls.Add(button2);
            assignmentPanel.Location = new Point(5, 6);
            assignmentPanel.Name = "assignmentPanel";
            assignmentPanel.Size = new Size(522, 320);
            assignmentPanel.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(442, 292);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 332);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Comment";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(commentPanel);
            panel1.Location = new Point(5, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 269);
            panel1.TabIndex = 2;
            // 
            // commentPanel
            // 
            commentPanel.AccessibleRole = AccessibleRole.None;
            commentPanel.BorderStyle = BorderStyle.FixedSingle;
            commentPanel.Location = new Point(2, 0);
            commentPanel.Name = "commentPanel";
            commentPanel.Size = new Size(677, 269);
            commentPanel.TabIndex = 0;
            commentPanel.Paint += commentPanel_Paint;
            // 
            // button3
            // 
            button3.Location = new Point(411, 291);
            button3.Name = "button3";
            button3.Size = new Size(59, 23);
            button3.TabIndex = 1;
            button3.Text = "Send";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 282);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(474, 44);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 332);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Submission";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(panel3);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(792, 332);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Report";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Image = Properties.Resources.icons8_back_30;
            button1.Location = new Point(758, 12);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.BorderStyle = BorderStyle.FixedSingle;
            classLabel.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            classLabel.Location = new Point(555, 18);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(34, 19);
            classLabel.TabIndex = 3;
            classLabel.Text = "Title";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._14;
            pictureBox2.Location = new Point(1, -6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(799, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(636, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(8, 8);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(792, 321);
            panel3.TabIndex = 0;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(classLabel);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(title);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form7";
            Load += Form7_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            assignmentPanel.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label title;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel submissionPanel;
        private Panel assignmentPanel;
        private Panel panel1;
        private FlowLayoutPanel commentPanel;
        private Label classLabel;
        private PictureBox pictureBox2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Panel panel3;
        private Panel panel2;
    }
}