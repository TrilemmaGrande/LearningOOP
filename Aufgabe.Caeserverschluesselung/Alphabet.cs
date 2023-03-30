using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Caeserverschluesselung
{
    public class Alphabet
    {
        private char[] alphabet = new[] { 
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 
            'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        public int CalcCharacterPositionInAlphabet(char charakter)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (charakter == alphabet[i])
                {
                    return i + 1;
                }
            }
            return 0;
        }
        public char GetCharacterInAlphabet(int position)
        {
            return alphabet[position - 1];
        }
    }
}
