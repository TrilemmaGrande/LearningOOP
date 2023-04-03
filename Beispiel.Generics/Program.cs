namespace Beispiel.Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericStack<Vehicle> myCar = new GenericStack<Vehicle>();
        }
    }
    class GenericStack<T> where T : new()
    {
        private T[] array;
        public int Count
        {
            get;
            private set;
        }
        public void Push(T element)
        {
            array[Count] = element;
            Count++;
        }
        public T Pop()
        {
            Count--;
            T element = array[Count];
            return element;
        }
    }

    class Vehicle
    {
        public void drive()
        {
            Console.WriteLine("Vroooom");
        }
    }
}