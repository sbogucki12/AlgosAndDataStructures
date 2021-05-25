using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosAndDataStructures.trees
{
    // Directions: 

    // Given the root of a binary tree, return the preorder traversal of its nodes' values.

    // Pre-order: 1. Visit root. 2. Traverse left subtree. 3. Traverse right subtree. 
    public class PreOrderTree
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            if(root == null)
            {
                return new List<int>(); 
            }

            List<int> result = new List<int>();
            
            static List<int> helperMethod(TreeNode node, List<int> list)
            {
                //this initialy adds root val to result
                //on each recursive call, it adds root val to result
                list.Add(node.val);                

                if (node.left != null)
                {                     
                    helperMethod(node.left, list);
                }                
               
                if (node.right != null)
                {
                    helperMethod(node.right, list);
                }               

                return list;
            }

            return helperMethod(root, result);
        }
    }
}
