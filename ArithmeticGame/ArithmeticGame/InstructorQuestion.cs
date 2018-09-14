using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticGame
{
    class InstructorQuestion
    {
        public int instructorFirstNumber { get; set; }
        public int instructorSecondNumber { get; set; }
        public int instructorAnswer { get; set; }
        public string aOperator { get; set; }
        public bool checkNo1 = false;
        public bool checkNo2 = false;

        public InstructorQuestion()
        {

        }

        public void MultuplyQuestion()
        {
            if (instructorFirstNumber != 0 && instructorSecondNumber != 0)
            {
                instructorAnswer = instructorFirstNumber * instructorSecondNumber;
                aOperator = "x";
            }
        }

        public void AddQuestion()
        {
            if (instructorFirstNumber != 0 && instructorSecondNumber != 0)
            {
                instructorAnswer = instructorFirstNumber + instructorSecondNumber;
                aOperator = "+";
            }
        }

        public void SubtractQuestion()
        {
            if (instructorFirstNumber != 0 && instructorSecondNumber != 0)
            {
                instructorAnswer = instructorFirstNumber - instructorSecondNumber;
                aOperator = "-";
            }
        }

        public void DivideQuestion()
        {
            if (instructorFirstNumber != 0 && instructorSecondNumber != 0)
            {
                instructorAnswer = instructorFirstNumber / instructorSecondNumber;
                aOperator = "÷";
            }
        }

        public void QuestionAnswer(ComboBox myOperator, TextBox myAnswer)
        {
            if (checkNo1 == true && checkNo2 == true)
            {
                Operators(myOperator, myAnswer);
            }
        }

        private void Operators(ComboBox myOperator, TextBox myAnswer)
        {
            if (myOperator.SelectedIndex == 0)
            {
                AddQuestion();
                myAnswer.Text = instructorAnswer.ToString();
            }
            else if (myOperator.SelectedIndex == 1)
            {
                SubtractQuestion();
                myAnswer.Text = instructorAnswer.ToString();
            }
            else if (myOperator.SelectedIndex == 2)
            {
                MultuplyQuestion();
                myAnswer.Text = instructorAnswer.ToString();
            }
            else if (myOperator.SelectedIndex == 3)
            {
                DivideQuestion();
                myAnswer.Text = instructorAnswer.ToString();
            }
        }

        public void ParseQuestion1(TextBox question)
        {
            if (!String.IsNullOrEmpty(question.Text))
            {
                int tempNumber;
                if (int.TryParse(question.Text, out tempNumber))
                {
                    instructorFirstNumber = tempNumber;
                    checkNo1 = true;
                }
                else
                {
                    MessageBox.Show("The value you just entered is not a numeric value. Please enter a number.", "Incorrect Value",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ParseQuestion2(TextBox question)
        {
            if (!String.IsNullOrEmpty(question.Text))
            {
                int tempNumber;
                if (int.TryParse(question.Text, out tempNumber))
                {
                    instructorSecondNumber = tempNumber;
                    checkNo2 = true;
                }
                else
                {
                    MessageBox.Show("The value you just entered is not a numeric value. Please enter a number.", "Incorrect Value",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
