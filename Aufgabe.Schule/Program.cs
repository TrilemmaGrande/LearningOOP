namespace Aufgabe.Schule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Schule schule = new Schule();
            Schueler[] schueler = new Schueler[20];           
            Random age = new Random();

            for (int i = 0; i < schueler.Length; i++)
            {
                schueler[i] = new Schueler($"schueler{i + 1}", age.Next(6, 9));
            }

            schule.DoEinschulung(schueler);           
            
        }

    }
}