namespace Aufgabe.Simpsons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Homer homer = new Homer();
            Marge marge = new Marge();
            Lisa lisa = new Lisa();
            Bart bart = new Bart();
            Maggie maggie = new Maggie();

            homer.DoHobby(20);
            marge.DoHobby(10);
            lisa.DoHobby(5);
            bart.DoHobby(3);
            maggie.DoHobby(4123);

            homer.PrintInfos();
            homer.PrintHobby();
            marge.PrintInfos();
            marge.PrintHobby();
            lisa.PrintInfos();
            lisa.PrintHobby();
            bart.PrintInfos();
            bart.PrintHobby();
            maggie.PrintInfos();
            maggie.PrintHobby();
        }
    }
}