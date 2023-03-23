using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel.Interfaces
{
    internal class Auto : IFahren
    {
        public void fahren()
        {
            Console.WriteLine( "Das Auto fährt");
        }
    }
}
