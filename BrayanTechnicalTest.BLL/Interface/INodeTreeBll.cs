using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrayanTechnicalTest.ENT.DTO;

namespace BrayanTechnicalTest.BLL.Interface
{
    public interface INodeTreeBll
    {
        void Insert(int Data);

        DTOTree Create(int[] Data);
        int ClosestCommonAncestor(int a, int b);
        int ClosestCommonAncestor(DTOTree searchTree, int a, int b);

        void print();
    }
}
