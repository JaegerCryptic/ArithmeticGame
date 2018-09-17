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
// file:	NodeList.cs
//
// summary:	Implements the node list class
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
    /// <summary>   List of nodes. </summary>
    ///
    /// <remarks>   Jaege, 17/09/2018. </remarks>
    ///-------------------------------------------------------------------------------------------------

    class NodeList
    {
        /// <summary>   The tail node. </summary>
        private Node CurrentNode = null, HeadNode = null, TailNode = null;
        /// <summary>   Number of. </summary>
        static int count = 0;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///-------------------------------------------------------------------------------------------------

        public NodeList()
        {

        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="aNode">    The node. </param>
        ///-------------------------------------------------------------------------------------------------

        public NodeList(Node aNode)
        {
            HeadNode = aNode;
            CurrentNode = aNode;
            TailNode = aNode;
            count++;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets current node. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <returns>   The current node. </returns>
        ///-------------------------------------------------------------------------------------------------

        public Node GetCurrentNode() { return CurrentNode; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets head node. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <returns>   The head node. </returns>
        ///-------------------------------------------------------------------------------------------------

        public Node GetHeadNode() { return HeadNode; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets tail node. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <returns>   The tail node. </returns>
        ///-------------------------------------------------------------------------------------------------

        public Node GetTailNode() { return TailNode; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Sets current node. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="aNode">    The node. </param>
        ///-------------------------------------------------------------------------------------------------

        public void SetCurrentNode(Node aNode) { CurrentNode = aNode; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Sets head node. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="aNode">    The node. </param>
        ///-------------------------------------------------------------------------------------------------

        public void SetHeadNode(Node aNode) { HeadNode = aNode; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Sets tail node. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="aNode">    The node. </param>
        ///-------------------------------------------------------------------------------------------------

        public void SetTailNode(Node aNode) { TailNode = aNode; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Node list addat front. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="aNode">    The node. </param>
        ///-------------------------------------------------------------------------------------------------

        public void NodeListAddatFront(Node aNode)
        {
            if((HeadNode == null)&&(CurrentNode == null)&& (TailNode == null))
            {
                HeadNode = aNode;
                CurrentNode = aNode;
                TailNode = aNode;
                count++;
            }
            else
            {
                CurrentNode = aNode;
                HeadNode.SetPrevious(aNode);
                CurrentNode.SetNext(HeadNode);
                SetHeadNode(CurrentNode);
                count++;
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Displays a node list. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="list"> The list. </param>
        /// <param name="txt">  The text. </param>
        ///-------------------------------------------------------------------------------------------------

        public void DisplayNodeList(NodeList list, TextBox txt)
        {
            if (list.GetCurrentNode() != null)
            {
                txt.Clear();
                txt.Text = list.GetCurrentNode().GetMyValue().ToString();
            }
            else
            {
                txt.Clear();
                txt.Text = "Failed";
            }

            if (list.GetCurrentNode().GetPrevious() != null)
            {
                txt.Clear();
                txt.Text += list.GetCurrentNode().
                                       GetPrevious().GetMyValue().ToString();
            }
            else
            {
                txt.Clear();
            }
            if (list.GetCurrentNode().GetNext() != null)
            {
                txt.Clear();
                txt.Text += list.GetCurrentNode().
                                    GetNext().GetMyValue().ToString();
            }
            else
            {
                txt.Clear();
            }
        }

    }
}
