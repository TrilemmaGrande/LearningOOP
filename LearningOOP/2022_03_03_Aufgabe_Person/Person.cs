﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Erstellen Sie eine Klasse Person
 * die Person soll einen Namen und ein Alter haben.
 * Die Person kann sich vorstellen und das Alter erhöht sich an seinem Geburtstag. 
 */

namespace LearningOOP._2022_03_03_Aufgabe_Person {
    class Person {
        private string gebDate;
        private string name;
        private string middleName;
        private string firstName;

        public void SetGebDate(string gebDate) {
            this.gebDate = gebDate;
        }
        public string GetGebDate() {
            return gebDate;
        }
        public void SetName(string name, string middleName, string firstName) {
            this.name = name;
            this.middleName = middleName;
            this.firstName = firstName;
        }
        public string GetName() {
            return name;
        }
        public string GetMiddleName() {
            return middleName;
        }
        public string GetFirstName() {
            return firstName;
        }
    }
}
