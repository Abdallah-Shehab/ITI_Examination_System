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
    public partial class Exam_Creation : Form
    {
        public Exam_Creation()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dt_date.Value.Date.Date + "\n" + dt_time.Value.TimeOfDay);

        }
    }
}
