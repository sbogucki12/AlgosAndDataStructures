using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosAndDataStructures.challenges
{
    class Challenge
    {
        // Given an array of distinct integers 
        // Build array of same length
        // Where ans[i] = nums[nums[i]]
        public int[] BuildArray(int[] nums)
        {
            int[] ans = new int[nums.Length];

            for(int i = 0; i < nums.Length; i ++)
            {
                ans[i] = nums[nums[i]];
            }

            return ans;
        }        
    };

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var secondIndex = 0;
            int[] solution = new int[2];
            for (var i = 0; i < nums.Length - 1; i++)
            {
                secondIndex = i + 1;
                if (nums[i] + nums[secondIndex] == target)
                {
                    solution[0] = i;
                    solution[1] = secondIndex;
                }
            }

            return solution;
        }
    }

    //public class Solution
    //{
    //    public int[] TwoSum(int[] nums, int target)
    //    {            
    //        int[] solution = new int[2];
    //        var remainder = 0; 

    //        for(var i = 0; i < nums.Length; i++)
    //        {
    //            remainder = target - nums[i];
    //            for (var j = i + 1; j < nums.Length; j++)
    //            {
    //                if(remainder == nums[j])
    //                {
    //                    solution[0] = i; 
    //                    solution[1] = j;
    //                }
    //            }
    //        }

    //        return solution;
    //    }
    //};
    class Result
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            
            if(v2 > v1)
            {
                return "NO";
            }

            if(x2 - x1 % v2 - v1 == 0)
            {
                return "YES";
            }

            return "NO";
        }
    };
}
