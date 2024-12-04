using StudentManager.Presentation.Course;
using StudentManager.Presentation.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager.Presentation.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnNextStudent_Click(object sender, EventArgs e)
        {
            new StudentForm().Show();
        }

        private void BtnNextCourse_Click(object sender, EventArgs e)
        {
            new CourseForm().Show();
        }
    }
}
