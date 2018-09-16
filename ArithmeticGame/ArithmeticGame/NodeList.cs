using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
