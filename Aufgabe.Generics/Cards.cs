using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Generics
{
    class Cards : ICards
    {
        private string color;
        private string value;

        public Cards(string color, string value)
        {
            this.color = color;
            this.value = value;
        }
    }
}
