using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Simpsons
{
    internal class Simpson
    {
        protected string vorname;
        protected string nachname = "Simpson";
        protected const string hautfarbe = "Gelb";
        protected string wohnort = "Evergreen Terrace 742, Springfield";
        protected int zaehler;
        protected string praedikat;
        protected string hobby;

        public void PrintInfos()
        {
            Console.WriteLine(
                $"Vorname = {vorname}\n" +
                $"Nachname = {nachname}\n" +
                $"Wohnort = {wohnort}\n" +
                $"Hautfarbe = {hautfarbe}\n");
        }
        public void DoHobby(int zaehler)
        {
            this.zaehler += zaehler;
        }
        public void PrintHobby()
        {
            Console.WriteLine(
                $"{vorname} {nachname} {praedikat} {zaehler} mal {hobby}.\n");
        }
    }
}