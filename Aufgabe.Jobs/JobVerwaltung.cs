﻿namespace Aufgabe.Jobs
{
    internal class JobVerwaltung
    {
        private Queue<Job> jobs;

        public JobVerwaltung()
        {
            this.jobs = new Queue<Job>();
        }
        public void AddJob(Job job)
        {
            jobs.Enqueue(job);
            Console.WriteLine($"Anzahl Jobs: {jobs.Count}");
        }
        public void GetJobDone()
        {
            Console.WriteLine($"aktueller Job: {jobs.Peek().GetInfos()} erledigt");
            jobs.Dequeue();
            Console.WriteLine($"nächster Job: {jobs.Peek().GetInfos()}");
            Console.WriteLine($"Anzahl Jobs: {jobs.Count}");
        }
        public void ShowAllJobs()
        {
            int counter = 1;
            foreach (var item in jobs)
            {
                Console.WriteLine($"Job {counter}: {item.GetInfos()}");
                counter++;
            }
        }
    }
}
