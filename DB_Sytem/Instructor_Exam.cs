using DB_Sytem.Models;
using Microsoft.EntityFrameworkCore;
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
        ITIDBContext context = new ITIDBContext();


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

        private void lbl_backtohome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructor_HomePage home = new Instructor_HomePage();
            home.ShowDialog();
            this.Close();
        }

        private void Instructor_Exam_Load(object sender, EventArgs e)
        {
            var crs = context.courses.ToList();

            foreach (var course in crs)
            {
                course.name = course.name.Trim();
            }
            cb_crs.DataSource = crs;
            cb_crs.DisplayMember = "name";

            cb_crs.ValueMember = "course_ID";
            cb_crs.SelectedIndex = -1;

            //var exams = context.exams.Select(e => e.exam_ID).ToList();

            try
            {


                var exam = context.exams.Select(e => new
                {
                    e.exam_ID,

                    Course = e.course.name.Trim(),
                    e.time,
                    e.date,
                    e.duration,
                    //e.course.grade

                }).ToList();
                dgv_ExamQuestions.DataSource = exam;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }





        }

        private void cb_crs_SelectedIndexChanged(object sender, EventArgs e)
        {

            int? val = (int)cb_crs.SelectedValue;
            var crs_dept = context.ins_course_depts
                .Where(c => c.course_ID == val)
                .Select(i => new
                {
                    i.dept_ID,
                    name = i.dept.name.Trim()
                }).ToList();

            var crs = context.courses.FirstOrDefault(i => i.course_ID == val);


            cb_dept.SelectedIndex = -1;
            cb_dept.DataSource = crs_dept;
            cb_dept.DisplayMember = "name";

            cb_dept.ValueMember = "dept_ID";

            txt_grade.Text = crs.grade.ToString();
            num_duration.Value = (int)crs.duration;
            txt_grade.Enabled = false;


        }

        async private void btn_generate_Click(object sender, EventArgs e)
        {
            ITIDBContextProcedures dbProc = new ITIDBContextProcedures(context);

            try
            {
                int? val = (int)cb_crs.SelectedValue;
                TimeSpan timeOfDay = dt_time.Value.TimeOfDay;
                TimeOnly timeOnly = new TimeOnly(timeOfDay.Hours, timeOfDay.Minutes, timeOfDay.Seconds);

                DateTime dtDate = dt_date.Value;
                OutputParameter<int?> examIDParameter = new OutputParameter<int?>();
                await dbProc.Generate_ExamAsync(timeOfDay, dtDate, (int)num_duration.Value, val, examIDParameter);
                int? examID = examIDParameter.Value;

                var exams = context.exams.Select(e => new
                {
                    e.exam_ID,
                    CrsName = e.course.name.Trim(),
                    e.time,
                    e.date,
                    e.duration,
                    //e.course.grade
                }).ToList();
               

                var studentsWithCourseID1 = context.students
                .Where(s => s.courses.Any(c => c.course_ID == val))
                .ToList();

                foreach (var student in studentsWithCourseID1)
                {

                    await dbProc.insert_st_examAsync(student.st_ID, examID, null);
                }



                dgv_ExamQuestions.DataSource = exams;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cb_subject_DropDown(object sender, EventArgs e)
        {
            var crs = context.courses.ToList();

            foreach (var course in crs)
            {
                course.name = course.name.Trim();
            }
            cb_subject.DataSource = crs;

            cb_subject.DisplayMember = "name";
            cb_subject.ValueMember = "course_ID";
            cb_subject.SelectedIndex = -1;
        }



        private void cb_subject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cb_exam.SelectedIndex = -1;
            int? val = (int)cb_subject.SelectedValue;

            var exams = context.exams.Where(i => i.course_ID == val).Select(e => new { date = e.date.ToString(), e.exam_ID }).ToList();

            cb_exam.DataSource = exams;
            cb_exam.DisplayMember = "date";
            cb_exam.ValueMember = "exam_ID";

        }
    }
}
