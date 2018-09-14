using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticGame
{
    class QuestionsArrayList
    {
        public int questionNo1 { get; set; }
        public string questionOperator { get; set; }
        public int questionNo2 { get; set; }
        public string questionEquals { get; set; }
        public int questionAnswer { get; set; }


        public QuestionsArrayList(int question1, string aoperator, int question2, string tempEquals, int answer)
        {
            questionNo1 = question1;
            questionOperator = aoperator;
            questionNo2 = question2;
            questionAnswer = answer;
            questionEquals = tempEquals;
        }


        public void SetArray(ArrayList array)
        {
            QuestionsArrayList Questions = new QuestionsArrayList(questionNo1, questionOperator, questionNo2, questionEquals, questionAnswer);
            array.Add(Questions);
        }

        public void SetDataGrid(DataGridView dgv, ArrayList array)
        {
            dgv.DataSource = null;
            dgv.DataSource = array;
            dgv.ClearSelection();
        }

        public void BubbleSort(ArrayList array)
        {
            int length = array.Count;

            for (int i = 0; i < length - 1; i++)
            {
                for(int j = 0; j < length - 1 - i; j++)
                {
                   // if(array[j] < array[j + 1] )
                }
            }
        }
    }
}
