using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPs
{
    internal class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public void Display() {
            Console.WriteLine($"student id={Id}, Student name= {Name}, Age= {Age}");
                }
    }

    internal class studentManager
    {   private List<student> students = new List<student>();
        public void Add(student student)
        {
            students.Add(student);
        }
        public void View()
        {
            foreach (var student in students) {
                student.Display();

            }
        }
        public void Delete(int id)
        {
            for (int i = 0; i < students.Count; i++) {
                if (students[i].Id == id) { 
                     students.RemoveAt(i);
                } 
            }
        }
        public student FindStudent(int id)
        {
            return students.Find(s => s.Id == id);
        }


    }
}
