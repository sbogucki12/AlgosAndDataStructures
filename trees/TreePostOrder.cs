using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosAndDataStructures.trees
{
    class TreePostOrder
    {
        // 1. Traverse the left subtree.
        // 2. Traverse the right subtree.
        // 3. Visit root. 

        public IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>(); 
            
            IList<int> helperMethod(TreeNode original, IList<int> toReturn)
            {              
                if(original.left != null)
                {                    
                    helperMethod(original.left, toReturn);
                }

                if(original.right != null)
                {                    
                    helperMethod(original.right, toReturn);
                }

                toReturn.Add(original.val);

                return toReturn;
            }
            return helperMethod(root, result);  
        }
    }
}
