using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            Console.WriteLine(IsValidBST(n2));

            Console.ReadLine();
        }

        public static bool IsValidBST(Node root)
        {
            return Check(root, new Stack<Node>());
        }

        static bool Check(Node node, Stack<Node> stack)
        {
            if (node == null)
                return true;

            if (Check(node.Left, stack) && (stack.Count == 0 || node.Value > stack.Peek().Value))
                stack.Push(node);
            else
                return false;

            return Check(node.Right, stack);
        }
    }
}
