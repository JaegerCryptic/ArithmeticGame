using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticGame
{
    class StudentQuestion
    {
        string studentQuestion = MyQuestion.Question.instructorFirstNumber.ToString() + " " + MyQuestion.Question.aOperator
            + " " + MyQuestion.Question.instructorSecondNumber.ToString() + " =";

        public StudentQuestion()
        {

        }

        public StudentQuestion(TextBox question)
        {
            question.Text = studentQuestion;
        }

        public void CheckAnswer(TextBox answer)
        {
            if (!String.IsNullOrEmpty(answer.Text))
            {
                int tempFirstNumber;
                if (int.TryParse(answer.Text, out tempFirstNumber))
                {
                    ValidateAnswer(tempFirstNumber);
                }
                else
                {
                    MessageBox.Show("Your answer does not have a numeric value please enter one.", "Incorrect Value",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ValidateAnswer(int answer)
        {
            if(answer == MyQuestion.Question.instructorAnswer)
            {
                MessageBox.Show("This answer is correct. Well done!", "Correct!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This answer is incorrect. Try again.", "Incorrect",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
