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
// file:	InstructorForm.cs
//
// summary:	Implements the instructor Windows Form
///-------------------------------------------------------------------------------------------------

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
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Form for viewing the instructor. </summary>
    ///
    /// <remarks>   Jaege, 17/09/2018. </remarks>
    ///-------------------------------------------------------------------------------------------------

    public partial class InstructorForm : Form
    {
        /// <summary>   The question. </summary>
        InstructorQuestion Question = new InstructorQuestion();
        /// <summary>   The list. </summary>
        QuestionsArrayList List = new QuestionsArrayList();
        /// <summary>   List of questions. </summary>
        ArrayList QuestionList = new ArrayList();
        /// <summary>   The question table. </summary>
        Hashtable QuestionTable = new Hashtable();
        /// <summary>   The binary tree. </summary>
        Tree BinaryTree = new Tree();
        /// <summary>   The root. </summary>
        Node Root;
        /// <summary>   List of my linked. </summary>
        NodeList MyLinkedList = null;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///-------------------------------------------------------------------------------------------------

        public InstructorForm()
        {
            InitializeComponent();
            MyLinkedList = new NodeList();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by txtFirstNumber for text changed events. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void txtFirstNumber_TextChanged(object sender, EventArgs e)
        {
            Question.ParseQuestion1(txtFirstNumber);
            Question.QuestionAnswer(cmboOperator, txtAnswer);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by txtSecondNumber for text changed events. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void txtSecondNumber_TextChanged(object sender, EventArgs e)
        {
            Question.ParseQuestion2(txtSecondNumber);
            Question.QuestionAnswer(cmboOperator, txtAnswer);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by Form1 for load events. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            cmboOperator.SelectedIndex = 0;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by btnSend for click events. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void btnSend_Click(object sender, EventArgs e)
        {
            InstructorConnection Package = new InstructorConnection(Question.instructorFirstNumber, Question.aOperator, Question.instructorSecondNumber,
                Question.instructorAnswer);

            Package.ConnectQuestion();

            List = new QuestionsArrayList(Question.instructorFirstNumber, Question.aOperator, Question.instructorSecondNumber, Question.equals,
                Question.instructorAnswer);

            List.GetArray(QuestionList);
            List.SetDataGrid(dataGridArray, QuestionList);
            List.GetHashTable(QuestionTable, QuestionList);

            BinaryTree.AddRecursive(Question.instructorAnswer);
            Root = BinaryTree.SetRoot(BinaryTree);

            Package.UpdateControlState(btnSend);
            Package.Return(MyLinkedList);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by btnExit for click events. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by btnSort1 for click events. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void btnSort1_Click(object sender, EventArgs e)
        {
            List.BubbleSort(QuestionList, dataGridArray);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by btnSort2 for click events. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void btnSort2_Click(object sender, EventArgs e)
        {
            List.InsertionSort(QuestionList, dataGridArray);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by btnSort3 for click events. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void btnSort3_Click(object sender, EventArgs e)
        {
            List.SelectionSort(QuestionList, dataGridArray);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by btnDisplayInOrder for click events. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void btnDisplayInOrder_Click(object sender, EventArgs e)
        {
            string treeToString = "IN-ORDER: ";

            BinaryTree.InOrder(Root);
            BinaryTree.DisplayTree(Root, ref treeToString);
            txtBinaryTree.Text = treeToString;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by btnDisplayPreOrder for click events. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void btnDisplayPreOrder_Click(object sender, EventArgs e)
        {
            string treeToString = "PRE-ORDER: ";

            BinaryTree.PreOrder(Root);
            BinaryTree.DisplayTree(Root, ref treeToString);
            txtBinaryTree.Text = treeToString;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by btnDisplayPostOrder for click events. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void btnDisplayPostOrder_Click(object sender, EventArgs e)
        {
            string treeToString = "POST-ORDER: ";

            BinaryTree.PostOrder(Root);
            BinaryTree.DisplayTree(Root, ref treeToString);
            txtBinaryTree.Text = treeToString;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by btnDisplayLinkList for click events. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void btnDisplayLinkList_Click(object sender, EventArgs e)
        {
            MyLinkedList.DisplayNodeList(MyLinkedList, txtLinkedList);
        }
    }
}
