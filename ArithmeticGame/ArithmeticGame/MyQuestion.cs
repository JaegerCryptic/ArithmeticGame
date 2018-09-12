using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticGame
{
    class MyQuestion
    {
        public int questionNumber1 { get; set; }
        public int questionNumber2 { get; set; }
        public int questionAnswer { get; set; }
        public static InstructorQuestion Question = new InstructorQuestion();

        public static InstructorQuestion GetInstructorQuestion()
        {
            { return Question; }
        }

        public void SetInstructorQuestion()
        {
            questionNumber1 = Question.instructorFirstNumber;
            questionNumber2 = Question.instructorSecondNumber;
            questionAnswer = Question.instructorAnswer;
        }
    }
}
