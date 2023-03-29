namespace Beispiel.Exceptions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "abc", "def", "ghi", "jkl", "mno", "pqr", "stu" };
            PrintString(strings, 11);
        }
        static void PrintString(string[] array, int position)
        {
            if (position < 0 || position >= array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(position), position, "Ausserhalb des Arrays");
            }
            Console.WriteLine(array[position]);
        }
    }
}