using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticGame
{
    class NodeList
    {
        private Node CurrentNode = null, HeadNode = null, TailNode = null;
        static int count = 0;

        public NodeList()
        {

        }

        public NodeList(Node aNode)
        {
            HeadNode = aNode;
            CurrentNode = aNode;
            TailNode = aNode;
            count++;
        }

        public Node GetCurrentNode() { return CurrentNode; }
        public Node GetHeadNode() { return HeadNode; }
        public Node GetTailNode() { return TailNode; }
        public void SetCurrentNode(Node aNode) { CurrentNode = aNode; }
        public void SetHeadNode(Node aNode) { HeadNode = aNode; }
        public void SetTailNode(Node aNode) { TailNode = aNode; }

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
