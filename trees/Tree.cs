using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosAndDataStructures.trees
{
    class Tree
    {

        public IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }

            List<int> result = new List<int>();

            List<int> helperMethod(TreeNode node, List<int> list)
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

                helperMethod(rootOriginal.left, listofNodes);
                listofNodes.Add(rootOriginal.val);
                helperMethod(rootOriginal.right, listofNodes);
            }
        }

        public IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();

            IList<int> helperMethod(TreeNode original, IList<int> toReturn)
            {
                if (original.left != null)
                {
                    helperMethod(original.left, toReturn);
                }

                if (original.right != null)
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
