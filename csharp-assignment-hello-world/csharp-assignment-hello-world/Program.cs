using System;

class FinalProject
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== MAIN MENU =====");
            Console.WriteLine("1. Operators Exercises");
            Console.WriteLine("2. Control Flow Exercises");
            Console.WriteLine("0. Exit");
            Console.Write("Choose option: ");
            int mainChoice = int.Parse(Console.ReadLine());

            if (mainChoice == 0) break;

            switch (mainChoice)
            {
                case 1:
                    OperatorsMenu();
                    break;
                case 2:
                    ControlFlowMenu();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    // =========================
    // Operators Exercises
    // =========================
    static void OperatorsMenu()
    {
        Console.WriteLine("\n--- Operators Menu ---");
        Console.WriteLine("1. Basic operations (+,-,*,/)");
        Console.WriteLine("2. Function x = y^2 + 2y + 1 (-5 <= y <= 5)");
        Console.WriteLine("3. Calculate speed (km/h & miles/h)");
        Console.WriteLine("4. Sphere surface & volume");
        Console.WriteLine("5. Character check (vowel, digit, symbol)");
        Console.Write("Choose exercise (1-5): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: BasicOperations(); break;
            case 2: FunctionValues(); break;
            case 3: SpeedCalc(); break;
            case 4: SphereCalc(); break;
            case 5: CharCheck(); break;
            default: Console.WriteLine("Invalid choice!"); break;
        }
    }

    static void BasicOperations()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter operator (+,-,*,/): ");
        char op = Console.ReadLine()[0];

        double result = 0;
        switch (op)
        {
            case '+': result = a + b; break;
            case '-': result = a - b; break;
            case '*': result = a * b; break;
            case '/': result = b != 0 ? a / b : double.NaN; break;
            default: Console.WriteLine("Invalid operator!"); return;
        }
        Console.WriteLine($"Result: {a} {op} {b} = {result}");
    }

    static void FunctionValues()
    {
        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;
            Console.WriteLine($"y = {y}, x = {x}");
        }
    }

    static void SpeedCalc()
    {
        Console.Write("Enter distance in km: ");
        double dist = double.Parse(Console.ReadLine());
        Console.Write("Enter hours: ");
        int h = int.Parse(Console.ReadLine());
        Console.Write("Enter minutes: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Enter seconds: ");
        int s = int.Parse(Console.ReadLine());

        double timeHours = h + m / 60.0 + s / 3600.0;
        double speedKmH = dist / timeHours;
        double speedMilesH = speedKmH / 1.609;

        Console.WriteLine($"Speed: {speedKmH:F2} km/h, {speedMilesH:F2} miles/h");
    }

    static void SphereCalc()
    {
        Console.Write("Enter radius: ");
        double r = double.Parse(Console.ReadLine());
        double surface = 4 * Math.PI * r * r;
        double volume = 4.0 / 3.0 * Math.PI * Math.Pow(r, 3);
        Console.WriteLine($"Surface = {surface:F2}, Volume = {volume:F2}");
    }

    static void CharCheck()
    {
        Console.Write("Enter a character: ");
        char c = Console.ReadLine()[0];

        if ("aeiouAEIOU".Contains(c))
            Console.WriteLine($"{c} is a vowel.");
        else if (char.IsDigit(c))
            Console.WriteLine($"{c} is a digit.");
        else if (char.IsLetter(c))
            Console.WriteLine($"{c} is a consonant.");
        else
            Console.WriteLine($"{c} is a symbol.");
    }

    // =========================
    // Control Flow Exercises
    // =========================
    static void ControlFlowMenu()
    {
        Console.WriteLine("\n--- Control Flow Menu ---");
        Console.WriteLine("1. Check even or odd");
        Console.WriteLine("2. Largest of three numbers");
        Console.WriteLine("3. Determine quadrant of a coordinate point");
        Console.Write("Choose exercise (1-3): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: EvenOdd(); break;
            case 2: LargestOfThree(); break;
            case 3: QuadrantCheck(); break;
            default: Console.WriteLine("Invalid choice!"); break;
        }
    }

    static void EvenOdd()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n % 2 == 0 ? $"{n} is Even" : $"{n} is Odd");
    }

    static void LargestOfThree()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int c = int.Parse(Console.ReadLine());

        int largest = a;
        if (b > largest) largest = b;
        if (c > largest) largest = c;

        Console.WriteLine($"The largest number is {largest}");
    }

    static void QuadrantCheck()
    {
        Console.Write("Enter X coordinate: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter Y coordinate: ");
        int y = int.Parse(Console.ReadLine());

        if (x == 0 && y == 0)
            Console.WriteLine($"Point ({x},{y}) is at the Origin.");
        else if (x > 0 && y > 0)
            Console.WriteLine($"Point ({x},{y}) lies in the First quadrant.");
        else if (x < 0 && y > 0)
            Console.WriteLine($"Point ({x},{y}) lies in the Second quadrant.");
        else if (x < 0 && y < 0)
            Console.WriteLine($"Point ({x},{y}) lies in the Third quadrant.");
        else if (x > 0 && y < 0)
            Console.WriteLine($"Point ({x},{y}) lies in the Fourth quadrant.");
        else if (x == 0)
            Console.WriteLine($"Point ({x},{y}) lies on the Y-axis.");
        else
            Console.WriteLine($"Point ({x},{y}) lies on the X-axis.");
    }
}
