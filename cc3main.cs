using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Part 1
        Console.WriteLine("Weight in Pounds (lbs):");
        double pounds = Convert.ToDouble(Console.ReadLine());

        double kilograms = pounds * 0.453592;
        Console.WriteLine("Kilograms (kg) = " + kilograms);
        Console.WriteLine("====================================");

        Console.WriteLine("Length in Miles (mi):");
        double miles = Convert.ToDouble(Console.ReadLine());

        double kilometers = miles * 1.609344;
        Console.WriteLine("Kilometers (km) = " + kilometers);
        Console.WriteLine("====================================");

        Console.WriteLine("Temperature in Fahrenheit (°F):");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 0.556;
        Console.WriteLine("Celsius (°C) = " + celsius);
        Console.WriteLine("====================================");

        int numberOfStudents = 10;
        int[] ages = new int[numberOfStudents];

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.Write($"Age of Student {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out ages[i]))
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
                Console.Write($"Age of Student {i + 1}: ");
            }
        }

        double sum = 0;
        for (int i = 0; i < numberOfStudents; i++)
        {
            sum += ages[i];
        }
        double averageAge = sum / numberOfStudents;

        Console.WriteLine($"Average age of the students is: {averageAge:F2} years");
        Console.WriteLine("====================================");

        // Part 2
        // A.
        Console.Write("Input: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            Console.WriteLine("\nNumber Pattern:");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }

        // B.
        Console.Write("Input: ");
        if (int.TryParse(Console.ReadLine(), out int num) && num > 0)
        {
            string formula = string.Join(" + ", Enumerable.Range(1, num));
            Console.WriteLine($"Formula: {formula}");

            int sumResult = (num * (num + 1)) / 2;
            Console.WriteLine($"Output: {sumResult}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }

        // C.
        Console.Write("Input: ");
        if (int.TryParse(Console.ReadLine(), out int anotherN) && anotherN > 0)
        {
            Console.WriteLine("\nNumber Pattern:");

            for (int i = 1; i <= anotherN; i++)
            {
                for (int j = 1; j <= anotherN - i + 1; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }
}
