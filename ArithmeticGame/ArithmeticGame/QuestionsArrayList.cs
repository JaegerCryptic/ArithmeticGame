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
// file:	QuestionsArrayList.cs
//
// summary:	Implements the questions array list class
///-------------------------------------------------------------------------------------------------

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
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   List of questions arrays. </summary>
    ///
    /// <remarks>   Jaege, 17/09/2018. </remarks>
    ///-------------------------------------------------------------------------------------------------

    class QuestionsArrayList
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the question no 1. </summary>
        ///
        /// <value> The question no 1. </value>
        ///-------------------------------------------------------------------------------------------------

        public int questionNo1 { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the question operator. </summary>
        ///
        /// <value> The question operator. </value>
        ///-------------------------------------------------------------------------------------------------

        public string questionOperator { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the question no 2. </summary>
        ///
        /// <value> The question no 2. </value>
        ///-------------------------------------------------------------------------------------------------

        public int questionNo2 { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the question equals. </summary>
        ///
        /// <value> The question equals. </value>
        ///-------------------------------------------------------------------------------------------------

        public string questionEquals { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the question answer. </summary>
        ///
        /// <value> The question answer. </value>
        ///-------------------------------------------------------------------------------------------------

        public int questionAnswer { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///-------------------------------------------------------------------------------------------------

        public QuestionsArrayList()
        {

        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="question1">    The first question. </param>
        /// <param name="aoperator">    The aoperator. </param>
        /// <param name="question2">    The second question. </param>
        /// <param name="tempEquals">   The temporary equals. </param>
        /// <param name="answer">       The answer. </param>
        ///-------------------------------------------------------------------------------------------------

        public QuestionsArrayList(int question1, string aoperator, int question2, string tempEquals, int answer)
        {
            questionNo1 = question1;
            questionOperator = aoperator;
            questionNo2 = question2;
            questionAnswer = answer;
            questionEquals = tempEquals;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an array. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="array">    The array. </param>
        ///-------------------------------------------------------------------------------------------------

        public void GetArray(ArrayList array)
        {
            QuestionsArrayList Questions = new QuestionsArrayList(questionNo1, questionOperator, questionNo2, questionEquals, questionAnswer);
            array.Add(Questions);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets hash table. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="hashTable">    The hash table. </param>
        /// <param name="array">        The array. </param>
        ///-------------------------------------------------------------------------------------------------

        public void GetHashTable(Hashtable hashTable, ArrayList array)
        {
            QuestionsArrayList Questions = new QuestionsArrayList(questionNo1, questionOperator, questionNo2, questionEquals, questionAnswer);
            var cast = array.Cast<QuestionsArrayList>().ToDictionary(item => item.questionNo1 + item.questionOperator + 
            item.questionNo2 + item.questionEquals + item.questionAnswer);
            hashTable = new Hashtable(cast);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Sets data grid. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="dgv">      The dgv. </param>
        /// <param name="array">    The array. </param>
        ///-------------------------------------------------------------------------------------------------

        public void SetDataGrid(DataGridView dgv, ArrayList array)
        {
            dgv.DataSource = null;
            dgv.DataSource = array;
            dgv.ClearSelection();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Insertion sort. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="array">    The array. </param>
        /// <param name="dgv">      The dgv. </param>
        ///-------------------------------------------------------------------------------------------------

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

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Bubble sort. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="array">    The array. </param>
        /// <param name="dgv">      The dgv. </param>
        ///-------------------------------------------------------------------------------------------------

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

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Selection sort. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="array">    The array. </param>
        /// <param name="dgv">      The dgv. </param>
        ///-------------------------------------------------------------------------------------------------

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
