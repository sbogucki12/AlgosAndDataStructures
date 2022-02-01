using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosAndDataStructures.challenges.InterviewCake
{
    internal class Solution
    {
        public static List<Meeting> MergeRanges(List<Meeting> meetings)
        {
            var sortedMeetings = meetings.Select(m => new Meeting(m.StartTime, m.EndTime))
                .OrderBy(m => m.StartTime).ToList();
            var mergedMeetings = new List<Meeting> { sortedMeetings[0] };
            foreach (var currentMeeting in sortedMeetings)
            {
                var lastMergedMeeting = mergedMeetings.Last();

                if (currentMeeting.StartTime <= lastMergedMeeting.EndTime)
                {
                    // If the current meeting overlaps with the last merged meeting, use the
                    // later end time of the two
                    lastMergedMeeting.EndTime =
                        Math.Max(lastMergedMeeting.EndTime, currentMeeting.EndTime);
                }

                else
                {
                    // Add the current meeting since it doesn't overlap
                    mergedMeetings.Add(currentMeeting);
                }

            }
            return mergedMeetings;

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
