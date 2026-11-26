using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student Management System

            //Student profile

            Console.WriteLine("Enter your name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("City: ");
            string city = Console.ReadLine();

            Console.WriteLine("Enter a group letter: ");
            char groupLetter = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Is student full time? (true/false): ");
            bool isFullTime = Convert.ToBoolean(Console.ReadLine());

            double myAge = age;
            int ageNextYear = age;
            ageNextYear++;
            int agePreviousYear = age;
            agePreviousYear--;


            Console.WriteLine(" ");


            //Academic performance
            Console.WriteLine("Enter first grade: ");
            double grade1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second grade: ");
            double grade2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter third grade: ");
            double grade3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");

            double average = (grade1 + grade2 + grade3) / 3;

            bool hasPassed = average >= 3.00;
            bool hasExcellentGrade = average >= 5.50;
            bool eligibleForScholarship = average >= 5.50 && isFullTime;
            bool isAdult = age >= 18;
            bool isAdultFullTimeStudent = age >= 18 && isFullTime;
            bool isAdultOrFullTimeStudent = age >= 18 || isFullTime;


            //Personal budget manager
            Console.WriteLine("Enter a monthly budget:");
            decimal monthlyBudget = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter a regular expenses: ");
            decimal regularExpenses = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter extra expenses: ");
            decimal extraExpenses = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter savings: ");
            decimal savings = Convert.ToDecimal(Console.ReadLine());

            decimal totalExpenses = regularExpenses + extraExpenses;
            decimal remainingBudget = monthlyBudget - regularExpenses - extraExpenses;
            decimal budgetAfterIncrease = monthlyBudget;
            budgetAfterIncrease += 100m;
            decimal totalSum = budgetAfterIncrease + savings;

            bool isBudgetEnough = monthlyBudget >= totalExpenses;
            bool hasSavings = savings > 0;
            bool hasRemainingMoney = remainingBudget > 0;

            Console.WriteLine(" ");


            //Advanced calculator
            Console.WriteLine("Enter a number: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a second number: ");
            double y = Convert.ToDouble(Console.ReadLine());

            int z = (int)x;
            bool firstGreater = x > y;
            bool equalNum = x == y;
            bool firstSmallOrEqual = x <= y;
            bool diffNumber = x != y;

            Console.WriteLine(" ");


            //Math toolkit
            Console.WriteLine("Enter a circle radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;

            Console.WriteLine(" ");

            //Text analizer
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();

            Console.WriteLine("Enter a key word to search: ");
            string searchWord = Console.ReadLine();

            Console.WriteLine("Replacement word: ");
            string replacementWord = Console.ReadLine();

            string updateSentence = sentence.Replace(searchWord, replacementWord);



            Console.WriteLine(" ");

            Console.WriteLine("========================");
            Console.WriteLine("Student management system".ToUpper());
            Console.WriteLine("========================\n");

            Console.WriteLine("---student profile---".ToUpper());
            Console.WriteLine($"Full name: {firstName} {lastName}");

            Console.WriteLine($"City: {city.ToUpper()}");

            Console.WriteLine($"Is full time: {isFullTime}");

            Console.WriteLine($"Group letter: {groupLetter}");

            Console.WriteLine($"Age in months: {age * 12}");

            Console.WriteLine($"Age next year: {ageNextYear}");

            Console.WriteLine($"Age previousYear: {agePreviousYear}");

            Console.WriteLine($"Age: {myAge}\n");



            Console.WriteLine("---academic performance---".ToUpper());
            Console.WriteLine($"Grade 1 - {grade1}");
            Console.WriteLine($"Grade 2 - {grade2}");
            Console.WriteLine($"Grade 3 - {grade3}");
            Console.WriteLine($"Average grade: {average}");
            Console.WriteLine($"Passed: {hasPassed}");
            Console.WriteLine($"Excellent grade: {hasExcellentGrade}");
            Console.WriteLine($"Eligible for scholarship: {eligibleForScholarship}");
            Console.WriteLine($"Adult student: {isAdult}");
            Console.WriteLine($"Is adult full time student: {isAdultFullTimeStudent}");
            Console.WriteLine($"Is adult or full time student: {isAdultOrFullTimeStudent}");
            Console.WriteLine($"Is sudent part time: {!isFullTime}\n");


            Console.WriteLine("---personal budget---".ToUpper());
            Console.WriteLine($"Monthly budget: {monthlyBudget}");
            Console.WriteLine($"Regular expenses: {regularExpenses}");
            Console.WriteLine($"Extra expenses: {extraExpenses}");
            Console.WriteLine($"Total expenses: {totalExpenses}");
            Console.WriteLine($"Remaining budget: {remainingBudget}");
            Console.WriteLine($"Budget with bonus: {budgetAfterIncrease}");
            Console.WriteLine($"Savings: {savings}");
            Console.WriteLine($"Has savings: {hasSavings}");
            Console.WriteLine($"Budget with savings: {totalSum}");
            Console.WriteLine($"Is budget enough: {isBudgetEnough}");
            Console.WriteLine($"Has remaining money: {hasRemainingMoney}\n");


            Console.WriteLine("---advanced calculator---".ToUpper());
            Console.WriteLine($"First number as integer: {z}");
            Console.WriteLine($"Addition: {x + y}");
            Console.WriteLine($"Subtraction: {x - y}");
            Console.WriteLine($"Multiplication: {x * y}");
            Console.WriteLine($"Division: {x / y}");
            Console.WriteLine($"Remainder of division: {x % y}");
            Console.WriteLine($"First number is greater: {firstGreater}");
            Console.WriteLine($"Is numbers are equals: {equalNum}");
            Console.WriteLine($"First number is smaller or equal to second: {firstSmallOrEqual}");
            Console.WriteLine($"Are numbers are different: {diffNumber}\n");


            Console.WriteLine("---math toolkit---".ToUpper());
            Console.WriteLine($"Square root: {Math.Sqrt(Math.Abs(x))}");
            Console.WriteLine($"Absolute value: {Math.Abs(x)}");
            Console.WriteLine($"Round: {Math.Round(x)}");
            Console.WriteLine($"Ceiling: {Math.Ceiling(x)}");
            Console.WriteLine($"Floor: {Math.Floor(x)}");
            Console.WriteLine($"Pow: {Math.Pow(x, 2)}");
            Console.WriteLine($"Max: {Math.Max(x, y)}");
            Console.WriteLine($"Min: {Math.Min(x, y)}");
            Console.WriteLine($"Area: {Math.Round(area, 2)}");
            Console.WriteLine($"Circumference: {Math.Round(circumference, 2)}\n");


            Console.WriteLine("---text analizer---".ToUpper());
            Console.WriteLine($"Upper sentence: {sentence.ToUpper()}");
            Console.WriteLine($"Lower sentence: {sentence.ToLower()}");
            Console.WriteLine($"Trim: {sentence.Trim()}");
            Console.WriteLine($"Sentence length: {sentence.Length}");
            Console.WriteLine($"Contains the word: {sentence.Contains(searchWord)}");
            Console.WriteLine($"Index: {sentence.IndexOf(searchWord)}");
            Console.WriteLine($"Substring: {sentence.Substring(0, 4)}");
            Console.WriteLine($"Replace sentence: {updateSentence}");
            Console.WriteLine($"Sentence start with: {sentence.StartsWith("I")}");
            Console.WriteLine($"Sentence end with: {sentence.EndsWith(".")}\n");


            Console.WriteLine("===========================================");
        }
    }
}
