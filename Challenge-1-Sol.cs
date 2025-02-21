using System;
using System.Collections.Generic;

namespace ClockSync
{
    class Program
    {
        static void Main(string[] args)
        {
            // Grand Clock Tower time
            TimeSpan grandClockTime = new TimeSpan(15, 0, 0);

            // List of clock times around the town
            List<TimeSpan> clockTimes = new List<TimeSpan>
            {
                new TimeSpan(14, 45, 0),
                new TimeSpan(15, 5, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(14, 40, 0)
            };

            // Calculate the time differences
            List<int> timeDifferences = new List<int>();
            foreach (var clockTime in clockTimes)
            {
                timeDifferences.Add((int)(clockTime - grandClockTime).TotalMinutes);
            }

            // Output the results
            Console.WriteLine("Time differences (in minutes) from the Grand Clock Tower:");
            for (int i = 0; i < timeDifferences.Count; i++)
            {
                Console.WriteLine($"Clock {i + 1}: {timeDifferences[i]} minutes");
            }
        }
    }
}
