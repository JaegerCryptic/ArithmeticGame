using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticGame
{
    class InstructorQuestion : Form1
    {
       int instructorFirstNumber { get; set; }
       int instructorSecondNumber { get; set; }
       public int instructorAnswer { get; set; }

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
            }
       }
       
       public void AddQuestion()
       {
            if (instructorFirstNumber != 0 && instructorSecondNumber != 0)
            {
                instructorAnswer = instructorFirstNumber + instructorSecondNumber;
            }
       }

       public void SubtractQuestion()
       {
            if (instructorFirstNumber != 0 && instructorSecondNumber != 0)
            {
                instructorAnswer = instructorFirstNumber - instructorSecondNumber;
            }
       }

       public void DivideQuestion()
       {
            if (instructorFirstNumber != 0 && instructorSecondNumber != 0)
            {
                instructorAnswer = instructorFirstNumber / instructorSecondNumber;
            }
       }
        
    }
}
