using BrayanTechnicalTest.BLL.Interface;
using BrayanTechnicalTest.ENT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrayanTechnicalTest.BLL.Implementation
{
    public class NodeTreeBll : INodeTreeBll
    {
        private DTOTree _root;
        public NodeTreeBll()
        {
            _root = null;
        }
        public int ClosestCommonAncestor(int a, int b)
        {
           return ClosestCommonAncestor(_root, a, b);
        }

        public int ClosestCommonAncestor(DTOTree searchTree, int a, int b)
        {
            if (searchTree == null)
            {
                return -1;
            }
            if (searchTree.data.CompareTo(a) > 0 && searchTree.data.CompareTo(b) > 0)
            {
                return ClosestCommonAncestor(searchTree.Left, a, b);
            }
            if (searchTree.data.CompareTo(a) < 0 && searchTree.data.CompareTo(b) < 0)
            {
                return ClosestCommonAncestor(searchTree.Right, a, b);
            }
            return searchTree.data;
        }

        public DTOTree Create(int[] Data)
        {
            foreach (var item in Data)
            {
                Insert(item);
            }
            return _root;
        }

        public void Insert(int data)
        {
            if (_root == null)
            {
                _root = new DTOTree(data);
                return;
            }
            InsertRec(_root, new DTOTree(data));
            //throw new NotImplementedException();
        }

        private void InsertRec(DTOTree root, DTOTree newNode)
        {
            if (root == null)
                root = newNode;

            if (newNode.data < root.data)
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                    InsertRec(root.Left, newNode);

            }
            else
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    InsertRec(root.Right, newNode);
            }
        }


        public void print()
        {
            print(_root, "\n");
        }

        private void print(DTOTree root, String prefix)
        {
            if (root == null)
            {
                Console.Write(prefix + "+- <null>");
                return;
            }

            Console.Write(prefix + "+- " + root.data);
            print(root.Left, prefix + "|  ");
            print(root.Right, prefix + "|  ");
        }
    }
}
