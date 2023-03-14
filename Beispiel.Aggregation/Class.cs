using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel.Aggregation {
    internal class Class {
        private string name;
        private Student[] students;

        public Class(string name, int cnt) {
            this.name = name;
            this.students = new Student[cnt];
        }

        public string GetName() {
            return name;
        }
        public void AddStudent(Student student) {
            for (int i = 0; i < students.Length; i++) {
                if (students[i] is null) {
                    students[i] = student;
                    student.SetClass(this);
                    break;
                }
            }
        }
        public void PrintInfos() {
            Console.WriteLine($"Studenten in der Klasse {name}: ");
            foreach  (Student student in students) {
                if (student is not null) {
                Console.WriteLine(student.GetName());
                }
            }
        }
    }
}
