using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosAndDataStructures.trees
{
    class TreeInOrder
    {

        //Given the root of a binary tree, return the inoder traversal of its nodes' values
        //Inorder: 1. Traverse left subtree. 2. Visit root. 3. Traverse right subtree. 
        int counter = 0;
        int rightCounter = 0;

        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();

            if (root == null)
            {
                return result;
            }
            
            helperMethod(root, result);
            return result;
            
            void helperMethod(TreeNode rootOriginal, List<int> listofNodes)
            {
                if (rootOriginal == null)
                {                   
                    return;
                };

                if (rootOriginal.left != null)
                {
                    counter++;
                    Console.WriteLine("Left: {0} {1}", counter, rootOriginal.left.val);
                };

                if(rootOriginal.right != null)
                {
                    rightCounter++;
                    Console.WriteLine("Right: {0} {1}", rightCounter, rootOriginal.right.val);
                }

                helperMethod(rootOriginal.left, listofNodes);
                listofNodes.Add(rootOriginal.val);
                helperMethod(rootOriginal.right, listofNodes);
            }
        }
    }
}
