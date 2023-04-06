namespace Aufgabe.Jobs
{
    internal class JobVerwaltung
    {
        private Queue<Job> jobs = new Queue<Job>();
               
        public void AddJob(Job job)
        {
            jobs.Enqueue(job);
            Console.WriteLine($"Anzahl Jobs: {jobs.Count}");
        }
        public void GetJobDone()
        {
            Console.WriteLine($"aktueller Job: {jobs.Dequeue()} erledigt");            
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
