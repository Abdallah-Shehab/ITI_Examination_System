namespace DB_Sytem
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void btn_login_Click(object sender, EventArgs e)
		{

			this.Hide();
			Instructor_HomePage ins = new Instructor_HomePage();
			ins.ShowDialog();
			this.Close();
		}

		
	}
}
