using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Schule
{
    internal class Schulklasse
    {
        private string name;
        Lehrer lehrer;
        Schueler[] schueler = new Schueler[5];

        public Schulklasse(string name, string lehrerName)
        {
            this.name = name;
            lehrer = new Lehrer(lehrerName, this);
        }

        public void SetSchueler(Schueler[] schueler)
        {
            for (int i = 0; i < this.schueler.Length; i++)
            {
                for (int k = 0; k < schueler.Length; k++)
                {
                    if (schueler[k].GetEingeschult() == false)
                    {
                        this.schueler[i] = schueler[k];
                        schueler[k].SetEingeschult(true);
                        break;
                    }
                }
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine(
                $"Klasse: {name} \n" +
                $"Lehrer: {lehrer.GetName()}");

            for (int i = 0; i < schueler.Length; i++)
            {
                Console.WriteLine($"{schueler[i].GetName()}");
            }
            Console.WriteLine();
        }
    }
}
