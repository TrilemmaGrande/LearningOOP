namespace Aufgabe.Caeserverschluesselung

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string klartext = "Hallo WeltZ";
            char[] klartextChars = klartext.ToUpper().ToCharArray();
            string verschluesselt = "";

            for (int i = 0; i < klartextChars.Length; i++)
            {
                if (klartextChars[i] >= (char)65
                     && klartextChars[i] <= (char)87)
                {
                    verschluesselt += ((char)(klartextChars[i] + 3));
                }
                else if (klartextChars[i] >= (char)88
                    && klartextChars[i] <= (char)90)
                {
                    verschluesselt += ((char)(klartextChars[i] - 23));
                }
                else
                {
                    verschluesselt += klartextChars[i];
                }
            }
            Console.WriteLine(verschluesselt);
        }
    }
}