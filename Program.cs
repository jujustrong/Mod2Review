using System;
using System.Linq;

namespace Mod2Review;

class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>();

        var physics = new Course("Physics", "PHYS");
        var literature = new Course("Literature", "LIT");
        var artHistory = new Course("Art History", "ART");
        var health = new Course("Health", "HLTH");
        
        var student1 = new Student("Greg", 477614);        //Creating new students
        students.Add(student1);                                   //Adding students to Student list
        physics.EnrollStudent(student1);                          //enrolling students in courses
        health.EnrollStudent(student1);
        
        var student2 = new Student("Jenny", 877343);
        students.Add(student2);
        literature.EnrollStudent(student2);
        artHistory.EnrollStudent(student2);
        
        var student3 = new Student("Lance", 348721);
        students.Add(student3);
        physics.EnrollStudent(student3);
        artHistory.EnrollStudent(student3);
        
        var student4 = new Student("Ellen", 400232);
        students.Add(student4);
        literature.EnrollStudent(student4);
        health.EnrollStudent(student4);
        
        student1.AddGrade(95.2);                                 //Using the AddGrade method in Student class
        student1.AddGrade(85.0, 84.5, 92.1);
        student2.AddGrade(98.2);
        student2.AddGrade(95.0, 94.5, 92.5);
        student3.AddGrade(86.0);
        student3.AddGrade(77.0, 72.0, 82.1);
        student4.AddGrade(88.0);
        student4.AddGrade(87.0, 76.4, 83.6);

        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Name}\tID#: {student.ID}");
            double average = student.CalculateAverageGrade();               //new variable to get average grade
            Console.WriteLine($"Avg Grade: {average}");
            foreach (var grade in student.Grades)
            {
                Console.WriteLine($"Grades: {grade}");
            }
        }
        
        physics.DisplayRoster();                                            //displaying roster of each course
        health.DisplayRoster();
        artHistory.DisplayRoster();
        literature.DisplayRoster();
        
    }
}