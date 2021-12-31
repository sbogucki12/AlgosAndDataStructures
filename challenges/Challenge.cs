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
    }
}
