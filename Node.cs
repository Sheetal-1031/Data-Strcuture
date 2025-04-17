using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    internal class Node
    {
        public Customer data;
        public Node left, right;

        public Node(Customer value)
        {
            data = value;
            left = right = null;
        }
    }
}
