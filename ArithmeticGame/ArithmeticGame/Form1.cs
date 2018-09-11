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
    public partial class Form1 : Form
    {
        bool firstNo = false;
        bool secondNo = false;
        int instructorNo1;
        int instructorNo2;
        int instuctorQuestionAnswer;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtFirstNumber_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtFirstNumber.Text))
            {
                int tempFirstNumber;
                if (int.TryParse(txtFirstNumber.Text, out tempFirstNumber))
                {
                    instructorNo1 = tempFirstNumber;
                    firstNo = true;

                    InstructorQuestion Question = new InstructorQuestion(instructorNo1, instructorNo2);
                    Question.QuestionAnswer(firstNo, secondNo, instuctorQuestionAnswer, cmboOperator, txtAnswer, Question);
                }
                else
                {
                    MessageBox.Show("The first number is not a numeric value. Please enter a number.", "Incorrect Value",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSecondNumber_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSecondNumber.Text))
            {
                 int tempInstructorNo2;
                if(int.TryParse(txtSecondNumber.Text, out tempInstructorNo2))
                {
                    instructorNo2 = tempInstructorNo2;
                    secondNo = true;

                    InstructorQuestion Question = new InstructorQuestion(instructorNo1, instructorNo2);
                    Question.QuestionAnswer(firstNo, secondNo, instuctorQuestionAnswer, cmboOperator, txtAnswer, Question);
                }
                else
                {
                    MessageBox.Show("The second number is not a numeric value. Please enter a number.", "Incorrect Value",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmboOperator.SelectedIndex = 0;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;

        }
    }
}
