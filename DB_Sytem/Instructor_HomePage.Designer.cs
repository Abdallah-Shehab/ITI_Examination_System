namespace DB_Sytem
{
	partial class Instructor_HomePage
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
			btn_allExams = new Button();
			btn_createExam = new Button();
			btn_answers = new Button();
			btn_studentsGrades = new Button();
			lbl_logout = new Label();
			label1 = new Label();
			SuspendLayout();
			// 
			// btn_allExams
			// 
			btn_allExams.BackColor = Color.FromArgb(41, 128, 185);
			btn_allExams.FlatStyle = FlatStyle.Flat;
			btn_allExams.ForeColor = Color.White;
			btn_allExams.Location = new Point(117, 168);
			btn_allExams.Name = "btn_allExams";
			btn_allExams.Size = new Size(189, 34);
			btn_allExams.TabIndex = 1;
			btn_allExams.Text = "Show All Exams";
			btn_allExams.UseVisualStyleBackColor = false;
			btn_allExams.Click += btn_allExams_Click;
			// 
			// btn_createExam
			// 
			btn_createExam.BackColor = Color.FromArgb(41, 128, 185);
			btn_createExam.FlatStyle = FlatStyle.Flat;
			btn_createExam.ForeColor = Color.White;
			btn_createExam.Location = new Point(117, 208);
			btn_createExam.Name = "btn_createExam";
			btn_createExam.Size = new Size(189, 34);
			btn_createExam.TabIndex = 1;
			btn_createExam.Text = "Create Exam";
			btn_createExam.UseVisualStyleBackColor = false;
			btn_createExam.Click += btn_createExam_Click;
			// 
			// btn_answers
			// 
			btn_answers.BackColor = Color.FromArgb(41, 128, 185);
			btn_answers.FlatStyle = FlatStyle.Flat;
			btn_answers.ForeColor = Color.White;
			btn_answers.Location = new Point(117, 248);
			btn_answers.Name = "btn_answers";
			btn_answers.Size = new Size(189, 34);
			btn_answers.TabIndex = 1;
			btn_answers.Text = "Students Answers";
			btn_answers.UseVisualStyleBackColor = false;
			btn_answers.Click += btn_answers_Click;
			// 
			// btn_studentsGrades
			// 
			btn_studentsGrades.BackColor = Color.FromArgb(41, 128, 185);
			btn_studentsGrades.FlatStyle = FlatStyle.Flat;
			btn_studentsGrades.ForeColor = Color.White;
			btn_studentsGrades.Location = new Point(117, 288);
			btn_studentsGrades.Name = "btn_studentsGrades";
			btn_studentsGrades.Size = new Size(189, 34);
			btn_studentsGrades.TabIndex = 1;
			btn_studentsGrades.Text = "Students Grades";
			btn_studentsGrades.UseVisualStyleBackColor = false;
			btn_studentsGrades.Click += btn_studentsGrades_Click;
			// 
			// lbl_logout
			// 
			lbl_logout.AutoSize = true;
			lbl_logout.Cursor = Cursors.Hand;
			lbl_logout.ForeColor = Color.Crimson;
			lbl_logout.Location = new Point(12, 9);
			lbl_logout.Name = "lbl_logout";
			lbl_logout.Size = new Size(50, 15);
			lbl_logout.TabIndex = 12;
			lbl_logout.Text = "Log Out";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Cursor = Cursors.Hand;
			label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(41, 128, 185);
			label1.Location = new Point(66, 67);
			label1.Name = "label1";
			label1.Size = new Size(284, 30);
			label1.TabIndex = 12;
			label1.Text = "Welcome Instructor's Name";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Instructor_HomePage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(418, 415);
			Controls.Add(label1);
			Controls.Add(lbl_logout);
			Controls.Add(btn_studentsGrades);
			Controls.Add(btn_answers);
			Controls.Add(btn_createExam);
			Controls.Add(btn_allExams);
			Name = "Instructor_HomePage";
			Text = "Instructor_HomePage";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn_allExams;
		private Button btn_createExam;
		private Button btn_answers;
		private Button btn_studentsGrades;
		private Label lbl_logout;
		private Label label1;
	}
}