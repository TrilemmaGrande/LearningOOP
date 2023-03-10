using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Studentendatenbank {
    internal class Student {
        public int MatrikelNr { get; set; }
        public string Name { get; set; }
        public string Fachrichtung { get; set; }

        public Student(int MatrikelNr, string Name, string Fachrichtung) {
            this.MatrikelNr = MatrikelNr;
            this.Name = Name;
            this.Fachrichtung = Fachrichtung;
        }
        public void PrintMe() {
            Console.WriteLine(
                $"Matrikel-Nr.: {MatrikelNr}\n" +
                $"Name: {Name}\n" +
                $"Fachrichtung: {Fachrichtung}\n");
        }
    }
}
