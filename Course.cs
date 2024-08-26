using System;

namespace Mod2Review;

public class Course
{
    public string CourseName { get; set; }
    public string CourseCode { get; set; }
    public List<Student> EnrolledStudents { get; set; }

    public Course(string courseName, string courseCode)
    {
        CourseName = courseName;
        CourseCode = courseCode;
        EnrolledStudents = new List<Student>();
    }

    public void EnrollStudent(Student student)
    {
        if (EnrolledStudents.Contains(student) == false)
        {
            EnrolledStudents.Add(student);
        }
    }

    public void DisplayRoster()
    {
        Console.WriteLine($"{CourseName} Roster: ");
        foreach (var student in EnrolledStudents)
        {
            Console.WriteLine($"Name: {student.Name}, ID: {student.ID}");
        }
    }
    
}