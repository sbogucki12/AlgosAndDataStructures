using AlgosAndDataStructures.challenges;
using AlgosAndDataStructures.challenges.InterviewCake;
using AlgosAndDataStructures.classes;
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

            //static int[] GetAsciiConverterInput()
            //{
            //    int[] result = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };


            //    Console.Write("Enter Binary: ");
            //    var read = Console.ReadLine();
            //    int i = 0; 
            //    foreach(var bit in read)
            //    {
            //        result[i] = bit;
            //        i++; 
            //    };

            //    return result;
            //}


            //int[] AsciiConverterInput = GetAsciiConverterInput();
            ////int[] multiplyExponentiallyInput = GetMultiplyExponentiallyInput();

            //var AsciiConverterResult = AsciiConverter(AsciiConverterInput);
            ////var multiplyExponentiallyResult = MultiplyExponentially(multiplyExponentiallyInput[0], multiplyExponentiallyInput[1]);

            ////Console.WriteLine($"result: {multiplyExponentiallyResult}");
            //Console.WriteLine($"result: {AsciiConverterResult}");
            //Console.ReadKey();

            //static int AsciiConverter(int[] binary)
            //{
            //    binary[6] *= 2;
            //    binary[5] *= 4;
            //    binary[4] *= 8;
            //    binary[3] *= 16;
            //    binary[2] *= 32;
            //    binary[1] *= 64;
            //    binary[0] *= 256;

            //    int result = 0; 

            //    foreach(var bit in binary)
            //    {
            //        result += bit;
            //    }

            //    return result; 

            //}
            //foreach (char c in a)
            //{
            //    Console.WriteLine(c);
            //}

            //Console.ReadLine();         
            //char[] message = { 'c', 'a', 'k', 'e', ' ',
            //       'p', 'o', 'u', 'n', 'd', ' ',
            //       's', 't', 'e', 'a', 'l'};

            //char[] message = new char[] { 't', 'h', 'e', ' ', 'e', 'a', 'g', 'l', 'e', ' ', 'h', 'a', 's', ' ', 'l', 'a', 'n', 'd', 'e', 'd' };
            //var results = Solution.ReverseWords(message);
            //foreach(char result in results)
            //{
            //    Console.WriteLine(result);
            //}
            ////Console.WriteLine(results);
            //Console.ReadKey();

            //int target = 9; 
            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //Console.WriteLine("Enter target:  ");
            //if (!int.TryParse(Console.ReadLine(), out int target))
            //{
            //    Console.WriteLine("Invalid value entered");
            //    return;
            //}
            //else
            //{
            //    Console.WriteLine("You entered {0}", target);
            //}

            //var result = Solution.BinarySearch(target, numbers);
            //string isOrIsNot = "is";
            //if(!result.IsInList)
            //{
            //    isOrIsNot = "is not";
            //}

            //Console.ReadKey();
            //Console.WriteLine($"{target} {isOrIsNot} in the list! It took {result.Count} tries to determine this.");
            //Console.ReadKey();

            //int[] myArray = { 3, 4, 6, 10, 11, 15 };
            //int[] alicesArray = { 1, 5, 8, 12, 14, 19 };

            //Console.WriteLine($"[{string.Join(", ", Solution.MergeArrays(myArray, alicesArray))}]");
            //Console.ReadKey();
            //int[] takeoutOrders = { 1, 3, 5 };
            //int[] dineinOrders = { 2, 4, 6 };
            //int[] servedOrdersTrue = { 1, 2, 4, 6, 3, 5 };
            //int[] servedOrdersFalse = { 5, 2, 6, 4, 3, 1 };



            //var result = Solution.IsFirstComeFirstServed(takeoutOrders, dineinOrders, servedOrdersFalse);
            //Console.WriteLine("Are the orders being served correctly?");
            //Console.WriteLine(result);
            //Console.ReadKey();

            //int[] stockPrices = { 10, 7, 5, 8, 11, 9 };
            //int maxProfit;
            //try                
            //{
            //    maxProfit = Solution.GetMaxProfit(stockPrices);
            //    Console.WriteLine($"The maximum profit you could have made is {maxProfit}");
            //    Console.ReadLine();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("There was an error: " + ex.Message);
            //    Console.ReadLine();
            //}

            Console.WriteLine("Please enter 5 single digit integers.");
            

            int userNumber0 = int.Parse(Console.ReadLine());
            int userNumber1 = int.Parse(Console.ReadLine()); 
            int userNumber2 = int.Parse(Console.ReadLine());
            int userNumber3 = int.Parse(Console.ReadLine()); 
            int userNumber4 = int.Parse(Console.ReadLine()); 

            int[] userArray = new int[5] { userNumber0, userNumber1, userNumber2, userNumber3, userNumber4 };

            
            Console.WriteLine($"{userNumber0}, {userNumber1}, {userNumber2}, {userNumber3}, {userNumber4}");
            Console.ReadKey();

            Console.WriteLine("Calculating...");
            int highestProduct = Solution.GetHighestProduct(userArray);
            Console.WriteLine($"The highest product that you can get from these numbers is: {highestProduct}");
            Console.ReadKey();






        }
    }
}
