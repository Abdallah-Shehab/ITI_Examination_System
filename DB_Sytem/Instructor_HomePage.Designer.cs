﻿namespace DB_Sytem
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
			lbl_insName = new Label();
			btn_createQues = new Button();
			SuspendLayout();
			// 
			// btn_allExams
			// 
			btn_allExams.BackColor = Color.FromArgb(41, 128, 185);
			btn_allExams.FlatStyle = FlatStyle.Flat;
			btn_allExams.ForeColor = Color.White;
			btn_allExams.Location = new Point(117, 158);
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
			btn_createExam.Location = new Point(117, 198);
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
			btn_answers.Location = new Point(117, 278);
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
			btn_studentsGrades.Location = new Point(117, 318);
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
			lbl_logout.Click += lbl_logout_Click;
			// 
			// lbl_insName
			// 
			lbl_insName.AutoSize = true;
			lbl_insName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_insName.ForeColor = Color.FromArgb(41, 128, 185);
			lbl_insName.Location = new Point(66, 67);
			lbl_insName.Name = "lbl_insName";
			lbl_insName.Size = new Size(284, 30);
			lbl_insName.TabIndex = 12;
			lbl_insName.Text = "Welcome Instructor's Name";
			lbl_insName.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btn_createQues
			// 
			btn_createQues.BackColor = Color.FromArgb(41, 128, 185);
			btn_createQues.FlatStyle = FlatStyle.Flat;
			btn_createQues.ForeColor = Color.White;
			btn_createQues.Location = new Point(117, 238);
			btn_createQues.Name = "btn_createQues";
			btn_createQues.Size = new Size(189, 34);
			btn_createQues.TabIndex = 1;
			btn_createQues.Text = "Create and Update Questions";
			btn_createQues.UseVisualStyleBackColor = false;
			btn_createQues.Click += btn_createQues_Click;
			// 
			// Instructor_HomePage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(418, 415);
			Controls.Add(lbl_insName);
			Controls.Add(lbl_logout);
			Controls.Add(btn_studentsGrades);
			Controls.Add(btn_createQues);
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
		private Label lbl_insName;
		private Button btn_createQues;
	}
}