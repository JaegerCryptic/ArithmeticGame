using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticGame
{
    public partial class StudentForm : Form
    {
        StudentQuestion Answer = new StudentQuestion();
        StudentConnection Question = new StudentConnection();


        public StudentForm()
        {
            InitializeComponent();
            Question.SetPackageAsync(txtQuestion);
            Question.UpdateControlState(btnSubmit);
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Answer.CheckAnswer(txtStudentAnswer, Question.instructorAnswer, Question);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
