using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_TV {
    internal class Tv {
        private bool switchedOn;
        private int volume = 10;
        private int volumeStep = 1;
        private string[] programs = { "weißes Rauschen", "öffentlich rechtlicher scheiß", "MTV", "KiKa", "VIVA", "Pornokanal" };
        private string program = "weißes Rauschen";

        public void SetVolumeStep(int volumeStep) {
            if (switchedOn) {
                this.volumeStep = volumeStep;
            }
            else {
                TvIdiot();
            }
        }
        public void RaiseVolume() {
            if (switchedOn) {
                volume += volumeStep;
                TestVolume();
            }
            else {
                TvIdiot();
            }
        }
        public void LowerVolume() {
            if (switchedOn) {
                volume -= volumeStep;
                TestVolume();
            }
            else {
                TvIdiot();
            }
        }
        public void TurnOn() {
            if (!switchedOn) {
                switchedOn = !switchedOn;
            }
        }
        public void TurnOff() {
            if (switchedOn) {
                switchedOn = !switchedOn;
            }
        }
        private string isOn() {
            if (switchedOn) {
                return "Der Gerät ist an";
            }
            return "Der Gerät ist aus";
        }
        public void GetInfo() {
            if (switchedOn) {
                Console.WriteLine($"{isOn()} und {volume} laut");
            }
            else {
                Console.WriteLine($"{isOn()}");
            }
        }
        private void TestVolume() {
            if (volume < 0) {
                volume = 0;
            }
            else if (volume > 100) {
                volume = 100;
            }
        }
        public void switchProgram() {
            if (switchedOn) {
                int i = 1;
                Console.WriteLine("Programme: ");
                foreach (string item in programs) {
                    Console.WriteLine(i + " " + item);
                    if (item == program) {
                        Console.WriteLine("^^^^^^^^^^^^^^");
                    }
                    i++;
                }
                int programOption = 0;
                Console.WriteLine("Bitte Programmnummer eingeben: ");
                string inputOption = Console.ReadLine();
                if (inputOption.All(char.IsDigit)) {
                    programOption = Convert.ToInt32(inputOption);
                }
                if (programOption > 0 && programOption < programs.Length) {
                    Console.WriteLine("aktuelles Programm: " + programs[programOption - 1]);
                    program = programs[programOption - 1];
                }
                else {
                    Console.WriteLine("Es geht nur von 1-6 du Idiot!");
                }
            }
            else {
                TvIdiot();
            }
        }
        private void TvIdiot() {
            Console.WriteLine("TV ist aus du Idiot!");
        }
    }
}
