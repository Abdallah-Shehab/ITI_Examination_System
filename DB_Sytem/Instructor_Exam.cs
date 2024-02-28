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
	public partial class Instructor_Exam : Form
	{
		public Instructor_Exam()
		{
			InitializeComponent();
		}

		private void btn_create_Click(object sender, EventArgs e)
		{
			this.Hide();
			Exam_Creation exam = new Exam_Creation();
			exam.ShowDialog();
			this.Show();
		}
	}
}
