using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace JobSchedulingWithProfitsAndDeadlines
{
    // Task is reserved word in C#
    class Job
    {
        public int Id { get; set; }
        public int Profit { get; set; }
        public int Deadline { get; set; }

        public int Slot { get; set; } = -1;

        public Job(int id, int profit, int deadline)
        {
            Id = id;
            Profit = profit;
            Deadline = deadline;
        }
        public override string ToString()
        {
            return $"{Profit}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("::: Job Scheduling with Profits and Deadlines :::");

            List<Job> list = new List<Job>()
            {
                new Job(1, 15, 9),
                new Job(2, 2, 2),
                new Job(3, 18, 5),
                new Job(4, 1, 7),
                new Job(5, 25, 4),
                new Job(6, 20, 2),
                new Job(7, 8, 5),
                new Job(8, 10, 7),
                new Job(9, 12, 4),
                new Job(10, 5, 3)
            };

            int L = 6;
            (int sol, List<Job> selectedJobs) = Solution.GreedySchedule(list, L);
            Console.WriteLine($"\n\rSchedule Length = {L}.");

            Console.WriteLine("\n\rSlot | Job | Profit");
            selectedJobs.Sort((x, y) => x.Slot.CompareTo(y.Slot));
            foreach (var job in selectedJobs)
            {
                Console.WriteLine($"  {job.Slot}  |  {job.Id}  |  {job.Profit}");
            }
            Console.WriteLine($"\n\rTotal: {sol}.");
        }
    }

    class Solution
    {
        internal static (int, List<Job>) GreedySchedule(List<Job> list, int L)
        {
            // Sort by Profit
            list.Sort((x, y) => y.Profit.CompareTo(x.Profit));

            // Assign 
            bool[] slotsTaken = new bool[L]; // 0-based index
            List<Job> selectedJobs = new List<Job>();
            int tot = 0;
            int n = 0;
            foreach (var job in list)
            {
                n = Math.Min(L, job.Deadline);
                for (int i = n - 1; i >= 0; i--)
                {
                    if (!slotsTaken[i])
                    {
                        slotsTaken[i] = true;
                        tot += job.Profit;
                        job.Slot = i + 1; // 1-based index
                        selectedJobs.Add(job);
                        break;
                    }
                }
            }

            return (tot, selectedJobs);
            
        }
    }
}
