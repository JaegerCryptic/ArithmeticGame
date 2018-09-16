using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticGame
{
    class Node
    {
        public int value;
        public Node left;
        public Node right;
        Node previous, next;

        public Node(int myvalue)
        {
            value = myvalue;
            left = null;
            right = null;
        }

        public int GetMyValue()
        {
            return this.value;
        }

        public void SetMyValue(int myValue)
        {
            value = myValue;
        }

        public void SetNext(Node aNode)
        {
            this.next = aNode;
        }

        public Node GetNext()
        {
            return this.next;
        }

        public void SetPrevious(Node aNode)
        {
            this.previous = aNode;
        }

        public Node GetPrevious()
        {
            return this.previous;
        }

        public string ToString()
        {
            return value.ToString();
        }

    }
}
