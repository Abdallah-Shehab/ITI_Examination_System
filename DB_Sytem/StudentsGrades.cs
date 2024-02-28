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
	public partial class StudentsGrades : Form
	{
		public StudentsGrades()
		{
			InitializeComponent();
		}

		private void lbl_backtohome_Click(object sender, EventArgs e)
		{
			this.Hide();
			Instructor_HomePage home = new Instructor_HomePage();
			home.ShowDialog();
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
