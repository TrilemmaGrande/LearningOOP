namespace Beispiel.Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool fehler = true;
            int zahl1 = InputInt("Erste Zahl: ");
            do
            {
                int zahl2 = InputInt("Zweite Zahl: ");

                if (zahl2 != 0)
                {
                    Console.WriteLine(zahl1 / zahl2);
                    fehler = false;
                }
                else
                {
                    Console.WriteLine("Zahl 2 darf nicht 0 sein!");
                }

            }
            while (fehler);
        }
        static int InputInt(string text)
        {

            int input = 0;
            bool fehler = true;
            do
            {
                try
                {
                    Console.Write(text);
                    input = int.Parse(Console.ReadLine());
                    fehler = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Nochmal, Du Honk!");
                }
            }
            while (fehler);
            return input;
        }
        static int InputInt2(string text)
        {
            int input = 0;
            bool ok = false;

            do
            {
                ok = int.TryParse(Console.ReadLine(), out input);
            } while (!ok);
            return input;
        }
    }
}