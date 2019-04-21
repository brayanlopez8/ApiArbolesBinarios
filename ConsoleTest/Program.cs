using BrayanTechnicalTest.BLL.Implementation;
using BrayanTechnicalTest.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            INodeTreeBll Test = new NodeTreeBll();
            Test.Create(arr);
            Test.print();
            Console.WriteLine("");
            Console.WriteLine(Test.ClosestCommonAncestor(40, 78));
            Console.WriteLine(Test.ClosestCommonAncestor(51, 37));
            Console.WriteLine(Test.ClosestCommonAncestor(76, 85));

            Console.ReadLine();
        }
    }
}
