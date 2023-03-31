using System.Diagnostics;
using System.Text;

namespace Aufgabe.IBAN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            StringBuilder ibanInput = new StringBuilder(Console.ReadLine());
            timer.Start();
           
                IBAN iban = new IBAN();
            Console.WriteLine( iban.CheckIBAN(ibanInput));
            
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);



        }
    }
    class IBAN
    {      
        public StringBuilder CheckIBAN(StringBuilder ibanInput)
        {
            ibanInput.Replace(" ", "");
            StringBuilder ibanOutput = new StringBuilder();
            StringBuilder errorOutput = new StringBuilder();

            if (ibanInput.Length != 22)
            {
                return errorOutput.AppendLine("Eingabe Falsch: Längenformat");
            }            

            for (int i = 0; i < ibanInput.Length; i++)
            {
                if (i < 2 && char.IsDigit(ibanInput[i]))
                {
                    return errorOutput.AppendLine("Eingabe Falsch: Ländercode");
                }
                else if (i < 2)
                {
                    ibanOutput.Append(ibanInput[i]);
                }  
                
                if (i >= 2 && !char.IsDigit(ibanInput[i]))
                {
                    return errorOutput.AppendLine("Eingabe Falsch: Zahlenformat");
                }
                else if (i>= 2)
                {
                    ibanOutput.Append(ibanInput[i]);
                }

                if ((i+1) % 4 == 0)
                {
                    ibanOutput.Append(" ");
                }
            }
            return ibanOutput;
        }
    }
}