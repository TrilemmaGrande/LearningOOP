using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Moped
{
    class MitAnhaenger : Moped
    {
        private int space;
        private int spaceMax;

        public MitAnhaenger(int spaceMax, string licensePlate = "BIT-LC 1")
        {
            this.spaceMax = spaceMax;
            this.licensePlate = licensePlate;
        }
        public bool Load(int load)
        {
            if (space + load <= spaceMax)
            {
                space += load;
                Console.WriteLine(
                    $"Der Anhänger wurde mit {load} Dingen beladen und hat jetzt {space} Dinge.\n");
                return true;
            }
            return false;
        }
        public bool Unload(int unload)
        {
            if (space - unload >= 0)
            {
                space -= unload;
                Console.WriteLine(
                    $"Es wurden {unload} Dinge vom Anhänger entladen, er hat jetzt {space} Dinge.\n");
                return true;
            }
            return false;
        }
        public int GetLoad()
        {
            return space;
        }
        public new string GetInfos()
        {
            return
                $"Kennzeichen:\t {licensePlate} \n" +
                $"Kilometer: \t{kilometres} \n" +
                $"Sitzplätze: \t{seats} \n" +
                $"Ladefläche: \t{spaceMax} \n" +
                $"Beladen: \t{space} \n";
        }

    }
}
