using System;
using System.Linq;

namespace Mod2Review;

public class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public List<double> Grades { get; set; } = new List<double>();

    public void AddGrade(double studentGrade)
    {
        Grades.Add(studentGrade);
    }

    public void AddGrades(params double[] grades)
    {
        Grades.AddRange(grades);
    }

    public double CalculateAverageGrade()
    {
        if (Grades.Count == 0)
        {
            return 0;
        }
        else
        {
            var average = Grades.Sum() / Grades.Count;
            return average;
        }
    }


}