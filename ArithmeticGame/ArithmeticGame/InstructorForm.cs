using System;
using System.Collections;
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
        ArrayList QuestionList = new ArrayList();

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
            //InstructorConnection Package = new InstructorConnection(Question.instructorFirstNumber, Question.aOperator, Question.instructorSecondNumber,
            //    Question.instructorAnswer);

            //Package.ConnectQuestion();

              QuestionsArrayList List = new QuestionsArrayList(Question.instructorFirstNumber, Question.aOperator, Question.instructorSecondNumber, Question.equals,
                Question.instructorAnswer);

            List.SetArray(QuestionList);
            List.SetDataGrid(dataGridArray, QuestionList);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSort1_Click(object sender, EventArgs e)
        {
            //Bubble Sort
            
        }
    }
}
