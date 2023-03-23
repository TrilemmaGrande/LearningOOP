namespace Beispiel.Interfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MethodeProgrammablauf(new FileLogger());
            MethodeProgrammablauf(new DataBaseLogger());
        }
        static void MethodeProgrammablauf(ILogger logger)
        {
            Console.WriteLine("Die Methode macht aufregende Dinge ...");
            Console.WriteLine("Zwischendurch muss Sie Dinge loggen.");
            logger.LogData("Wichtige Infos");
            Console.WriteLine("Und weitere aufregende Dinge passieren ...\n");
        }
    }
}