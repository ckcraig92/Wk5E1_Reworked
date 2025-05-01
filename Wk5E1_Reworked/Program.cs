using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk5E1_Reworked
{
    internal class Program
    {
        //creating list for grades
        static List<string> grades = new List<string>();
        static void Main(string[] args)
        {
            int choice;
            do
            {
                //menu options
                Console.WriteLine("Welcome to Grade Management Application");
                Console.WriteLine("1. Add Grade");
                Console.WriteLine("2. Remove Grade");
                Console.WriteLine("3. Display Grades");
                Console.WriteLine("4. Calculate Average");
                Console.WriteLine("5. Find Highest & Lowest Grade");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice: ");

                //convert choice to integer
                choice = Convert.ToInt32(Console.ReadLine());

                //switch
                switch (choice)
                {
                    case 1:
                        AddGrade();
                        break;
                    case 2:
                        RemoveGrade();
                        break;
                    case 3:
                        DisplayGrades();
                        break;
                    case 4:
                        Calculateverage();
                        break;
                    case 5:
                        HighestandLowest();
                        break;
                    case 6:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;

                }
                //create method
                static void AddGrade();
                {
                    Console.WriteLine("Enter a grade 0-100:");
                    int grade = Convert.ToInt32(Console.ReadLine());

                    if (grade >= 0 && grade <= 100)
                    {
                        grades.Add(grade);
                        Console.WriteLine("grade added.");

                    }
                    else
                    {
                        Console.WriteLine("Invalid grade, Enter 0-100.");

                    }


                }
                //create method
                static void RemoveGrade()
                {
                    Console.WriteLine("Enter a grade to remove: ");
                    int grade = Convert.ToInt32(Console.ReadLine());

                    if (grade.Remove(grade))
                    {
                        Console.WriteLine("grade removed.");
                    }
                }
                static void DisplayGrades()
                {
                    if (grades.Count == 0)
                    {
                        Console.WriteLine("no grades to display.");
                        return;
                    }
                    Console.WriteLine("grades: ");
                    foreach (int grade in grades)
                    {
                        Console.WriteLine(grade);
                    }
                }
                //method
                static void Calculateaverage()
                {
                    if (grades.Count == 0)
                    {
                        Console.WriteLine("no grades to average");
                        return
}
                    double average = 0;
                    foreach (int grade in grades)
                    {
                        average += grade;
                    }
                    average /= grades.Count;
                    Console.WriteLine("Averages grade" + average);
                }
                //method
                static void HighestandLowest;
                    {
                    if (grades.Count == 0)
                    {
                        Console.WriteLine("no grades");
                        return;
                    }
                    int max = int.MaxValue;
                    int min = int.MinValue;

                    foreach (int grade in grades)
                    {
                        if (grade > max) max = grade;
                        if (grade < min) min = grade;


                    }
                    Console.WriteLine("highest grade : " + max + "lowest grade: " + min);

                }


            }
}
    }
}

