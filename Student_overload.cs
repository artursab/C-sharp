

using System.Data;

namespace Student
{

    class Student
    {

        public Student(string lastname, DateTime birthdate)
        { 
            _lastname = lastname;
            _birthday = birthdate;
        }

        public Student(string lastname, string firstname, string middlename, DateTime birthdate)
        {
            _lastname = lastname;
            _birthday = birthdate;
            _firstname = firstname;
            _middlename = middlename;
        }

        public Student(Student student)
        {
            _lastname = student._lastname;
            _birthday = student._birthday;
            _firstname = student._firstname;
            _middlename = student._middlename;
        }


        public void SetLastName(string lastName)
        {
            _lastname = lastName;
        }

        private string _firstname;
        private string _middlename;
        private string _lastname;
        private DateTime _birthday;


        public void Print()
        {
            Console.WriteLine($"Name: {_firstname}\nLastName: {_lastname}\n Middle Name: {_middlename}\n Birthday: {_birthday}\n");
        }


    }


    class Program
    {


        static void Main(string[] args)
        {
            Student student = new Student("Kamnbia", new DateTime(2000,20,2));

            Student student2 = new Student(student);

            student.SetLastName("Bebris");           
            
            student.Print();

            Console.WriteLine();
            
            student2.Print();
        }
    }
}