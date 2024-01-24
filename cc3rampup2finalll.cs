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

string character1 = "Zoro";
string character2 = "Luffy";
string character3 = "Sanji";
string character4 = "Nami";
string equipment = "Wado Ichimonji";
string item = "Gum Gum Fruit";
string ability1 = "Onigiri";
string ability2 = "Hell Memories";
string ability3 = "Navigation Skills";
string fantasyStory = $"In the heart of the New World, amidst towering waves and perilous sea creatures, the Straw Hat Pirates Zoro, Sanji, Nami, and Ussop led by the ever-grinning Monkey D. Luffy, stood unyielding on the deck of their beloved Thousand Sunny. With the indomitable spirit of their captain and the bonds of their crew, they faced each new challenge with unwavering resolve, sailing ever closer to the enigmatic island of Raftel, where the ultimate treasure, the One Piece, awaited." +
$"{character1} wielded the {equipment} with unmatched skill, while {character2} wields the paramecia devil fruit {item}, said to hold immense power." +
$"As they journeyed deeper into the grand line, {character2} used the Three-Sword Style Technique called {ability1} to slice through lurking dangers, while {character3} held off against the gigantic monster using his powerful kick move called {ability2}." +
$"But it was {character4}'s {ability3} that carried them away from these dangers." +
$"Together, they faced countless trials and tribulations, their names echoing through the annals of history as the Strawhat Pirates.";

Console.WriteLine(fantasyStory);
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