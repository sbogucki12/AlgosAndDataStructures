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

        public IList<IList<int>> LevelOrderTraversal(TreeNode root)
        {
            List<IList<int>> result = new List<IList<int>>();

            if (root == null)
            {
                return result;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                List<int> currentLevel = new List<int>();
                for (var i = 0; i < size; i++)
                {
                    TreeNode currentNode = queue.Dequeue();
                    currentLevel.Add(currentNode.val);
                    if (currentNode.left != null)
                    {
                        queue.Enqueue(currentNode.left);
                    }
                    if (currentNode.right != null)
                    {

                        queue.Enqueue(currentNode.right);
                    }
                }

                result.Add(currentLevel);
            }

            return result;
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            };

            int leftCount = MaxDepth(root.left) + 1;
            int rightCount = MaxDepth(root.right) + 1;

            return Math.Max(leftCount, rightCount);
        }

        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            return IsSymmetric(root.left, root.right);

            bool IsSymmetric(TreeNode left, TreeNode right)
            {
                if (left == null || right == null)
                {
                    return left == right;
                };

                if (left.val != right.val)
                {
                    return false;
                };

                return IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
            }
        }

        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return false;
            };

            if (root.left == null && root.right == null)
            {
                if (targetSum - root.val == 0)
                {
                    return true;
                }

                return false;
            }
            else if (HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val))
            {
                return true;
            }

            return false;
        }

        public TreeNode BuildTreeInAndPost(int[] inorder, int[] postorder)
        {
            //inorder (left, root, right)
            //postorder (left, right, root)
            //return binary tree           
            // Input: inorder = [9,3,15,20,7], postorder = [9,15,7,20,3]

            //root = 3

            //int root = postorder[postorder.Length - 1];

            //everything left of three is left subtree
            //[9,3,15,20,7]
            //9 is left subtree

            //everything right of three is right subtree
            //[9,3,15,20,7]
            //15, 20, 7 is right subtree

            return helper(postorder, inorder, postorder.Length - 1, 0, inorder.Length - 1);

            TreeNode helper(int[] postOrder, int[] inOrder, int postIndex, int start, int end)
            {
                TreeNode root = null;

                if (postIndex >= 0)
                {
                    for (int i = start; i <= end; i++)
                    {
                        if (inOrder[i] == postOrder[postIndex])
                        {
                            root = new TreeNode(inOrder[i]);
                            root.right = helper(postOrder, inOrder, postIndex - 1, i + 1, end);
                            root.left = helper(postOrder, inOrder, postIndex - 2 - end + i + 1, start, i - 1);
                        }
                    }
                }

                return root;
            }

        }

        public TreeNode BuildTreePreAndIn(int[] preorder, int[] inorder)
        {
            //preorder array 
            //inorder array
            //constuct binary tree

            //pre = root, left, right
            //in = left, root, right
            /*Dictionary<int, int> inorderDictionary = new Dictionary<int, int>(); 
            for(int i = 0; i < inorder.Length; i++)
            {
                inorderDictionary.Add(inorder[i], i);
            }*/

            return helper(0, 0, inorder.Length - 1, preorder, inorder);

            TreeNode helper(int preorderRoot, int inorderStart, int inorderEnd, int[] preorder, int[] inorder)
            {
                if(preorderRoot > preorder.Length - 1 || inorderStart > inorderEnd)
                {
                    return null; 
                }

                TreeNode root = new TreeNode(preorder[preorderRoot]);

                int inorderIndex = 0; 
                for(int i = inorderStart; i <= inorderEnd; i++)
                {
                    if(root.val == inorder[i])
                    {
                        inorderIndex = i; 
                    }
                };                

                root.left = helper(preorderRoot + 1, inorderStart, inorderIndex - 1, preorder, inorder);
                root.right = helper(preorderRoot + inorderIndex - inorderStart + 1, inorderIndex + 1, inorderEnd, preorder, inorder);

                return root;
            }        
        }

        
    }
}
