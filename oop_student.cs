
class Student
{
    public Guid id;
    public string firstname;
    public string lastname;
    public string middlename;
    public int age;
    public string group;

}


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
        student.group= "GV11";

        return student;
    }
    

    static void Print(Student student)
    {
        Console.WriteLine("Informastion about student");
        Console.WriteLine($"Id: {student.id}");
        Console.WriteLine($"Lastname: {student.lastname}");
        Console.WriteLine($"Name: {student.firstname}");
        Console.WriteLine($"Middlename: {student.middlename}");
        Console.WriteLine($"Age: {student.age}");
        Console.WriteLine($"Group: {student.group}");
    }

    static void Main(string[] args)
    {
        var student1 = GetStudent();

        Print(student1);
    }
}
