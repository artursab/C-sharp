using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_student
{
    class Student
    {

            public Guid id;
            public string firstname;
            public string lastname;
            public string middlename;
            public int age;
            public string group;


        public void Print()
        {
            Console.WriteLine("Informastion about student");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Lastname: {lastname}");
            Console.WriteLine($"Name: {firstname}");
            Console.WriteLine($"Middlename: {middlename}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Group: {group}");
        }

        public string GetFullName()
        {
            return $"{firstname}{lastname}{middlename}";
        }

    }
}
