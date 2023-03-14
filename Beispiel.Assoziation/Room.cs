using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel.Assoziation
{
    internal class Room
    {
        private Class _class;
        private string name;

        public Room(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetClass(Class _class)
        {
            this._class = _class;
        }
        public void PrintInfos()
        {
            Console.WriteLine($"Im Raum {name} ist die Klasse {_class.GetName()}.");
        }
    }
}
