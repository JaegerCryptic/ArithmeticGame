using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticGame
{
    class Tree
    {
        public Node top;

        public Tree()
        {
            top = null;
        }

        public Tree(int myValue)
        {
            top = new Node(myValue);
        }

        public void Add(int myValue)
        {
            if(top == null)
            {
                top = new Node(myValue);
                return;
            }
            Node currentNode = top;
            bool inserted = false;
            do
            {
                if (myValue < currentNode.value)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = new Node(myValue);
                        inserted = true;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                    if (myValue >= currentNode.value)
                    {
                        if (currentNode.right == null)
                        {
                            currentNode.right = new Node(myValue);
                            inserted = true;
                        }
                        else
                        {
                            currentNode = currentNode.right;
                        }
                    }
                }
            } while (!inserted);
        }

        public void AddRecursive(int myValue)
        {
            Addrc(ref top, myValue);
        }

        private void Addrc(ref Node node, int myValue)
        {
            if(node == null)
            {
                node = new Node(myValue);

                return;
            }
            if(myValue < node.value)
            {

            }
        }

    }
}
