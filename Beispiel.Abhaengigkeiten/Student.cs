using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel.Abhaengigkeiten {
    internal class Student {
        private string name;

        public Student(string name) {
            this.name = name;
        }
        public void ReadBook(Book book) {
            string infos = book.GetInfos();
            Console.WriteLine( "Ich habe gerade gelesen: ");
            Console.WriteLine(infos);
        }
    }
}
