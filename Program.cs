using System;

/// <summary>
/// Entry point of the program. Demonstrates the use of the Student and Teacher classes.
/// </summary>
class Program
{
    static void Main()
    {
        // Showing Student class
        Console.WriteLine(" Presenting Student class:");
        Student student1 = new Student(123, "Emma", "Watson", 98);
        student1.DisplayDetails();

        Console.WriteLine();

        Student student2 = new Student(101, "Daniel", "Radcliffe", 85.5);
        student2.DisplayDetails();

        Console.WriteLine();

        // Showing Teacher class
        Console.WriteLine(" Presenting Teacher class:");
        Teacher teacher1 = new Teacher(108, "Harshil", "Parekh", 0, "Tech");
        teacher1.Teach();
        Console.WriteLine("Teacher's Details:");
        teacher1.DisplayDetails();
    }
}
