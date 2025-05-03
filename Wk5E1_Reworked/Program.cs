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
        static List<int> grades = new List<int>();
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

                //switch for menu options
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
                        CalculateAverage();
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
            }
            while (choice != 6); //loop until user exits
        }

                //create method
                static void AddGrade()
                {
           
                    Console.WriteLine("Enter a grade 0-100:");//user input
                    int grade = Convert.ToInt32(Console.ReadLine()); //varaible to hold grade

                    if (grade >= 0 && grade <= 100) //process
                    {
                        grades.Add(grade);
                        Console.WriteLine("grade added."); //output

                    }
                    else
                    {
                        Console.WriteLine("Invalid grade, Enter 0-100."); //output

                    }


                }
                //create method
                static void RemoveGrade()
                {
                    Console.WriteLine("Enter a grade to remove: "); //input
                    int grade = Convert.ToInt32(Console.ReadLine()); //variabel to hold input

                    //process
                    if (grades.Remove(grade))
                    {
                        Console.WriteLine("grade removed.");
                    }
                }
                static void DisplayGrades() //method
                {
                    //process
                    if (grades.Count == 0)
                    {
                        Console.WriteLine("no grades to display.");//output
                        return;
                    }
                    Console.WriteLine("grades: ") //output
                    foreach (int grade in grades) //loop through each grade
                    {
                        Console.WriteLine(grade); //output
                    }
                }
                //method
                static void CalculateAverage()
                {
                    //process
                    if (grades.Count == 0)
                    {
                        Console.WriteLine("no grades to average");//output
                        return;
                    }
                    double average = 0;
                    foreach (int grade in grades)
                    {
                        average += grade;
                    }
                    average /= grades.Count;
                    Console.WriteLine("Averages grade: " + average); //output
                }
                //method
                static void HighestandLowest()
                {
                    if (grades.Count == 0)
                    {
                        Console.WriteLine("no grades");
                        return;
                    }
                    //set to smallest & largest
                    int max = int.MinValue;
                    int min = int.MaxValue;

                    foreach (int grade in grades)//loop through each grade
                    {
                //process
                        if (grade > max) max = grade; //if current grade is greater than current max, update max
                        if (grade < min) min = grade; //if current grade is less than current min, update min


                    }
                    //output
                    Console.WriteLine("highest grade:  " + max + "   lowest grade:  " + min);
                }

            }


        }
    






