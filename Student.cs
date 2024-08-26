using System;
using System.Linq;

namespace Mod2Review;

public class Student
{
    public string Name { get; set; }                    //creating properties for each student
    public int ID { get; set; }
    public List<double> Grades { get; set; }

    public Student(string name, int id)
    {
        Name = name;
        ID = id;
        Grades = new List<double>();
    }
    
    public void AddGrade(double studentGrade)
    {
        Grades.Add(studentGrade);                         //Adding grade to grades list
    }

    public void AddGrade(params double[] grades)          //using params to add several grades
    {
        Grades.AddRange(grades);
    }

    public double CalculateAverageGrade()
    {
        if (Grades.Count == 0)
        {
            return 0;                                   // Handles case where there are no grades
        }
        return Grades.Average();
    }
    


}