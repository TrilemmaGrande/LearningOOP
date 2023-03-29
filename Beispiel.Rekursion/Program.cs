namespace Beispiel.Rekursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FakultaetIterativ(59));
            Console.WriteLine(FakultaetRekursiv(65));
        }
        static long FakultaetIterativ(long n)
        {
            long ergebnis = 1;
            for (long i = 1; i <= n; i++)
            {
                ergebnis = ergebnis * i;
            }
            return ergebnis;
        }
        static long FakultaetRekursiv(long n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * FakultaetRekursiv(n - 1);
            }
        }
    }
}