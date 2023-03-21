using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Warenkorb
{
    internal class ShoppingCart
    {
        Article[] articles = new Article[0];
        Article[] temp;
        private int cartNumber = 1;
        private static int counter;

        public ShoppingCart()
        {
            cartNumber += counter;
            counter++;
        }

        public void InsertArticle(Article article)
        {
            temp = new Article[articles.Length + 1];

            for (int i = 0; i < articles.Length; i++)
            {
                temp[i] = articles[i];
                articles[i] = null;
            }

            articles = new Article[temp.Length];

            for (int i = 0; i < temp.Length - 1; i++)
            {
                articles[i] = temp[i];
                temp[i] = null;
            }

            articles[^1] = article;
        }
        public void PrintContent()
        {
            Console.WriteLine($"CartNr.: {cartNumber}");
            Console.WriteLine("Art.Nr. \tPrice \tItem \tAuthor \tTitle ");
            Console.WriteLine("----------------------------------------------------------------------------------");
            double total = 0;
            foreach (var item in articles)
            {
                string tempAuthor;
                string article;
                total += item.GetPrice();
                if (item is Book)
                {
                    article = "Book";
                    tempAuthor = ((Book)item).GetAuthor();
                }
                else
                {
                    article = "DVD";
                    tempAuthor = "";
                }
                Console.WriteLine($"{item.GetArticleNumber()}\t\t {item.GetPrice(),5:F2}\t{article}\t{tempAuthor}\t{item.GetTitle()}");
            }
            Console.WriteLine("\t\t-------");
            Console.WriteLine($"Total:\t\t{total,6:F2}");
            Console.WriteLine("----------------------------------------------------------------------------------");
        }
    }
}
