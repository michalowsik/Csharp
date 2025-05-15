using System;

namespace Coding.Exercise
{
    public class GradeCalculator
    {
        static void Main(string[] args)
        {
            static string CalculateGrade(double percentage)
            
                
            {
                if (percentage >= 90)
                    return "A";
                else if (percentage >= 80)
                    return "B";
                else if (percentage >= 70)
                    return "C";
                else if (percentage >= 60)
                    return "D";
                else
                    return "E";
            }

            Console.WriteLine("Podaj % wynik testu:");
            string input = Console.ReadLine();

            bool success = double.TryParse(input, out double percentage);

            if (!success)
            {
                Console.WriteLine("Nieprawidłowy format liczby.");
                return;
            }
            string result = CalculateGrade(percentage);
            Console.WriteLine($"Ocena: {result}");
        }
    }
}