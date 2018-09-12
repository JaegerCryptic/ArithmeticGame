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

        public InstructorQuestion()
        {

        }

        public InstructorQuestion(int firstNumber, int secondNumber)
        {
            instructorFirstNumber = firstNumber;
            instructorSecondNumber = secondNumber;
        }

       public void MultuplyQuestion()
       {
            if (instructorFirstNumber != 0 && instructorSecondNumber != 0)
            {
                instructorAnswer = instructorFirstNumber * instructorSecondNumber;
                MyQuestion.GetInstructorQuestion().instructorFirstNumber = instructorFirstNumber;
                MyQuestion.GetInstructorQuestion().instructorSecondNumber = instructorSecondNumber;
                MyQuestion.GetInstructorQuestion().instructorAnswer = instructorAnswer;
                MyQuestion.GetInstructorQuestion().aOperator = "x";
            }
        }
       
       public void AddQuestion()
       {
            if (instructorFirstNumber != 0 && instructorSecondNumber != 0)
            {
                instructorAnswer = instructorFirstNumber + instructorSecondNumber;
                MyQuestion.GetInstructorQuestion().instructorFirstNumber = instructorFirstNumber;
                MyQuestion.GetInstructorQuestion().instructorSecondNumber = instructorSecondNumber;
                MyQuestion.GetInstructorQuestion().instructorAnswer = instructorAnswer;
                MyQuestion.GetInstructorQuestion().aOperator = "+";
            }
        }

       public void SubtractQuestion()
       {
            if (instructorFirstNumber != 0 && instructorSecondNumber != 0)
            {
                instructorAnswer = instructorFirstNumber - instructorSecondNumber;
                MyQuestion.GetInstructorQuestion().instructorFirstNumber = instructorFirstNumber;
                MyQuestion.GetInstructorQuestion().instructorSecondNumber = instructorSecondNumber;
                MyQuestion.GetInstructorQuestion().instructorAnswer = instructorAnswer;
                MyQuestion.GetInstructorQuestion().aOperator = "-";
            }
        }

       public void DivideQuestion()
       {
            if (instructorFirstNumber != 0 && instructorSecondNumber != 0)
            {
                instructorAnswer = instructorFirstNumber / instructorSecondNumber;
                MyQuestion.GetInstructorQuestion().instructorFirstNumber = instructorFirstNumber;
                MyQuestion.GetInstructorQuestion().instructorSecondNumber = instructorSecondNumber;
                MyQuestion.GetInstructorQuestion().instructorAnswer = instructorAnswer;
                MyQuestion.GetInstructorQuestion().aOperator = "÷";
            }
        }
        
       public void QuestionAnswer(bool checkNo1, bool checkNo2, int answer, ComboBox myOperator, TextBox myAnswer)
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
    }
}
