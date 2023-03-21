using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Warenkorb
{
    internal class Article
    {
        protected int articleNumber;
        private static int counter = 10000;
        protected double price;
        protected string title;

        public Article(double price)
        {
            articleNumber = counter;
            counter++;
            this.price = price;
        }

        public virtual double GetPrice()
        {
            return price;
        }
        public string GetTitle()
        {
            return title;
        }
        public int GetArticleNumber()
        {
            return articleNumber;
        }
        public virtual void PrintInfos()
        {
            Console.WriteLine(
                $"ArtikelNr.: \t{articleNumber}\n" +
                $"Preis: \t\t{price}");
        }
    }
}
