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


        public QuestionsArrayList()
        {

        }

        public QuestionsArrayList(int question1, string aoperator, int question2, string tempEquals, int answer)
        {
            questionNo1 = question1;
            questionOperator = aoperator;
            questionNo2 = question2;
            questionAnswer = answer;
            questionEquals = tempEquals;
        }


        public void GetArray(ArrayList array)
        {
            QuestionsArrayList Questions = new QuestionsArrayList(questionNo1, questionOperator, questionNo2, questionEquals, questionAnswer);
            array.Add(Questions);
        }

        public void GetHashTable(Hashtable hashTable, ArrayList array)
        {
            QuestionsArrayList Questions = new QuestionsArrayList(questionNo1, questionOperator, questionNo2, questionEquals, questionAnswer);
            var cast = array.Cast<QuestionsArrayList>().ToDictionary(item => item.questionNo1 + item.questionOperator + 
            item.questionNo2 + item.questionEquals + item.questionAnswer);
            hashTable = new Hashtable(cast);
        }

        public void SetDataGrid(DataGridView dgv, ArrayList array)
        {
            dgv.DataSource = null;
            dgv.DataSource = array;
            dgv.ClearSelection();
        }


        public void InsertionSort(ArrayList array, DataGridView dgv)
        {
            var list = array.Cast<QuestionsArrayList>().ToList();

            for(int i = 0; i < array.Count - 1; i++)
            {
                int j = i + 1;
                while (j > 0)
                {
                    if(string.Compare(list[j - 1].questionOperator, list[j].questionOperator) < 0)
                    {
                        QuestionsArrayList temp = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = temp;

                        array = new ArrayList(list);

                        dgv.DataSource = null;
                        dgv.DataSource = array;
                        dgv.ClearSelection();
                    }
                    j--;
                }
            }
        }

        public void BubbleSort(ArrayList array, DataGridView dgv)
        {
            var list = array.Cast<QuestionsArrayList>().ToList();

            for (int i = 0; i < array.Count - 1; i++)
            {
                for(int j = 0; j < array.Count - 1 - i; j++)
                {
                    if (string.Compare(list[j].questionOperator, list[j + 1].questionOperator) > 0)
                    {
                        QuestionsArrayList temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;

                        array = new ArrayList(list);

                        dgv.DataSource = null;
                        dgv.DataSource = array;
                        dgv.ClearSelection();
                    }
                }
            }
        }

        public void SelectionSort(ArrayList array, DataGridView dgv)
        {
            var list = array.Cast<QuestionsArrayList>().ToList();

            for(int i = 0; i < array.Count - 1; i++)
            {
                int smallest = i;

                for(int j = i; j < array.Count; j++)
                {
                    if(string.Compare(list[j].questionOperator, list[smallest].questionOperator) < 0)
                    {
                        smallest = j;

                        QuestionsArrayList temp = list[i];
                        list[i] = list[smallest];
                        list[smallest] = temp;

                        array = new ArrayList(list);

                        dgv.DataSource = null;
                        dgv.DataSource = array;
                        dgv.ClearSelection();
                    }
                   
                }
            }
        }

    }
}
