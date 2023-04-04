using System.Collections;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Diagnostics;

namespace Beispiel.Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EINFACHE COLLECTIONS /////////////////////////////////////////////////////

            //// HASHTABLE /////////////////////////////////////////////////////
            Console.WriteLine("\n----------Hashtable\n");

            Hashtable table = new Hashtable();
            table.Add(1, "Eins");
            table.Add(5, "Fünf");
            table.Add(7, "Sieben");
            table.Add("Ja", true);
            table.Add(false, "Nein");

            Console.WriteLine(table["Ja"]);

            foreach (DictionaryEntry item in table)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            //// SORTEDLIST //////////////////////////////////////////////////
            Console.WriteLine("\n----------SortedList\n");

            SortedList liste = new SortedList();
            liste.Add(1, 1);
            liste.Add(2, true);
            liste.Add(3, "drei");
            liste.Add(4, false);
            liste.Add(5, 1.0923);

            liste.SetByIndex(1, "zwei");
            liste.Remove(3);

            foreach (DictionaryEntry item in liste)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            //// STACK //////////////////////////////////////////////////
            Console.WriteLine("\n----------Stack\n");

            Stack myStack = new Stack();

            myStack.Push(1);
            myStack.Push("zwei");
            myStack.Push(true);
            myStack.Push('X');
            myStack.Push(Math.PI);

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Der Stack hat " + myStack.Count + " Elemente");
            Console.WriteLine("Das oberste Element ist " + myStack.Peek());
            Console.WriteLine("Der Stack hat " + myStack.Count + " Elemente");

            while (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop());
            }
            Console.WriteLine("Der Stack hat " + myStack.Count + " Elemente");

            //// QUEUE //////////////////////////////////////////////////
            Console.WriteLine("\n----------Queue\n");

            Queue elsa = new Queue();

            elsa.Enqueue(1);
            elsa.Enqueue("zwei");
            elsa.Enqueue(false);
            elsa.Enqueue('Y');
            elsa.Enqueue(Math.PI);

            foreach (var item in elsa)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(elsa.Count);
            Console.WriteLine(elsa.Peek());
            Console.WriteLine(elsa.Count);

            while (elsa.Count > 0)
            {
                Console.WriteLine(elsa.Dequeue());
            }
            Console.WriteLine(elsa.Count);

            //// GENERISCHE COLLECTIONS /////////////////////////////////////////////////////

            //// LIST //////////////////////////////////////////////////
            Console.WriteLine("\n----------Liste\n");

            List<string> liste1 = new List<string>();

            liste1.Add("eins");
            liste1.Add("drei");

            liste1.Insert(1, "zwei");

            foreach (string item in liste1)
            {
                Console.WriteLine(item);
            }

            List<string> liste2 = new List<string>();
            liste2.Add("vier");
            liste2.Add("fünf");

            liste1.InsertRange(liste1.Count, liste2);
            Console.WriteLine("Nach InsertRange(liste1.Count, liste2)");

            foreach (string item in liste1)
            {
                Console.WriteLine(item);
            }
            liste1.Remove("eins");

            //// DICTIONARY //////////////////////////////////////////////////
            Console.WriteLine("\n----------Dictionary\n");

            Dictionary<int, int> square = new Dictionary<int, int>();

            for (int i = 1; i < 10; i++)
            {
                square.Add(i, i * i);
            }

            for (int i = 1; i <= square.Count; i++)
            {
                Console.WriteLine(i + " Fläche: " + square[i]);
            }

            square.Remove(9);

            foreach (var item in square)
            {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            }

            //// DICTIONARY WITH LIST //////////////////////////////////////////////////
            Dictionary<string, List<string>> countries = new Dictionary<string, List<string>>();

            countries.Add("Deutschland", new List<string>() { "Berlin", "Hamburg", "München" });
            countries.Add("Frankreich", new List<string>() { "Paris", "Marseille", "Lyon" });
            countries.Add("Italien", new List<string>() { "Rom", "Mailand", "Neapel" });
            countries.Add("USA", new List<string>() { "New York City", "Los Angeles", "Chicago" });

            countries["Deutschland"].Add("Köln");
            countries["Frankreich"].Remove("Lyon");

            foreach (var item in countries.Keys)
            {
                Console.WriteLine();
                Console.WriteLine(item);
                foreach (var item2 in countries[item])
                {
                    Console.WriteLine(item2);
                }
            }

            //// SORTED LIST GENERIC //////////////////////////////////////////////////
            Console.WriteLine("\n----------SortedList Generic\n");

            SortedList<string, string> sortedList1 = new SortedList<string, string>();

            sortedList1["test"] = "Test";
            sortedList1.Add("test2", "Test2");

            foreach (var item in sortedList1)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            //// STACK GENERIC//////////////////////////////////////////////////
            Console.WriteLine("\n----------Stack Generic\n");

            Stack<int> stapel = new Stack<int>();
            stapel.Push(1);
            stapel.Push(1);
            for (int i = 0; i < 10; i++)
            {
                int last = stapel.Pop();
                int next = stapel.Peek() + last;
                stapel.Push(last);
                stapel.Push(next);
            }

            foreach (var item in stapel)
            {
                Console.WriteLine(item);
            }

            //// QUEUE GENERIC//////////////////////////////////////////////////
            Console.WriteLine("\n----------Queue Generic\n");

            Queue<string> elsaGen = new Queue<string>();

            elsaGen.Enqueue("A");
            elsaGen.Enqueue("B");
            elsaGen.Enqueue("D");
            elsaGen.Enqueue("C");

            Console.WriteLine(elsaGen.Count);

            foreach (var item in elsaGen) 
            {
                Console.WriteLine("Elsa " + item);
            }
            while (elsaGen.Count > 0)
            {
                Console.WriteLine("Elsa " + elsaGen.Dequeue() +  " tot!");
            }
            Console.WriteLine(elsaGen.Count);
        }
    }
}