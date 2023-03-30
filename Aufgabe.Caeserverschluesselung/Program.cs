namespace Aufgabe.Caeserverschluesselung

{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaeserMachine cm = new CaeserMachine();
            Console.WriteLine(cm.Cipher());
        }
    }
}