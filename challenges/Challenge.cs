using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosAndDataStructures.challenges
{
    //class Challenge
    //{

    //public static int hourglassSum(List<List<int>> arr)
    //{
    //    foreach(var item in arr)
    //    {
    //        for(int i = 0; i < arr.Count; i++)
    //        {
    //            Console.WriteLine(i);
    //        }
    //    }

    //    return 0; 
    //}
    // Given an array of distinct integers 
    // Build array of same length
    // Where ans[i] = nums[nums[i]]

    //public int[] BuildArray(int[] nums)
    //{
    //    int[] ans = new int[nums.Length];

    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        ans[i] = nums[nums[i]];
    //    }

    //    return ans;
    //}

    //public static int GetLCM(List<int> integers)
    //{
    //    int lcm = 0;
    //    int maxInteger = integers.Max(); 

    //    for(int i = 0; i < integers.Count; i++)
    //    {
    //        bool isMultiple = true; 
    //        for(int j = i + 1; j < integers.Count; j++)
    //        {

    //        }
    //        if (isMultiple)
    //        {
    //            lcm = integers
    //        }
    //    }
    //    return lcm; 
    //}

    //    public static int migratoryBirds(List<int> sightings)
    //    {
    //        //each index is a bird type
    //        //what is the most frequently sighted bird? 
    //        //return the id of the most frequently sighted bird
    //        //if a more than one id has been spotted the same amount
    //        //return the smaller id

    //        sightings.Sort();
    //        //1, 1, 2, 2, 3, 3, 3, 4, 4, 4, 5            

    //        Dictionary<int, int> Counter = new Dictionary<int, int>();
    //        sightings.Sort();
    //        Console.WriteLine("list:");
    //        foreach(var sighting in sightings)
    //        {
    //            Console.Write(sighting + ", ");
    //        }

    //        int count = 1;
    //        int dupCount = 0; 
    //        for (int i = 0; i < sightings.Count; i++)
    //        {
    //            bool keyExists = Counter.ContainsKey(i);
    //            if(!keyExists)
    //            {
    //                Counter[sightings[i]] = count;
    //            }

    //            for (int j = i + 1; j < sightings.Count; j++)
    //            {

    //                if (sightings[i] == sightings[j])
    //                {                        
    //                    dupCount++;
    //                    Console.WriteLine("HIT " + dupCount);
    //                    Console.WriteLine(sightings[j]);
    //                    Counter[sightings[j]] = dupCount;                        
    //                }                    
    //            }
    //        };

    //        int id = Counter.OrderByDescending(x => x.Value).First().Key;
    //        return id; 

    //    }
    //};

    //public class Solution
    //{
    //    public int[] TwoSum(int[] nums, int target)
    //    {
    //        var secondIndex = 0;
    //        int[] solution = new int[2];
    //        for (var i = 0; i < nums.Length - 1; i++)
    //        {
    //            secondIndex = i + 1;
    //            if (nums[i] + nums[secondIndex] == target)
    //            {
    //                solution[0] = i;
    //                solution[1] = secondIndex;
    //            }
    //        }

    //        return solution;
    //    }
    //}

    ////public class Solution
    ////{
    ////    public int[] TwoSum(int[] nums, int target)
    ////    {            
    ////        int[] solution = new int[2];
    ////        var remainder = 0; 

    ////        for(var i = 0; i < nums.Length; i++)
    ////        {
    ////            remainder = target - nums[i];
    ////            for (var j = i + 1; j < nums.Length; j++)
    ////            {
    ////                if(remainder == nums[j])
    ////                {
    ////                    solution[0] = i; 
    ////                    solution[1] = j;
    ////                }
    ////            }
    ////        }

    ////        return solution;
    ////    }
    ////};
    //class Result
    //{
    //    public static string kangaroo(int x1, int v1, int x2, int v2)
    //    {

    //        if (v2 > v1)
    //        {
    //            return "NO";
    //        }

    //        if (x2 - x1 % v2 - v1 == 0)
    //        {
    //            return "YES";
    //        }

    //        return "NO";
    //    }

    //    public static int birthday(List<int> s, int d, int m)
    //    {
    //        // a sub-list of 's', of length 'm' must add up to 'd'

    //        int count = 0;

    //        // use GetRange with an incrementing initial index 'j'
    //        // of length 'm' to get sub-lists.
    //        // Sum up all indexes in each sub-list and check if 
    //        // each sublist minus 'd' equals 0. 
    //        // If so, increment count.  
    //        // Count is the total number of sub-Lists of length 'm'
    //        // from list 's' that equal 'd'

    //        for (int j = 0; j < s.Count - (m - 1); j++)
    //        {
    //            var newS = s.GetRange(j, m);

    //            int sum = 0;
    //            for (int i = 0; i < m; i++)
    //            {
    //                sum += newS[i];
    //            }

    //            if (sum - d == 0)
    //            {
    //                count++;
    //            }
    //        }

    //        return count;
    //    }

    //    public static int divisibleSumPairs(int n, int k, List<int> ar)
    //    {

    //        int result = 0;
    //        // loop through the array, adding index "i" to
    //        // index "j" next to it. 
    //        // If "k" divided by that sum has no remainder
    //        // increment the result. 
    //        for (int i = 0; i < n; i++)
    //        {
    //            for (int j = i + 1; j < n; j++)
    //            {
    //                if ((ar[i] + ar[j]) % k == 0)
    //                {
    //                    result++;
    //                }
    //            }
    //        }
    //        return result;
    //    }

    //    public static int getTotalX(List<int> a, List<int> b)
    //    {

    //        // every element in a has to be a factor of the integer
    //        // the integer has to be a factor of every element in b

    //        // first multiply all the elements in a
    //        // check if that number and every number from it to the smallest
    //        // in b are factors all of the elements in b

    //        int count = 0;
    //        try
    //        {
    //            int product = a[0];
    //            for (int i = 0; i < a.Count; i++)
    //            {
    //                for (int j = i + 1; j < a.Count; j++)
    //                {
    //                    product *= a[j];
    //                }
    //            };

    //            b.Sort();
    //            int sum = b.Sum();

    //            for (int i = product; i <= b[0]; i++)
    //            {
    //                if (sum % i == 0)
    //                {
    //                    count++;
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine(e);
    //        }

    //        return count; 
    //    }


    //};
    //}
}
