///-------------------------------------------------------------------------------------------------
// file:	Node.cs
//
// summary:	Implements the node class
///-------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticGame
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A node. </summary>
    ///
    /// <remarks>   Jaege, 17/09/2018. </remarks>
    ///-------------------------------------------------------------------------------------------------

    class Node
    {
        /// <summary>   The value. </summary>
        public int value;
        /// <summary>   The left. </summary>
        public Node left;
        /// <summary>   The right. </summary>
        public Node right;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets the next. </summary>
        ///
        /// <value> The next. </value>
        ///-------------------------------------------------------------------------------------------------

        Node previous, next;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="myvalue">  The myvalue. </param>
        ///-------------------------------------------------------------------------------------------------

        public Node(int myvalue)
        {
            value = myvalue;
            left = null;
            right = null;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets my value. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <returns>   my value. </returns>
        ///-------------------------------------------------------------------------------------------------

        public int GetMyValue()
        {
            return this.value;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Sets my value. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="myValue">  my value. </param>
        ///-------------------------------------------------------------------------------------------------

        public void SetMyValue(int myValue)
        {
            value = myValue;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Sets a next. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="aNode">    The node. </param>
        ///-------------------------------------------------------------------------------------------------

        public void SetNext(Node aNode)
        {
            this.next = aNode;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets the next item. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <returns>   The next. </returns>
        ///-------------------------------------------------------------------------------------------------

        public Node GetNext()
        {
            return this.next;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Sets the previous. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="aNode">    The node. </param>
        ///-------------------------------------------------------------------------------------------------

        public void SetPrevious(Node aNode)
        {
            this.previous = aNode;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets the previous item. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <returns>   The previous. </returns>
        ///-------------------------------------------------------------------------------------------------

        public Node GetPrevious()
        {
            return this.previous;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Convert this object into a string representation. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <returns>   A string that represents this object. </returns>
        ///-------------------------------------------------------------------------------------------------

        public string ToString()
        {
            return value.ToString();
        }

    }
}
