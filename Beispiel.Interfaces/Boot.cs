﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel.Interfaces
{
    internal class Boot : ISchwimmen
    {
        public void Schwimmen()
        {
            Console.WriteLine("Das Boot schwimmt");
        }
    }
}
