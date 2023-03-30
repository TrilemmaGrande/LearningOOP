namespace Aufgabe.Caeserverschluesselung
{
    public class UserInput
    {
        private int chiffre;
        private string readableText;

        public void SetChiffre()
        {
            Console.WriteLine("Chiffre setzen: ");
            chiffre = Convert.ToInt32(Console.ReadLine());
        }
        public void SetReadableText()
        {
            Console.WriteLine("Text zum verschlüsseln eingeben: ");
            readableText = Console.ReadLine().ToUpper();
        }
        public int GetChiffe()
        {
            return chiffre;
        }
        public string GetReadableText()
        {
            return readableText;
        }
    }
}
