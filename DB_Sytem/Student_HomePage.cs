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
    public partial class Student_HomePage : Form
    {
        string St_name = "";
        public Student_HomePage(string st_name)
        {
            InitializeComponent();
            St_name = st_name;
        }

        private void Student_HomePage_Load(object sender, EventArgs e)
        {
            lbl_studentName.Text = St_name;
        }
    }
}
