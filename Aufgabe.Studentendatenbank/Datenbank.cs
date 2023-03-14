using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Studentendatenbank {
    internal class Datenbank {
        Student[] students;

        public Datenbank(int anzahlStudent){
            students = new Student[anzahlStudent];
        }
        public bool AddStudent(Student student) {
            for (int i = 0; i < students.Length; i++) {
                if (students[i] is null) {
                    students[i] = student;
                    return true;
                }             
            }
            return false;
        }
        public bool RemoveStudent(Student student) {
            for (int i = 0; i < students.Length; i++) {
                if (students[i] == student) {
                    students[i] = null;
                    return true;
                }
            }
            return false;
        }
        public int CountStudents() {
            int counter = students.Length;
            for (int i = 0; i < students.Length; i++) {
                if (students[i] is null) {
                    counter--;
                }
            }
            return counter;
        }
        public void PrintMe() {
            for (int i = 0; i < students.Length; i++) {
                if (students[i] is not null) {
                   students[i].PrintMe();
                }
            }
        }
    }
}
