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
// file:	Tree.cs
//
// summary:	Implements the tree class
///-------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticGame
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A tree. </summary>
    ///
    /// <remarks>   Jaege, 17/09/2018. </remarks>
    ///-------------------------------------------------------------------------------------------------

    class Tree
    {
        /// <summary>   The top. </summary>
        public Node top;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///-------------------------------------------------------------------------------------------------

        public Tree()
        {
            top = null;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="myValue">  my value. </param>
        ///-------------------------------------------------------------------------------------------------

        public Tree(int myValue)
        {
            top = new Node(myValue);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Adds a recursive. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="myValue">  my value. </param>
        ///-------------------------------------------------------------------------------------------------

        public void AddRecursive(int myValue)
        {
            Addrc(ref top, myValue);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Addrcs. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="node">     [in,out] The node. </param>
        /// <param name="myValue">  my value. </param>
        ///-------------------------------------------------------------------------------------------------

        private void Addrc(ref Node node, int myValue)
        {
            if(node == null)
            {
                node = new Node(myValue);

                return;
            }
            if(myValue < node.value)
            {
                Addrc(ref node.left, myValue);
            }
            if(myValue >= node.value)
            {
                Addrc(ref node.right, myValue);
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Searches for the first node by value. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="node">     The node. </param>
        /// <param name="myValue">  my value. </param>
        ///
        /// <returns>   The found node by value. </returns>
        ///-------------------------------------------------------------------------------------------------

        public Node findNodeByValue(Node node, int myValue)
        {

            if (node == null)
            {
                return null;
            }
            if (node.value == myValue)
            {
                return node;
            }
            if (node.value > myValue) return findNodeByValue(node.left, myValue);
            return findNodeByValue(node.right, myValue);

        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Displays a tree. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="node">     The node. </param>
        /// <param name="myString"> [in,out] my string. </param>
        ///-------------------------------------------------------------------------------------------------

        public void DisplayTree(Node node, ref string myString)
        {
            if (node == null)
            {
                node = top;
            }
            if (node.left != null)
            {
                DisplayTree(node.left, ref myString);
                myString += node.value.ToString().PadLeft(3);
            }
            else
            {
                myString += node.value.ToString().PadLeft(3);
            }
            if (node.right != null)
            {
                DisplayTree(node.right, ref myString);
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Pre order. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="root"> The root. </param>
        ///-------------------------------------------------------------------------------------------------

        public void PreOrder(Node root)
        {
            if (root != null)
            {
                PreOrder(root.left);
                PreOrder(root.right);
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   In order. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="root"> The root. </param>
        ///-------------------------------------------------------------------------------------------------

        public void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.left);
                InOrder(root.right);
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Posts an order. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="root"> The root. </param>
        ///-------------------------------------------------------------------------------------------------

        public void PostOrder(Node root)
        {
            if (root != null)
            {
                PostOrder(root.left);
                PostOrder(root.right);
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Sets a root. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="tree"> The tree. </param>
        ///
        /// <returns>   A Node. </returns>
        ///-------------------------------------------------------------------------------------------------

        public Node SetRoot(Tree tree)
        {
            Node root = tree.top;
            return root;
        }

    }
}
