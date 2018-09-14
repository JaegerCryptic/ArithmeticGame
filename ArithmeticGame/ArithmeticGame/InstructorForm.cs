using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticGame
{
    public partial class InstructorForm : Form
    {
        InstructorQuestion Question = new InstructorQuestion();

        public InstructorForm()
        {
            InitializeComponent();
        }

        private void txtFirstNumber_TextChanged(object sender, EventArgs e)
        {
            Question.ParseQuestion1(txtFirstNumber);
            Question.QuestionAnswer(cmboOperator, txtAnswer);
        }

        private void txtSecondNumber_TextChanged(object sender, EventArgs e)
        {
            Question.ParseQuestion2(txtSecondNumber);
            Question.QuestionAnswer(cmboOperator, txtAnswer);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmboOperator.SelectedIndex = 0;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            InstructorConnection Package = new InstructorConnection(Question.instructorFirstNumber, Question.aOperator, Question.instructorSecondNumber,
                Question.instructorAnswer);
            Package.ConnectQuestion();
        }
    }
}
