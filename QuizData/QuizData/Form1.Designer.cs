namespace QuizData
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtStudentID = new Button();
            txtName = new Button();
            txtMajor = new Button();
            txtGrade = new Button();
            btnAddStudent = new Button();
            btnShowAdvisorStudents = new Button();
            btnShowAllStudents = new Button();
            btnShowTopStudent = new Button();
            label5 = new Label();
            cmbAdvisor = new ComboBox();
            IstDisplay = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 189);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "StudentID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 267);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 330);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Major";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 435);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Grade";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(135, 184);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(210, 24);
            txtStudentID.TabIndex = 4;
            txtStudentID.UseVisualStyleBackColor = true;
            txtStudentID.Click += txtStudentID_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(217, 262);
            txtName.Name = "txtName";
            txtName.Size = new Size(210, 24);
            txtName.TabIndex = 5;
            txtName.UseVisualStyleBackColor = true;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(352, 325);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(210, 24);
            txtMajor.TabIndex = 6;
            txtMajor.UseVisualStyleBackColor = true;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(420, 435);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(210, 24);
            txtGrade.TabIndex = 7;
            txtGrade.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(372, 89);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(233, 46);
            btnAddStudent.TabIndex = 8;
            btnAddStudent.Text = "AddStudent";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnShowAdvisorStudents
            // 
            btnShowAdvisorStudents.Location = new Point(529, 189);
            btnShowAdvisorStudents.Name = "btnShowAdvisorStudents";
            btnShowAdvisorStudents.Size = new Size(233, 44);
            btnShowAdvisorStudents.TabIndex = 9;
            btnShowAdvisorStudents.Text = "Show Advisor's Student";
            btnShowAdvisorStudents.UseVisualStyleBackColor = true;
            btnShowAdvisorStudents.Click += btnShowAdvisorStudents_Click;
            // 
            // btnShowAllStudents
            // 
            btnShowAllStudents.Location = new Point(672, 301);
            btnShowAllStudents.Name = "btnShowAllStudents";
            btnShowAllStudents.Size = new Size(233, 48);
            btnShowAllStudents.TabIndex = 10;
            btnShowAllStudents.Text = "Show All Student";
            btnShowAllStudents.UseVisualStyleBackColor = true;
            btnShowAllStudents.Click += btnShowAllStudents_Click;
            // 
            // btnShowTopStudent
            // 
            btnShowTopStudent.Location = new Point(783, 435);
            btnShowTopStudent.Name = "btnShowTopStudent";
            btnShowTopStudent.Size = new Size(233, 47);
            btnShowTopStudent.TabIndex = 11;
            btnShowTopStudent.Text = "Show Top Student";
            btnShowTopStudent.UseVisualStyleBackColor = true;
            btnShowTopStudent.Click += btnShowTopStudent_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(981, 92);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 12;
            label5.Text = "Advisor";
            label5.Click += label5_Click;
            // 
            // cmbAdvisor
            // 
            cmbAdvisor.FormattingEnabled = true;
            cmbAdvisor.Location = new Point(1050, 89);
            cmbAdvisor.Name = "cmbAdvisor";
            cmbAdvisor.Size = new Size(121, 23);
            cmbAdvisor.TabIndex = 13;
            // 
            // IstDisplay
            // 
            IstDisplay.FormattingEnabled = true;
            IstDisplay.ItemHeight = 15;
            IstDisplay.Location = new Point(981, 222);
            IstDisplay.Name = "IstDisplay";
            IstDisplay.Size = new Size(312, 154);
            IstDisplay.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1681, 686);
            Controls.Add(IstDisplay);
            Controls.Add(cmbAdvisor);
            Controls.Add(label5);
            Controls.Add(btnShowTopStudent);
            Controls.Add(btnShowAllStudents);
            Controls.Add(btnShowAdvisorStudents);
            Controls.Add(btnAddStudent);
            Controls.Add(txtGrade);
            Controls.Add(txtMajor);
            Controls.Add(txtName);
            Controls.Add(txtStudentID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Highlight;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button txtStudentID;
        private Button txtName;
        private Button txtMajor;
        private Button txtGrade;
        private Button btnAddStudent;
        private Button btnShowAdvisorStudents;
        private Button btnShowAllStudents;
        private Button btnShowTopStudent;
        private Label label5;
        private ComboBox cmbAdvisor;
        private ListBox IstDisplay;
    }
}
