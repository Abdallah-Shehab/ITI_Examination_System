using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Sytem
{
	public partial class Instructor_HomePage : Form
	{
		public Instructor_HomePage()
		{
			InitializeComponent();
		}

		//private void button1_Click(object sender, EventArgs e)
		//{
		//	this.Hide();
		//	Instructor_Exam examWindow = new Instructor_Exam();
		//	examWindow.ShowDialog();
		//	this.Close();
		//}

		private void btn_allExams_Click(object sender, EventArgs e)
		{
			this.Hide();
			ExamDetails examDetails = new ExamDetails();
			examDetails.ShowDialog();
			this.Close();
		}
		private void btn_createExam_Click(object sender, EventArgs e)
		{
			this.Hide();
			Instructor_Exam examWindow = new Instructor_Exam();
			examWindow.ShowDialog();
			this.Close();
		}
		private void btn_createQues_Click(object sender, EventArgs e)
		{
			this.Hide();
			CreateQuestions ques = new CreateQuestions();
			ques.ShowDialog();
			this.Close();
		}
		private void btn_answers_Click(object sender, EventArgs e)
		{
			this.Hide();
			ExamAnswers stsAnswers = new ExamAnswers();
			stsAnswers.ShowDialog();
			this.Close();
		}
		private void btn_studentsGrades_Click(object sender, EventArgs e)
		{
			this.Hide();
			StudentsGrades stsGrades = new StudentsGrades();
			stsGrades.ShowDialog();
			this.Close();
		}


		private void lbl_logout_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login login = new Login();
			login.ShowDialog();
			this.Close();
		}

		
	}
}
