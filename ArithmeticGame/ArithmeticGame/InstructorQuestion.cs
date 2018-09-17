///-------------------------------------------------------------------------------------------------
///	Author: Kyle Kent
/// 
/// Student Number: 465510139
///	
/// Purpose: Arithmetic Game
/// 
/// Version Control: GitHub
///-------------------------------------------------------------------------------------------------

///-------------------------------------------------------------------------------------------------
// file:	InstructorQuestion.cs
//
// summary:	Implements the instructor question class
///-------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticGame
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   An instructor question. </summary>
    ///
    /// <remarks>   Jaege, 17/09/2018. </remarks>
    ///-------------------------------------------------------------------------------------------------

    class InstructorQuestion
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the instructor first number. </summary>
        ///
        /// <value> The instructor first number. </value>
        ///-------------------------------------------------------------------------------------------------

        public int instructorFirstNumber { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the instructor second number. </summary>
        ///
        /// <value> The instructor second number. </value>
        ///-------------------------------------------------------------------------------------------------

        public int instructorSecondNumber { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the instructor answer. </summary>
        ///
        /// <value> The instructor answer. </value>
        ///-------------------------------------------------------------------------------------------------

        public int instructorAnswer { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the operator. </summary>
        ///
        /// <value> a operator. </value>
        ///-------------------------------------------------------------------------------------------------

        public string aOperator { get; set; }
        /// <summary>   True to check no 1. </summary>
        public bool checkNo1 = false;
        /// <summary>   True to check no 2. </summary>
        public bool checkNo2 = false;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the equals. </summary>
        ///
        /// <value> The equals. </value>
        ///-------------------------------------------------------------------------------------------------

        public string equals { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///-------------------------------------------------------------------------------------------------

        public InstructorQuestion()
        {

        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Multiuply question. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///-------------------------------------------------------------------------------------------------

        public void MultiplyQuestion()
        {
            if (instructorFirstNumber != 0 && instructorSecondNumber != 0)
            {
                instructorAnswer = instructorFirstNumber * instructorSecondNumber;
                aOperator = "x";
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Adds question. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///-------------------------------------------------------------------------------------------------

        public void AddQuestion()
        {
            if (instructorFirstNumber != 0 && instructorSecondNumber != 0)
            {
                instructorAnswer = instructorFirstNumber + instructorSecondNumber;
                aOperator = "+";
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Subtract question. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///-------------------------------------------------------------------------------------------------

        public void SubtractQuestion()
        {
            if (instructorFirstNumber != 0 && instructorSecondNumber != 0)
            {
                instructorAnswer = instructorFirstNumber - instructorSecondNumber;
                aOperator = "-";
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Divide question. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///-------------------------------------------------------------------------------------------------

        public void DivideQuestion()
        {
            if (instructorFirstNumber != 0 && instructorSecondNumber != 0)
            {
                instructorAnswer = instructorFirstNumber / instructorSecondNumber;
                aOperator = "÷";
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Question answer. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="myOperator">   my operator. </param>
        /// <param name="myAnswer">     my answer control. </param>
        ///-------------------------------------------------------------------------------------------------

        public void QuestionAnswer(ComboBox myOperator, TextBox myAnswer)
        {
            if (checkNo1 == true && checkNo2 == true)
            {
                equals = "=";
                Operators(myOperator, myAnswer);
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Operators. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="myOperator">   my operator. </param>
        /// <param name="myAnswer">     my answer control. </param>
        ///-------------------------------------------------------------------------------------------------

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
                MultiplyQuestion();
                myAnswer.Text = instructorAnswer.ToString();
            }
            else if (myOperator.SelectedIndex == 3)
            {
                DivideQuestion();
                myAnswer.Text = instructorAnswer.ToString();
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Parse question 1. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="question"> The question. </param>
        ///-------------------------------------------------------------------------------------------------

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

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Parse question 2. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="question"> The question. </param>
        ///-------------------------------------------------------------------------------------------------

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
