

namespace OOP_student
{





    class Program
    {

        static Student GetStudent()
        {
            var student = new Student();

            student.firstname = "Maxim";
            student.middlename = "Vanya";
            student.lastname = "Kirilov";
            student.age = 18;
            student.id = Guid.NewGuid();
            student.group = "GV11";

            return student;
        }



        static void Main(string[] args)
        {
            var student1 = GetStudent();

            student1.Print();

            string fullname = student1.GetFullName();
        }

        
    }


}

