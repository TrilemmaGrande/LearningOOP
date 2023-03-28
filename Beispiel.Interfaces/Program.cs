namespace Beispiel.Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IrgendwasMitFahren(new Auto());           
        }
        static void IrgendwasMitFahren(IFahren fahrzeug)
        {
            Console.WriteLine("Ich fahre hier!");
        }
    }
}