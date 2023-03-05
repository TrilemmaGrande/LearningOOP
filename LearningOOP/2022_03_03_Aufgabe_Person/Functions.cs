using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP._2022_03_03_Aufgabe_Person {
    internal class Functions {
        public void MainMenu(Person obj) {
            int exit = 0;
            while (exit == 0) {
                Console.WriteLine(
                    "Auswahl: \n" +
                    "1: Namen eingeben \n" +
                    "2: Geburtsdatum eingeben \n" +
                    "3: Geburtstag? \n" +
                    "4: Daten ausgeben \n" +
                    "0: Exit");
                switch (Console.ReadLine()) {
                    case "1":
                        InputName(obj);
                        break;
                    case "2":
                        InputGebDate(obj);
                        break;
                    case "3":
                        Birthday(obj);
                        break;
                    case "4":
                        OutputData(obj);
                        break;
                    case "0":
                       exit = 1;
                        break;
                    default:
                        Console.WriteLine("Eingabe ungültig!");
                        break;
                }
            }
        }
        private void InputName(Person obj) {
            string tempInputOption;
            string name = obj.GetName();
            string middleName = obj.GetMiddleName();
            string firstName = obj.GetFirstName();

            if (name != null || firstName != null) {
                Console.WriteLine(
                    "Name bereits eingegeben, möchten Sie den Namen ändern? (Y/N)");
                tempInputOption = Console.ReadLine().ToLower();
                if (tempInputOption == "y") {
                    name = null;
                    middleName = null;
                    firstName = null;
                }
            }
            if (name == null) {
                Console.WriteLine(
                    "Bitte geben Sie Ihren Nachnamen ein: ");
                name = Console.ReadLine();
            }
            Console.WriteLine(
                "Mittelnamen ändern/hinzufügen? (Y/N)");
            tempInputOption = Console.ReadLine().ToLower();
            if (middleName == null && tempInputOption == "y") {
                Console.WriteLine(
                    "Bitte geben Sie Ihren Mittelnamen ein: ");
                middleName = Console.ReadLine();
            }
            if (firstName == null) {
                Console.WriteLine(
                    "Bitte geben Sie Ihren Vornamen ein: ");
                firstName = Console.ReadLine();
            }
            obj.SetName(name, middleName, firstName);
            tempInputOption = null;
        }
        private void InputGebDate(Person obj) {
            string temp;

            if (obj.GetGebDate() == null) {
                Console.WriteLine(
                    "Bitte geben Sie Ihr Geburtsdatum ein: dd/mm/yyyy: ");
                obj.SetGebDate(Console.ReadLine());
            }
            else {
                Console.WriteLine(
                    "Geburtsdatum ist bereits eingegeben, Geburtsdatum korrigieren? (Y/N) ");
                temp = Console.ReadLine().ToLower();
                if (temp == "y") {
                    Console.WriteLine(
                        "Bitte geben Sie Ihr korrigiertes Geburtsdatum ein: dd/mm/yyyy: ");
                    obj.SetGebDate(Console.ReadLine());
                }
                temp = null;
            }
        }
        private void Birthday(Person obj) {
            string gebDate = obj.GetGebDate();
            string today = DateTime.Today.ToString("dd.MM.yyyy");

            if (obj.GetGebDate() == null) {
                Console.WriteLine(
                    "Geburtsdatum noch nicht eingegeben! ");
            }
            else {
            int age = Convert.ToInt32(today.Substring(6)) - Convert.ToInt32(gebDate.Substring(6));
                if ((Convert.ToInt32(today.Substring(0, 2)) < Convert.ToInt32(gebDate.Substring(0, 2))
                && Convert.ToInt32(today.Substring(3, 2)) == Convert.ToInt32(gebDate.Substring(3, 2)))
                || Convert.ToInt32(today.Substring(3, 2)) < Convert.ToInt32(gebDate.Substring(3, 2))) {
                    age = age - 1;
                }
                Console.WriteLine(
                    "Alter: " + age);
                if (today.Substring(0, 2) == gebDate.Substring(0, 2)
                    && today.Substring(3, 2) == gebDate.Substring(3, 2)) {
                    Console.WriteLine(
                        "Alles Gute! Wo Kuchen? ");
                }
                else {
                    Console.WriteLine(
                        "Heute kein Kuchen! ");
                }
            }
        }
        private void OutputData(Person obj) {
            if (obj.GetName() != null) {
                Console.WriteLine(
                    "Name: " + obj.GetName());
            }
            if (obj.GetMiddleName() != null) {
                Console.WriteLine(
                    "Mttelname: " + obj.GetMiddleName());
            }
            if (obj.GetFirstName() != null) {
                Console.WriteLine(
                    "Vorname: " + obj.GetFirstName());
            }
            if (obj.GetGebDate() != null) {
                Console.WriteLine(
                    "Geburtsdatum: " + obj.GetGebDate());
            }
            Console.WriteLine();
            Birthday(obj);
            Console.WriteLine();
        }
    }
}
