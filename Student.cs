using System;


/// <summary>
/// Represents a Student with attributes such as student ID, first name, last name, and grade.
/// </summary>

// Class representing a Student
public class Student
{
    // Private attributes
    public int studentID;
    private string firstName;
   public string lastName;
      public double grade;

    // Default constructor
    public Student()
    {
        // Default values
        studentID = 0;
        firstName = "Emma";
        lastName = "Watson";
        grade = 98;
    }

    // Parameterized constructor
    public Student(int id, string fName, string lName, double grade)
    {
        this.studentID = id;
        this.firstName = fName;
        this.lastName = lName;
        this.Grade = grade; // Using property to set grade with validation
    }
 
    public int StudentID
    {
        get { return studentID; }
        set { studentID = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public double Grade
    {
        get { return grade; }
        set
        {
            // Validation for grade  between 0 and 100
            if (value >= 0 && value <= 100)
            {
                grade = value;
            }
            else
            {
                throw new ArgumentException("Grades must be between 0 and 100.");
            }
        }
    }

    // Method to display student details
    public  virtual void DisplayDetails()
    {
        // virtual keyword used to enable subclasses to override the DisplayDetails()
        Console.WriteLine("Student ID: " + studentID);
        Console.WriteLine("Name: " + firstName + " " + lastName);
        Console.WriteLine("Grade: " + grade);
    }
}
