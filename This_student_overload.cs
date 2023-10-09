using System.Data;

namespace Student
{

    class Student
    {

        public Student(string lastname, DateTime birthdate)
        { 
            this.lastname = lastname;
            this.birthdate = birthdate;
        }

        public Student(string lastname, string firstname, string middlename, DateTime birthdate):this(lastname, birthdate)
        {
            _firstname = firstname;
            _middlename = middlename;
        }


        public void SetLastName(string lastname)
        {
            this.lastname = lastname;
        }

        private string _firstname;
        private string _middlename;
        private string lastname;
        private DateTime birthdate;


        public void Print()
        {
            Console.WriteLine($"Name: {_firstname}\nLastName: {lastname}\n Middle Name: {_middlename}\n Birthday: {birthdate}\n");
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