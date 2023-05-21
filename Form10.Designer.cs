namespace Lab_10___21i_1239
{
    partial class Form10
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
            classLabel = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            assignmentPanel = new Panel();
            submitButton = new Button();
            submissionBox = new TextBox();
            panel2 = new Panel();
            submissionPanel = new FlowLayoutPanel();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            commentPanel = new FlowLayoutPanel();
            button3 = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            title = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            assignmentPanel.SuspendLayout();
            panel2.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.BorderStyle = BorderStyle.FixedSingle;
            classLabel.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            classLabel.Location = new Point(554, 21);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(34, 19);
            classLabel.TabIndex = 14;
            classLabel.Text = "Title";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 93);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 360);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(assignmentPanel);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 332);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Assignment";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // assignmentPanel
            // 
            assignmentPanel.BorderStyle = BorderStyle.FixedSingle;
            assignmentPanel.Controls.Add(submitButton);
            assignmentPanel.Controls.Add(submissionBox);
            assignmentPanel.Location = new Point(5, 6);
            assignmentPanel.Name = "assignmentPanel";
            assignmentPanel.Size = new Size(522, 320);
            assignmentPanel.TabIndex = 0;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(439, 282);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 0;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // submissionBox
            // 
            submissionBox.Location = new Point(1, 249);
            submissionBox.Multiline = true;
            submissionBox.Name = "submissionBox";
            submissionBox.Size = new Size(517, 65);
            submissionBox.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(submissionPanel);
            panel2.Location = new Point(526, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 326);
            panel2.TabIndex = 0;
            // 
            // submissionPanel
            // 
            submissionPanel.Location = new Point(3, 3);
            submissionPanel.Name = "submissionPanel";
            submissionPanel.Size = new Size(257, 312);
            submissionPanel.TabIndex = 0;
            submissionPanel.Paint += submissionPanel_Paint_1;
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
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Image = Properties.Resources.icons8_back_30;
            button1.Location = new Point(757, 15);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BorderStyle = BorderStyle.Fixed3D;
            title.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(15, 56);
            title.Name = "title";
            title.Size = new Size(55, 27);
            title.TabIndex = 12;
            title.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(9, 12);
            label1.Name = "label1";
            label1.Size = new Size(212, 40);
            label1.TabIndex = 11;
            label1.Text = "Assignment";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._14;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(799, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(classLabel);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(title);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "Form10";
            Text = "Form10";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            assignmentPanel.ResumeLayout(false);
            assignmentPanel.PerformLayout();
            panel2.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label classLabel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel assignmentPanel;
        private Button button2;
        private TabPage tabPage2;
        private Panel panel1;
        private FlowLayoutPanel commentPanel;
        private Button button3;
        private TextBox textBox1;
        private Button button1;
        private Label title;
        private Label label1;
        private PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button submitButton;
        private TextBox submissionBox;
        private Panel panel2;
        private FlowLayoutPanel submissionPanel;
    }
}