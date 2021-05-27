using AlgosAndDataStructures.trees;
using System;
using System.Collections.Generic;

namespace AlgosAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode treeNode = new TreeNode(val: 1, left: new TreeNode(val: 5, new TreeNode(val: 5)), right: new TreeNode(val: 3, null, new TreeNode(val: 6)));

            Tree tree = new Tree();
            
            void printNodes(IList<int> nodes)
            {
                foreach (int val in nodes)
                {
                    if (val == nodes[nodes.Count - 1])
                    {
                        Console.WriteLine($"{val}");
                    }
                    else Console.Write($"{val}, ");
                };
            }

            void printNodesBFS(IList<IList<int>> nodes)
            {
                
                    foreach(List<int> list in nodes)
                    {
                        for(var j = 0; j < list.Count; j++)
                        {
                            if(list == nodes[nodes.Count - 1] && j == list.Count - 1)
                            {
                                Console.Write($"{list[j]}");
                            }
                            else Console.Write($"{list[j]}, ");
                        }
                    }
            }

            IList<int> treeNodesInOrder = tree.InorderTraversal(treeNode);

            IList<int> treeNodesPreOrder = tree.PreorderTraversal(treeNode);

            IList<int> treeNodesPostOrder = tree.PostorderTraversal(treeNode);

            IList<IList<int>> treeNodesBFS = tree.LevelOrderTraversal(treeNode);

            printNodes(treeNodesInOrder);
            printNodes(treeNodesPreOrder);
            printNodes(treeNodesPostOrder);
            printNodesBFS(treeNodesBFS);
        }
    }
}
