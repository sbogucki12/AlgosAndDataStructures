using AlgosAndDataStructures.challenges;
using AlgosAndDataStructures.challenges.InterviewCake;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlgosAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //TreeNode treeNode = new TreeNode(val: 1, left: new TreeNode(val: 2, new TreeNode(val: 3)), right: new TreeNode(val: 2, null, new TreeNode(val: 3)));

            //Tree tree = new Tree();

            //void printNodes(IList<int> nodes)
            //{
            //    foreach (int val in nodes)
            //    {
            //        if (val == nodes[nodes.Count - 1])
            //        {
            //            Console.WriteLine($"{val}");
            //        }
            //        else Console.Write($"{val}, ");
            //    };
            //}

            //void printNodesBFS(IList<IList<int>> nodes)
            //{

            //        foreach(List<int> list in nodes)
            //        {
            //            for(var j = 0; j < list.Count; j++)
            //            {
            //                if(list == nodes[nodes.Count - 1] && j == list.Count - 1)
            //                {
            //                    Console.Write($"{list[j]}");
            //                }
            //                else Console.Write($"{list[j]}, ");
            //            }
            //        }
            //}

            //void printMaxDepth(TreeNode node)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(tree.MaxDepth(node));
            //}                


            //IList<int> treeNodesInOrder = tree.InorderTraversal(treeNode);

            //IList<int> treeNodesPreOrder = tree.PreorderTraversal(treeNode);

            //IList<int> treeNodesPostOrder = tree.PostorderTraversal(treeNode);

            //IList<IList<int>> treeNodesBFS = tree.LevelOrderTraversal(treeNode);

            //printNodes(treeNodesInOrder);
            //printNodes(treeNodesPreOrder);
            //printNodes(treeNodesPostOrder);
            //printNodesBFS(treeNodesBFS);
            //printMaxDepth(treeNode);
            //Console.WriteLine($"Is the tree symmetric? {tree.IsSymmetric(treeNode)}");
            //bool result = tree.HasPathSum(treeNode, 6);
            //Console.WriteLine($"Is 6 a valid path sum? {result}");

            //List<int> integers = new List<int> { 2, 3 }; 
            //int result = challenges.Challenge.GetLCM(integers);
            //Console.WriteLine($"The LCM of {string.Join(", ", integers)} is {result}");
            //Console.ReadKey(); 

            //List<int> birdSightings = new List<int>() { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };
            //int result = Challenge.migratoryBirds(birdSightings);           


            ////Console.WriteLine(String.Join(", ", birdSightings));

            //Console.WriteLine($"The most sighted bird of {string.Join(", ", birdSightings)} is {result}"); 
            //Console.ReadLine();
            //var meetings = new List<Meeting> { new Meeting(0, 1), new Meeting(3, 5), new Meeting(4, 8), new Meeting(10, 12), new Meeting(9, 10) };
            //var meetings = new List<Meeting> { new Meeting(0, 1), new Meeting(3, 5), new Meeting(4, 8), new Meeting(10, 12), new Meeting(9, 10) };
            //meetings.Sort((x, y) => x.StartTime.CompareTo(y.StartTime));
            //foreach(var meeting in meetings)
            //{
            //    Console.WriteLine(meeting);
            //}
            //Console.ReadLine();

            //var lowestMeeting = Solution.ShowMin(meetings);
            //var highestMeeting = Solution.ShowMax(meetings);
            //var mergedRanges = Solution.MergeRanges(meetings);
            //foreach (var meeting in mergedRanges)
            //{
            //    Console.WriteLine(meeting);
            //}
            //Console.ReadLine();

            //static char[] ReverseString(char[] stringToReverse)
            //{
            //    int leftIndex = 0; 
            //    int rightIndex = stringToReverse.Length - 1;

            //    while(leftIndex < rightIndex)
            //    {
            //        char temp = stringToReverse[leftIndex];
            //        stringToReverse[leftIndex] = stringToReverse[rightIndex];
            //        stringToReverse[rightIndex] = temp;
            //        leftIndex++;
            //        rightIndex--;
            //    }
                
            //    return stringToReverse;
            //}

            //var a = new char[] { 't', 'g', 'h', 't', 'f', 'v', 'q' };
            //ReverseString(a);

            //static int MultiplyExponentially(int baseNumber, int exponent)
            //{
            //    int i = 0;
            //    int originalBase = baseNumber;
            //    while(i < exponent - 1)
            //    {
            //        baseNumber *= originalBase;
            //        i++;
            //    }

            //    return baseNumber;
            //}
            
            //static int[] GetMultiplyExponentiallyInput()
            //{
            //    int[] result = new int[] { 0, 0 };

            //    Console.Write("Enter Base: ");
            //    var baseNumberString = Console.ReadLine();
            //    if (int.TryParse(baseNumberString, out int baseNumberInt))
            //    {
            //        result[0] = baseNumberInt;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{baseNumberString} is not a number");
            //    }
            //    Console.Write("Enter exponent: ");
            //    var exponentString = Console.ReadLine();
            //    if (int.TryParse(exponentString, out int exponentInt))
            //    {
            //        result[1] = exponentInt;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{exponentString} is not a number");
            //    }                

            //    return result; 
            //}

            static int[] GetAsciiConverterInput()
            {
                int[] result = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };

                Console.Write("Enter Binary: ");
                var binary = Console.ReadLine();
                for(int i = 0; i < binary.Length; i++)
                {
                    result[i] = binary[i];
                }

                return result;
            }


            int[] AsciiConverterInput = GetAsciiConverterInput();
            //int[] multiplyExponentiallyInput = GetMultiplyExponentiallyInput();

            var AsciiConverterResult = AsciiConverter(AsciiConverterInput);
            //var multiplyExponentiallyResult = MultiplyExponentially(multiplyExponentiallyInput[0], multiplyExponentiallyInput[1]);

            //Console.WriteLine($"result: {multiplyExponentiallyResult}");
            Console.WriteLine($"result: {AsciiConverterResult}");
            Console.ReadKey();

            static int AsciiConverter(int[] binary)
            {
                binary[6] *= 2;
                binary[5] *= 4;
                binary[4] *= 8;
                binary[3] *= 16;
                binary[2] *= 32;
                binary[1] *= 64;
                binary[0] *= 256;

                int result = 0; 

                foreach(var bit in binary)
                {
                    result += bit;
                }

                return result; 
                
            }
            //foreach (char c in a)
            //{
            //    Console.WriteLine(c);
            //}

            //Console.ReadLine();         



        }
    }
}
