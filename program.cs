using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            studentManager manager= new studentManager();
            bool n = true;
            while (n)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display Student");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. Find Student");
                Console.WriteLine("5. Exit");


                Console.WriteLine("Choose option");
                int option= Convert.ToInt32(Console.ReadLine());
                switch (option) {
                     case 1:
                        student s = new student();
                        Console.Write("Enter id:");
                        s.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter name:");
                        s.Name = Console.ReadLine();
                        Console.Write("Enter age:");
                        s.Age = Convert.ToInt32(Console.ReadLine());

                        manager.Add(s);
                        Console.WriteLine("Student added successfully");
                        break;
                    case 2:
                        manager.View();
                        break;
                    case 3:
                        Console.WriteLine("Enter id you want to delete:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        manager.Delete(id);
                        Console.WriteLine("Student deleted successfully");
                        break;
                    case 4:
                        Console.WriteLine("Enter ID:");
                        int p= Convert.ToInt32(Console.ReadLine());
                        var res=manager.FindStudent(p);
                        res.Display(); 
                        break;
                    case 5:
                        n = false;
                        break;
                }
            }

        }
    }
}
