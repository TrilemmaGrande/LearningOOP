using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Caeserverschluesselung
{
    internal class CaeserMachine
    {
        private UserInput userInput = new UserInput();
        private Alphabet alphabet = new Alphabet();
        private string readableText;
        private int readableTextPosition;
        private string chiffredText = "";
        private int chiffre;

        public string Cipher()
        {
            userInput.SetReadableText();
            userInput.SetChiffre();
            readableText = userInput.GetReadableText();
            chiffre = userInput.GetChiffe();

            for (int i = 0; i < readableText.Length; i++)
            {
                readableTextPosition = alphabet.CalcCharacterPositionInAlphabet(readableText[i]);
                chiffredText += alphabet.GetCharacterInAlphabet((readableTextPosition + chiffre) % 26);
            }
            return chiffredText;
        }
    }
}
