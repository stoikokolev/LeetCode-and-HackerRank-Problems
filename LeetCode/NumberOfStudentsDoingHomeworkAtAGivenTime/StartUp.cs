using System;

namespace NumberOfStudentsDoingHomeworkAtAGivenTime
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"https://leetcode.com/problems/number-of-students-doing-homework-at-a-given-time/");
        }
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            byte count = 0;
            for (byte i = 0; i < startTime.Length; i++)
            {
                if (queryTime <= endTime[i] && queryTime >= startTime[i])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
