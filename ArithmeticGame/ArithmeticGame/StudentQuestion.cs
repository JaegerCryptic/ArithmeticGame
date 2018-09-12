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

        public StudentQuestion(TextBox question, TextBox answer)
        {
            question.Text = studentQuestion;
        }
    }
}
