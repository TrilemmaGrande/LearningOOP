namespace Beispiel.Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool fehler = true;
            do
            {
                try
                {
                    Console.Write("Erste Zahl: ");
                    int zahl1 = int.Parse(Console.ReadLine());
                    Console.Write("Zweite Zahl: ");
                    int zahl2 = int.Parse(Console.ReadLine());

                    Console.WriteLine(zahl1 / zahl2);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Bitte nur Zahlen eingeben!"); ;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"Bitte nur im Bereich {int.MinValue} bis {int.MaxValue}!");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Die zweite Zahl darf nicht 0 sein!");
                }
            }
            while (fehler);
        }
    }
}