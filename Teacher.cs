using System;


/// <summary>
/// Represents a Teacher, which inherits from the Student class, with an additional subject attribute.
/// </summary>
 
public class Teacher : Student
{
    private string subject;
   
    public Teacher(int id, string fName, string lName, double grade, string sub)
    { 
        this.FirstName = fName;
        this.lastName = lName;    
        this.subject = sub;          // Set the subject that the teacher will teach
    }


    // Method to teach
    public void Teach()
    {
        Console.WriteLine("Mr./Ms. " + LastName + " is teaching " + subject + ".");
    }

    /// <summary>
    /// Overrides the DisplayDetails method from the Student class to provide teacher-specific details.
    /// Displays the teacher's name and the subject they teach.
    /// </summary>
    public override void DisplayDetails()
    {
        Console.WriteLine("Teacher Name: " + FirstName + " " + LastName);
        Console.WriteLine("Subject: " + subject);
    }
}
