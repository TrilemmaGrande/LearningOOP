using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Schule
{
    internal class Schule
    {
        Schulklasse[] schulklasse = new Schulklasse[4];

        public void DoEinschulung(Schueler[] schueler)
        {        
            for (int i = 0; i < schulklasse.Length; i++)
            {
                schulklasse[i] = new Schulklasse($"A{i + 1}", $"lehrer{i + 1}");
                schulklasse[i].SetSchueler(schueler);
                schulklasse[i].PrintInfo();
            }
        }

    }
}
