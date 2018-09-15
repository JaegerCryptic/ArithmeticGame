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

        public StudentQuestion()
        {

        }

        public void CheckAnswer(TextBox answer, int instructorAnswer)
        {
            if (!String.IsNullOrEmpty(answer.Text))
            {
                int tempFirstNumber;
                if (int.TryParse(answer.Text, out tempFirstNumber))
                {
                    ValidateAnswer(tempFirstNumber, instructorAnswer);
                }
                else
                {
                    MessageBox.Show("Your answer does not have a numeric value please enter one.", "Incorrect Value",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ValidateAnswer(int studentAnswer, int answer)
        {
            if (studentAnswer == answer)
            {
                MessageBox.Show("This answer is correct.", "Correct!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This answer is incorrect.", "Incorrect",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
