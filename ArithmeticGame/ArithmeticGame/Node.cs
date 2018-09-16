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

        public Node(int myvalue)
        {
            value = myvalue;
            left = null;
            right = null;
        }
    }
}
