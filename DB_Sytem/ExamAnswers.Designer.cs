namespace DB_Sytem
{
	partial class ExamAnswers
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
			lbl_backtohome = new Label();
			btn_show = new Button();
			dgv_ExamAnswers = new DataGridView();
			label2 = new Label();
			Department = new Label();
			cb_courses = new ComboBox();
			cb_departments = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dgv_ExamAnswers).BeginInit();
			SuspendLayout();
			// 
			// lbl_backtohome
			// 
			lbl_backtohome.AutoSize = true;
			lbl_backtohome.Location = new Point(21, 12);
			lbl_backtohome.Name = "lbl_backtohome";
			lbl_backtohome.Size = new Size(102, 15);
			lbl_backtohome.TabIndex = 26;
			lbl_backtohome.Text = "<< Back To Home";
			// 
			// btn_show
			// 
			btn_show.BackColor = Color.FromArgb(41, 128, 185);
			btn_show.FlatStyle = FlatStyle.Flat;
			btn_show.ForeColor = Color.White;
			btn_show.Location = new Point(497, 70);
			btn_show.Name = "btn_show";
			btn_show.Size = new Size(120, 34);
			btn_show.TabIndex = 25;
			btn_show.Text = "Show";
			btn_show.UseVisualStyleBackColor = false;
			// 
			// dgv_ExamAnswers
			// 
			dgv_ExamAnswers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_ExamAnswers.Location = new Point(42, 120);
			dgv_ExamAnswers.Name = "dgv_ExamAnswers";
			dgv_ExamAnswers.Size = new Size(575, 307);
			dgv_ExamAnswers.TabIndex = 24;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10F);
			label2.ForeColor = Color.FromArgb(41, 128, 185);
			label2.Location = new Point(40, 52);
			label2.Name = "label2";
			label2.Size = new Size(52, 19);
			label2.TabIndex = 22;
			label2.Text = "Course";
			// 
			// Department
			// 
			Department.AutoSize = true;
			Department.Font = new Font("Segoe UI", 10F);
			Department.ForeColor = Color.FromArgb(41, 128, 185);
			Department.Location = new Point(251, 52);
			Department.Name = "Department";
			Department.Size = new Size(83, 19);
			Department.TabIndex = 23;
			Department.Text = "Department";
			// 
			// cb_courses
			// 
			cb_courses.Font = new Font("Segoe UI", 12F);
			cb_courses.FormattingEnabled = true;
			cb_courses.Location = new Point(42, 75);
			cb_courses.Name = "cb_courses";
			cb_courses.Size = new Size(203, 29);
			cb_courses.TabIndex = 20;
			// 
			// cb_departments
			// 
			cb_departments.Font = new Font("Segoe UI", 12F);
			cb_departments.FormattingEnabled = true;
			cb_departments.Location = new Point(251, 75);
			cb_departments.Name = "cb_departments";
			cb_departments.Size = new Size(203, 29);
			cb_departments.TabIndex = 21;
			// 
			// ExamAnswers
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(661, 450);
			Controls.Add(lbl_backtohome);
			Controls.Add(btn_show);
			Controls.Add(dgv_ExamAnswers);
			Controls.Add(label2);
			Controls.Add(Department);
			Controls.Add(cb_courses);
			Controls.Add(cb_departments);
			Name = "ExamAnswers";
			Text = "ExamAnswers";
			((System.ComponentModel.ISupportInitialize)dgv_ExamAnswers).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbl_backtohome;
		private Button btn_show;
		private DataGridView dgv_ExamAnswers;
		private Label label2;
		private Label Department;
		private ComboBox cb_courses;
		private ComboBox cb_departments;
	}
}