namespace Aufgabe.Jobs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JobVerwaltung JV = new JobVerwaltung();

            Job j1 = new Job("Blowing", "Samo", 10);
            Job j2 = new Job("Flowing", "Badr", 20);
            Job j3 = new Job("Showing", "Nils", 5);
            Job j4 = new Job("Mowing", "Test", 15);

            JV.AddJob(j1);
            JV.AddJob(j2);
            JV.AddJob(j3);

            JV.ShowAllJobs();
            JV.GetJobDone();
            JV.AddJob(j4);
            JV.ShowAllJobs();           
        }
    }
}