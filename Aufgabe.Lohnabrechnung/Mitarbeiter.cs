using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Lohnabrechnung
{
    internal class Mitarbeiter
    {
        protected string vorname;
        protected string name;
        protected string angestelltAls;
        protected double gehalt;

        public void PrintInfo()
        {
            Console.WriteLine(
                $"{vorname} {name}\n" +
                $"{angestelltAls} \n" +
                $"Gehalt: {gehalt}\n");
        }
    }
}
