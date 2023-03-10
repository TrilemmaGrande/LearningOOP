using System.Security.Cryptography.X509Certificates;

namespace Aufgabe_Methodenwahnsinn {
    internal class Program {
        static void Main(string[] args) {
            int x = 42;
            Console.WriteLine( x + Methode1(x) );
        }
        static int Methode1(int x) {
            return x + 1 + Methode2(x + 1);
        }
        static int Methode2(int x) {           
            return x + 2 + Methode3(x + 2);
        }
        static int Methode3(int x) {
            return x + 3 + Methode4(x + 3);
        }
            
        static int Methode4(int x) {
            return x + 4;
        }
    }
}