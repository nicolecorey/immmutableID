using System;

class Student
{
    // auto-implemented properties
    public int Id { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Student(int id)
    {
        Id = id;
        FirstName = string.Empty;
        LastName = string.Empty;
    }

    // default constructor
    public Student()
    {
        Id = 0;
        FirstName = "";
        LastName = "";
    }
    // parameterized constructor
    public Student(int i, string First, string Last)
    {
        Id = i;
        FirstName = First;
        LastName = Last;
    }

    public static void Main()
    {
        Student student = new(1);
        student.FirstName = "Peter";
        student.LastName = "Parker";
        Console.WriteLine($"ID: {student.Id}   Name: {student.FirstName + " " + student.LastName}");

        Student student2 = new(2,"Tony", "Stark");
        Console.WriteLine($"ID: {student2.Id}   Name: {student2.FirstName + " " + student2.LastName}");

    }
}