using AlgosAndDataStructures.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosAndDataStructures.challenges.InterviewCake
{
    internal class Solution
    {
        //public static List<Meeting> MergeRanges(List<Meeting> meetings)
        //{
        //    var sortedMeetings = meetings.Select(m => new Meeting(m.StartTime, m.EndTime))
        //        .OrderBy(m => m.StartTime).ToList();
        //    var mergedMeetings = new List<Meeting> { sortedMeetings[0] };
        //    foreach (var currentMeeting in sortedMeetings)
        //    {
        //        var lastMergedMeeting = mergedMeetings.Last();

        //        if (currentMeeting.StartTime <= lastMergedMeeting.EndTime)
        //        {
        //            // If the current meeting overlaps with the last merged meeting, use the
        //            // later end time of the two
        //            lastMergedMeeting.EndTime =
        //                Math.Max(lastMergedMeeting.EndTime, currentMeeting.EndTime);
        //        }

        //        else
        //        {
        //            // Add the current meeting since it doesn't overlap
        //            mergedMeetings.Add(currentMeeting);
        //        }

        //    }
        //    return mergedMeetings;

        //}

        //public static int ShowMin(List<Meeting> meetings)
        //{
        //    List<int> newMeetingList = new List<int>();
        //    foreach(var meeting in meetings)
        //    {
        //        newMeetingList.Add(meeting.StartTime);
        //        newMeetingList.Add(meeting.EndTime);
        //    }

        //    newMeetingList.Sort();

        //    return (newMeetingList[0]);
        //}

        //public static int ShowMax(List<Meeting> meetings)
        //{
        //    List<int> newMeetingList = new List<int>();
        //    foreach (var meeting in meetings)
        //    {
        //        newMeetingList.Add(meeting.StartTime);
        //        newMeetingList.Add(meeting.EndTime);
        //    }

        //    newMeetingList.Sort();

        //    return (newMeetingList[newMeetingList.Count - 1]);
        //}

        //public static char[] ReverseWords(char[] message)
        //{

        //    //char[] into string[]
        //    //all the chars until 21 == string
        //    //StringBuilder word = new StringBuilder(); 
        //    //List<string> newMessage = new List<string>();
        //    //int j = 0;
        //    //for (int i = 0; i < 3; i++)
        //    //{

        //    //    while(message[j] != 32)
        //    //    {
        //    //        word.Append(message[j]);
        //    //        j++;
        //    //    }

        //    //    newMessage.Add(word.ToString());
        //    //}


        //    int leftIndex = 0;
        //    int rightIndex = message.Length - 1;
        //    List<int> indexesOfEmptyQuotes = new List<int>();
        //    for (int i = 0; i < message.Length; i++)
        //    {
        //        if (message[i] == 32)
        //        {
        //            indexesOfEmptyQuotes.Add(i);
        //        }
        //    }

        //    ////this is unnecessary.  I'm just trying something
        //    //List<string> charsIntoStrings = new List<string>();
        //    //int counter = 0; 

        //    //for(int i = 0; i < message.Length; i++)
        //    //{
        //    //    int index = indexesOfEmptyQuotes[counter];
        //    //    StringBuilder temp = new StringBuilder();
        //    //    while(i != index)
        //    //    {
        //    //        temp.Append(message[i]);
        //    //        i++;
        //    //        counter++;
        //    //    }

        //    //    charsIntoStrings.Add(temp.ToString());

        //    //}



        //    // first word is all chars until indexesOfEmptyQuotes[0]
        //    // second word is all chars until indexesOfEmptyQuotes[1]

        //    while (leftIndex < rightIndex)
        //    {
        //        char temp = message[leftIndex];
        //        message[leftIndex] = message[rightIndex];
        //        message[rightIndex] = temp;
        //        leftIndex++;
        //        rightIndex--;
        //    }

        //    return message; 
        //}

        //public static BinarySearchResult BinarySearch(int target, int[] nums)
        //{
        //    // See if target appears in nums
        //    // count is number of iterations through the int[] 
        //    // return true if target appears in nums, and count
        //    // return false if target does not appear in nums,and count

        //    // We think of floorIndex and ceilingIndex as "walls" around
        //    // the possible positions of our target so by -1 below we mean
        //    // to start our wall "to the left" of the 0th index
        //    // (we *don't* mean "the last index")
        //    int floorIndex = -1;
        //    int ceilingIndex = nums.Length;
        //    int count = 0;
        //    BinarySearchResult result = new BinarySearchResult() { Count = count, IsInList = true };

        //    // If there isn't at least 1 index between floor and ceiling,
        //    // we've run out of guesses and the number must not be present
        //    while (floorIndex + 1 < ceilingIndex)
        //    {
        //        // Find the index ~halfway between the floor and ceiling.
        //        // We use integer division, so we'll never get a "half index".
        //        int distance = ceilingIndex - floorIndex;
        //        int halfDistance = distance / 2;
        //        int guessIndex = floorIndex + halfDistance;

        //        int guessValue = nums[guessIndex];


        //        if (guessValue == target)
        //        {
        //            result.Count = count;
        //            result.IsInList = true; 
        //            return result;
        //        }

        //        if (guessValue > target)
        //        {
        //            // Target is to the left, so move ceiling to the left
        //            count++;
        //            ceilingIndex = guessIndex;
        //        }
        //        else
        //        {
        //            // Target is to the right, so move floor to the right
        //            count++;
        //            floorIndex = guessIndex;
        //        }
        //    }

        //    result.Count = count;
        //    result.IsInList = false; 
        //    return result;
        //}

        //public static int[] MergeSortedArrays(int[] arr0, int[] arr1)
        //{


        //    return MergeArrays(arr0, arr1);
        //}

        //public static int[] MergeArrays(int[] myArray, int[] alicesArray)
        //{
        //    // Make an array big enough to fit the elements from both arrays
        //    var mergedArray = new int[myArray.Length + alicesArray.Length];

        //    int indexOfMyArray = 0;
        //    int indexOfAlicesArray = 0;
        //    int indexOfMergedArray = 0; 

        //    while(indexOfMergedArray < mergedArray.Length)
        //    {

        //        if(indexOfMyArray >= myArray.Length || myArray[indexOfMyArray] > alicesArray[indexOfAlicesArray])
        //        {
        //            mergedArray[indexOfMergedArray] = alicesArray[indexOfAlicesArray];
        //            indexOfAlicesArray++;
        //        }
        //        else if (indexOfAlicesArray >= alicesArray.Length || myArray[indexOfMyArray] < alicesArray[indexOfAlicesArray])
        //        {
        //            mergedArray[indexOfMergedArray] = myArray[indexOfMyArray];
        //            indexOfMyArray++;
        //        }               

        //        indexOfMergedArray++;
        //    }            

        //    // Eventually we'll want to return the merged array
        //    return mergedArray;
        //}

        //public static bool IsFirstComeFirstServed(int[] takeoutOrders, int[] dineinOrders, int[] servedOrders)
        //{



        //}

        public static int GetMaxProfit(int[] stockPrices)
        {
            int minPrice = stockPrices[0];
            int maxProfit = 0;

            foreach (int currentPrice in stockPrices)
            {
                
                // Ensure minPrice is the lowest price we've seen so far
                minPrice = Math.Min(minPrice, currentPrice);

                // See what our profit would be if we bought at the
                // min price and sold at the current price
                int potentialProfit = currentPrice - minPrice;

                // Update maxProfit if we can do better
                maxProfit = Math.Max(maxProfit, potentialProfit);
            }

            return maxProfit;
        }
    }
}
