using System.Text;

namespace Beispiel.ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Abra Kadabra";
            Console.WriteLine(text);
            Console.WriteLine(text.SwitchCase());

        }
    }
    static class StringExtensions
    {
        public static string SwitchCase(this string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                sb.Append(char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));
            }
            return sb.ToString();
        }
    }
}