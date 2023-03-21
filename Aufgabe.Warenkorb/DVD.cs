using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Warenkorb
{
    internal class DVD : Article
    {
        private string genre;
        private int countryCode;

        public DVD(double price, string title, string genre, int countryCode = 2) : base(price)
        {
            this.title = title;
            this.genre = genre;
            this.countryCode = countryCode;
            
        }
        public override double GetPrice()
        {
            return Math.Round((base.GetPrice()* 1.19), 2);
        }
        public override void PrintInfos()
        {
            base.PrintInfos();
            Console.WriteLine(
                $"Titel: \t\t{title}\n" +
                $"Genre: \t\t{genre}\n" +
                $"Ländercode: \t{countryCode}");
        }
    }
}
