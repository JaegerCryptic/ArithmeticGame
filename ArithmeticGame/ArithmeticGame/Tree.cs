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
                Addrc(ref node.left, myValue);
            }
            if(myValue >= node.value)
            {
                Addrc(ref node.right, myValue);
            }
        }

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

        public void PreOrder(Node root)
        {
            if (root != null)
            {
                PreOrder(root.left);
                PreOrder(root.right);
            }
        }

        public void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.left);
                InOrder(root.right);
            }
        }

        public void PostOrder(Node root)
        {
            if (root != null)
            {
                PostOrder(root.left);
                PostOrder(root.right);
            }
        }

        public Node SetRoot(Tree tree)
        {
            Node root = tree.top;
            return root;
        }

    }
}
