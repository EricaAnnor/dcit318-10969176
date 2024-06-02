using System;

class GradeCalculator
{
    static void Main()
    {
        // Prompt the user to enter a numerical grade
        Console.Write("Enter a numerical grade between 0 and 100: ");
        string input = Console.ReadLine();
        
        // Validate and parse the input
        if (int.TryParse(input, out int grade) && grade >= 0 && grade <= 100)
        {
            // Determine the letter grade based on the numerical grade
            char letterGrade = GetLetterGrade(grade);

            // Display the corresponding letter grade
            Console.WriteLine($"The letter grade for {grade} is: {letterGrade}");
        }
        else
        {
            // Handle invalid input
            Console.WriteLine("Invalid input. Please enter a numerical grade between 0 and 100.");
        }
    }

    // Method to determine the letter grade based on the numerical grade
    static char GetLetterGrade(int grade)
    {
        if (grade >= 90)
        {
            return 'A';
        }
        else if (grade >= 80)
        {
            return 'B';
        }
        else if (grade >= 70)
        {
            return 'C';
        }
        else if (grade >= 60)
        {
            return 'D';
        }
        else
        {
            return 'F';
        }
    }
}
