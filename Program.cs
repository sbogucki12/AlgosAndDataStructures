using AlgosAndDataStructures.trees;
using System;
using System.Collections.Generic;

namespace AlgosAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeInOrder treeInOrder = new TreeInOrder();

            IList<int> inOrderTraversal = treeInOrder.InorderTraversal(new TreeNode(val: 1, left: new TreeNode(val: 5, new TreeNode(val: 5)), right: new TreeNode(val: 3, null, new TreeNode(val: 6))));

            for (var i = 0; i < inOrderTraversal.Count; i++)
            {
                //should be 5, 5, 1, 3, 6
                Console.Write("{0}, ", inOrderTraversal[i]);
            }
            
        }
    }
}
