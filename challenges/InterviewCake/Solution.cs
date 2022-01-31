using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosAndDataStructures.challenges.InterviewCake
{
    internal class Solution
    {
        public static List<int> MergeRanges(List<Meeting> meetings)
        {
            int meetingLowest = ShowMin(meetings);
            int meetingHighest = ShowMax(meetings);
            List<int> result = new List<int>();

            foreach(var meeting in meetings)
            {
                while(result.Count == 0)
                {
                    if (meeting.StartTime >= meetingLowest)
                    {
                        result.Add(meeting.StartTime);
                    }
                }

                if(meeting.EndTime >= meetingHighest)
                {

                }
              
                
            }
            
            return result;
            
        }

        public static int ShowMin(List<Meeting> meetings)
        {
            List<int> newMeetingList = new List<int>();
            foreach(var meeting in meetings)
            {
                newMeetingList.Add(meeting.StartTime);
                newMeetingList.Add(meeting.EndTime);
            }

            newMeetingList.Sort();

            return (newMeetingList[0]);
        }

        public static int ShowMax(List<Meeting> meetings)
        {
            List<int> newMeetingList = new List<int>();
            foreach (var meeting in meetings)
            {
                newMeetingList.Add(meeting.StartTime);
                newMeetingList.Add(meeting.EndTime);
            }

            newMeetingList.Sort();

            return (newMeetingList[newMeetingList.Count - 1]);
        }
    }
}
