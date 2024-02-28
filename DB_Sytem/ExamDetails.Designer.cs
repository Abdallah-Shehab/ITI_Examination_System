namespace DB_Sytem
{
	partial class ExamDetails
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
			Department = new Label();
			cb_departments = new ComboBox();
			dgv_ExamQuestions = new DataGridView();
			cb_courses = new ComboBox();
			label2 = new Label();
			lbl_backtohome = new Label();
			btn_show = new Button();
			((System.ComponentModel.ISupportInitialize)dgv_ExamQuestions).BeginInit();
			SuspendLayout();
			// 
			// Department
			// 
			Department.AutoSize = true;
			Department.Font = new Font("Segoe UI", 10F);
			Department.ForeColor = Color.FromArgb(41, 128, 185);
			Department.Location = new Point(236, 50);
			Department.Name = "Department";
			Department.Size = new Size(83, 19);
			Department.TabIndex = 9;
			Department.Text = "Department";
			// 
			// cb_departments
			// 
			cb_departments.Font = new Font("Segoe UI", 12F);
			cb_departments.FormattingEnabled = true;
			cb_departments.Location = new Point(236, 73);
			cb_departments.Name = "cb_departments";
			cb_departments.Size = new Size(203, 29);
			cb_departments.TabIndex = 8;
			// 
			// dgv_ExamQuestions
			// 
			dgv_ExamQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_ExamQuestions.Location = new Point(27, 118);
			dgv_ExamQuestions.Name = "dgv_ExamQuestions";
			dgv_ExamQuestions.Size = new Size(575, 307);
			dgv_ExamQuestions.TabIndex = 10;
			// 
			// cb_courses
			// 
			cb_courses.Font = new Font("Segoe UI", 12F);
			cb_courses.FormattingEnabled = true;
			cb_courses.Location = new Point(27, 73);
			cb_courses.Name = "cb_courses";
			cb_courses.Size = new Size(203, 29);
			cb_courses.TabIndex = 8;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10F);
			label2.ForeColor = Color.FromArgb(41, 128, 185);
			label2.Location = new Point(25, 50);
			label2.Name = "label2";
			label2.Size = new Size(52, 19);
			label2.TabIndex = 9;
			label2.Text = "Course";
			// 
			// lbl_backtohome
			// 
			lbl_backtohome.AutoSize = true;
			lbl_backtohome.Cursor = Cursors.Hand;
			lbl_backtohome.Location = new Point(12, 9);
			lbl_backtohome.Name = "lbl_backtohome";
			lbl_backtohome.Size = new Size(102, 15);
			lbl_backtohome.TabIndex = 11;
			lbl_backtohome.Text = "<< Back To Home";
			lbl_backtohome.Click += lbl_backtohome_Click;
			// 
			// btn_show
			// 
			btn_show.BackColor = Color.FromArgb(41, 128, 185);
			btn_show.FlatStyle = FlatStyle.Flat;
			btn_show.ForeColor = Color.White;
			btn_show.Location = new Point(482, 68);
			btn_show.Name = "btn_show";
			btn_show.Size = new Size(120, 34);
			btn_show.TabIndex = 12;
			btn_show.Text = "Show";
			btn_show.UseVisualStyleBackColor = false;
			// 
			// ExamDetails
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(622, 450);
			Controls.Add(btn_show);
			Controls.Add(lbl_backtohome);
			Controls.Add(dgv_ExamQuestions);
			Controls.Add(label2);
			Controls.Add(Department);
			Controls.Add(cb_courses);
			Controls.Add(cb_departments);
			Name = "ExamDetails";
			Text = "ExamDetails";
			((System.ComponentModel.ISupportInitialize)dgv_ExamQuestions).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label Department;
		private ComboBox cb_departments;
		private DataGridView dgv_ExamQuestions;
		private ComboBox cb_courses;
		private Label label2;
		private Label lbl_backtohome;
		private Button btn_show;
	}
}