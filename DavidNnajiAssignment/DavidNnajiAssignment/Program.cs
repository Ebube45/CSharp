using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Select a question number (e.g., 1.1 for Question 1, Part 1):");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1.1": ValidateNumberInRange(); break;
            case "1.2": FindMaxOfTwoNumbers(); break;
            case "1.3": DetermineImageOrientation(); break;
            case "1.4": SpeedCamera(); break;
            case "2.1": CountDivisiblesByThree(); break;
            case "2.2": SumUntilOk(); break;
            case "2.3": CalculateFactorial(); break;
            case "2.4": NumberGuessingGame(); break;
            case "2.5": FindMaxFromCommaSeparatedNumbers(); break;
            case "3.1": FacebookLikesSimulation(); break;
            case "3.2": ReverseUserName(); break;
            case "3.3": CollectUniqueSortedNumbers(); break;
            case "3.4": CollectAndDisplayUniqueNumbers(); break;
            case "3.5": DisplayThreeSmallestNumbers(); break;
            case "4.1": CheckIfNumbersAreConsecutive(); break;
            case "4.2": DetectDuplicatesInHyphenatedInput(); break;
            case "4.3": ValidateTimeFormat(); break;
            case "4.4": ConvertToPascalCase(); break;
            case "4.5": CountVowelsInWord(); break;
            case "5.1": CountWordsInFile(); break;
            case "5.2": FindLongestWordInFile(); break;
            default: Console.WriteLine("Invalid selection."); break;
        }
    }

    static void ValidateNumberInRange()
    {
        Console.Write("Enter a number between 1 and 10: ");
        if (int.TryParse(Console.ReadLine(), out int num) && num >= 1 && num <= 10)
            Console.WriteLine("Valid");
        else
            Console.WriteLine("Invalid");
    }

    static void FindMaxOfTwoNumbers()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Max: {Math.Max(num1, num2)}");
    }

    static void DetermineImageOrientation()
    {
        Console.Write("Enter image width: ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("Enter image height: ");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine(width > height ? "Landscape" : width < height ? "Portrait" : "Square");
    }

    static void SpeedCamera()
    {
        Console.Write("Enter speed limit: ");
        int speedLimit = int.Parse(Console.ReadLine());
        Console.Write("Enter car speed: ");
        int carSpeed = int.Parse(Console.ReadLine());
        if (carSpeed <= speedLimit) { Console.WriteLine("Ok"); return; }
        int demeritPoints = (carSpeed - speedLimit) / 5;
        Console.WriteLine($"Demerit Points: {demeritPoints}");
        if (demeritPoints > 12) Console.WriteLine("License Suspended");
    }

    static void CountDivisiblesByThree()
    {
        Console.WriteLine($"Count: {Enumerable.Range(1, 100).Count(n => n % 3 == 0)}");
    }

    static void SumUntilOk()
    {
        int sum = 0;
        while (true)
        {
            Console.Write("Enter a number (or 'ok' to exit): ");
            string input = Console.ReadLine();
            if (input.ToLower() == "ok") break;
            sum += int.Parse(input);
        }
        Console.WriteLine($"Sum: {sum}");
    }

    static void CalculateFactorial()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int factorial = Enumerable.Range(1, num).Aggregate(1, (a, b) => a * b);
        Console.WriteLine($"{num}! = {factorial}");
    }

    static void NumberGuessingGame()
    {
        Random random = new Random();
        int secret = random.Next(1, 11);
        Console.WriteLine("(Secret: " + secret + ")");
        for (int i = 0; i < 4; i++)
        {
            Console.Write("Guess (1-10): ");
            if (int.Parse(Console.ReadLine()) == secret) { Console.WriteLine("You won!"); return; }
        }
        Console.WriteLine("You lost!");
    }

    static void FindMaxFromCommaSeparatedNumbers()
    {
        Console.Write("Enter numbers separated by commas: ");
        Console.WriteLine($"Max: {Console.ReadLine().Split(',').Select(int.Parse).Max()}");
    }

    static void FacebookLikesSimulation()
    {
        List<string> names = new List<string>();
        while (true)
        {
            Console.Write("Enter a name (or press Enter to finish): ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name)) break;
            names.Add(name);
        }
        Console.WriteLine(names.Count switch
        {
            1 => $"{names[0]} likes your post.",
            2 => $"{names[0]} and {names[1]} like your post.",
            _ => $"{names[0]}, {names[1]} and {names.Count - 2} others like your post."
        });
    }

    static void ReverseUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        char[] nameArray = name.ToCharArray();
        Array.Reverse(nameArray);
        Console.WriteLine("Reversed Name: " + new string(nameArray));
    }

    static void CollectUniqueSortedNumbers()
    {
        HashSet<int> numbers = new HashSet<int>();
        while (numbers.Count < 5)
        {
            Console.Write("Enter a unique number: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (!numbers.Add(num))
                    Console.WriteLine("Error: Number already entered.");
            }
            else
                Console.WriteLine("Invalid input.");
        }
        List<int> sortedNumbers = numbers.ToList();
        sortedNumbers.Sort();
        Console.WriteLine("Sorted Numbers: " + string.Join(", ", sortedNumbers));
    }

    static void CollectAndDisplayUniqueNumbers()
    {
        HashSet<int> uniqueNumbers = new HashSet<int>();
        while (true)
        {
            Console.Write("Enter a number (or type 'Quit' to exit): ");
            string input = Console.ReadLine();
            if (input.Equals("Quit", StringComparison.OrdinalIgnoreCase)) break;
            if (int.TryParse(input, out int number)) uniqueNumbers.Add(number);
        }
        Console.WriteLine("Unique Numbers: " + string.Join(", ", uniqueNumbers));
    }

    static void DisplayThreeSmallestNumbers()
    {
        while (true)
        {
            Console.Write("Enter at least 5 numbers separated by commas: ");
            List<int> numbers = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            if (numbers.Count < 5)
                Console.WriteLine("Invalid List. Enter at least 5 numbers.");
            else
            {
                numbers.Sort();
                Console.WriteLine("Three Smallest Numbers: " + string.Join(", ", numbers.Take(3)));
                break;
            }
        }
    }

    static void CheckIfNumbersAreConsecutive()
    {
        Console.Write("Enter numbers separated by hyphens: ");
        List<int> numbers = Console.ReadLine().Split('-').Select(int.Parse).ToList();
        bool isConsecutive = numbers.Zip(numbers.Skip(1), (a, b) => b - a).All(diff => diff == 1 || diff == -1);
        Console.WriteLine(isConsecutive ? "Consecutive" : "Not Consecutive");
    }

    static void DetectDuplicatesInHyphenatedInput()
    {
        Console.Write("Enter numbers separated by hyphens: ");
        List<int> numbers = Console.ReadLine().Split('-').Select(int.Parse).ToList();
        bool hasDuplicate = numbers.Count != numbers.Distinct().Count();
        Console.WriteLine(hasDuplicate ? "Duplicate" : "No Duplicates");
    }

    static void ValidateTimeFormat()
    {
        Console.Write("Enter a time (HH:mm): ");
        string input = Console.ReadLine();
        Console.WriteLine(TimeSpan.TryParse(input, out _) ? "Ok" : "Invalid Time");
    }

    static void ConvertToPascalCase()
    {
        Console.Write("Enter words: ");
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string pascalCase = string.Join("", Console.ReadLine().Split(' ').Select(word => textInfo.ToTitleCase(word.ToLower())));
        Console.WriteLine("PascalCase: " + pascalCase);
    }

    static void CountVowelsInWord()
    {
        Console.Write("Enter a word: ");
        string input = Console.ReadLine().ToLower();
        int vowelCount = input.Count(c => "aeiou".Contains(c));
        Console.WriteLine("Vowel Count: " + vowelCount);
    }

    static void CountWordsInFile()
    {
        Console.Write("Enter file path: ");
        string filePath = Console.ReadLine();
        if (File.Exists(filePath))
            Console.WriteLine("Word Count: " + File.ReadAllText(filePath).Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length);
        else
            Console.WriteLine("File not found.");
    }

    static void FindLongestWordInFile()
    {
        Console.Write("Enter file path: ");
        string filePath = Console.ReadLine();
        if (File.Exists(filePath))
        {
            string longestWord = File.ReadAllText(filePath)
                .Split(new[] { ' ', '\t', '\n', '.', ',', ';', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderByDescending(w => w.Length)
                .FirstOrDefault();
            Console.WriteLine("Longest Word: " + (longestWord ?? "No words found"));
        }
        else
            Console.WriteLine("File not found.");
    }
}


