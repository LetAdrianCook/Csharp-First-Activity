using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp_First_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            var subjectList = new List<string> { };
            var gradeList = new List<float> { };
            string name, grading, response;
            int subjectCount;
            float sum, totalPercentageSubjects, finalAverage;
            bool run = true;

            do
            {
                try
                {
                    Console.Write("Please Enter Your Name: ");
                    name = Console.ReadLine();
                    Console.Write("Please how many subjects you currently take: ");
                    subjectCount = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < subjectCount; i++)
                    {
                        Console.Write("Please Enter Subject Number " + (i + 1) + ": ");
                        string subjectName = Console.ReadLine();
                        subjectList.Add(subjectName);
                    }
                    Console.WriteLine();
                    for (int i = 0; i < subjectCount; i++)
                    {
                        Console.Write("Please Enter your grade for " + subjectList[i] + ": ");
                        float subjectGrade = Convert.ToSingle(Console.ReadLine());
                        gradeList.Add(subjectGrade);
                    }
                    sum = gradeList.Sum();
                    totalPercentageSubjects = (subjectCount / 100.0f);
                    finalAverage = sum / (totalPercentageSubjects * 100.0f);

                    if (finalAverage >= 75) grading = "Passed";
                    else grading = "Failed";

                    Console.WriteLine();
                    Console.WriteLine("--------------------Grading-System--------------------");
                    Console.WriteLine("Name : " + name);
                    Console.WriteLine("-----------------------Subjects-----------------------");
                    for (int i = 0; i < subjectCount; i++)
                    {
                        Console.WriteLine(subjectList[i] + " : " + gradeList[i]);
                    }
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("Your Final Average is : " + finalAverage);
                    Console.WriteLine("Grading               : " + grading);
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("Calculate another student grade? [type 'yes' to proceed] [Input any keys to exit]");
                    response = Console.ReadLine();
                    Console.WriteLine();

                    if (response.Equals("yes"))
                    {
                        subjectList.Clear();
                        gradeList.Clear();
                        run = true;
                    }
                    else run = false;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Error! Invalid input value.");
                }
            }
            while (run != false);

        }
    }
}
