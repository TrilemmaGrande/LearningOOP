using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Generics
{
    class GenericStack<T> where T : ICards
    {
        private T[] cards;
        public int Count
        {
            get;
            private set;
        }
        public GenericStack(int capacity)
        {
            cards = new T[capacity];
        }
        public void Push(T element)
        {
            cards[Count] = element;
            Count++;
        }
        public T Pop()
        {
            Count--;
            T element = cards[Count];
            cards[Count] = default(T);
            return element;
        }
        public void Shuffle()
        {
            Console.WriteLine("everyday I'm shuffling");
        }
    }
    }
