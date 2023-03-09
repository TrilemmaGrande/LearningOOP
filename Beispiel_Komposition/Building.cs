using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel_Komposition
{
    class Building
    {
        private string name;
        private Floor[] floors;

        public Building(int floors, string name) {
            this.floors = new Floor[floors];
            for (int i = 0; i < this.floors.Length; i++) {
                this.floors[i] = new Floor(i);
            }
            this.name = name;
        }
        public void PrintInfos() {
            Console.WriteLine($"Gebäude {name}:");
            foreach (Floor floor in floors) {
                Console.WriteLine("Etage " + floor.GetFloorId());

            }
        }
    }
}
