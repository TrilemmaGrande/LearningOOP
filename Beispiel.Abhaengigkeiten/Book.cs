using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel.Abhaengigkeiten {
    internal class Book {
        private string title;
        private string content;

        public Book(string title, string content) {
            this.title = title;
            this.content = content;
        }
        public string GetInfos() {
            return content;
        }
    }
}
