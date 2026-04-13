using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Velkommen til Den Intelligente Assistenten!");
        Console.Write("Skriv inn ditt navn: ");
        string name = Console.ReadLine();
        Console.Write("Skriv inn din bursdag (DD.MM.YYYY): ");
        string birthday = Console.ReadLine();

        Greet(name, birthday);

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nVelg en oppgave:");
            Console.WriteLine("1. Kalkulator");
            Console.WriteLine("2. Passordsjekk");
            Console.WriteLine("3. Temperaturanalyse");
            Console.WriteLine("4. Avslutt");
            Console.Write("Ditt valg: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Calculator();
                    break;
                case "2":
                    PasswordCheck();
                    break;
                case "3":
                    TemperatureCheck();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Ugyldig valg.");
                    break;
            }
        }
    }

    static void Greet(string name, string birthday)
    {
        int hour = DateTime.Now.Hour;
        string greeting;
        if (hour < 12)
        {
            greeting = "God morgen";
        }
        else if (hour < 18)
        {
            greeting = "God dag";
        }
        else
        {
            greeting = "God kveld";
        }

        if (TryParseBirthday(birthday, out DateTime birthDate))
        {
            var nextBirthday = GetNextBirthday(birthDate);
            int age = nextBirthday.Year - birthDate.Year;
            int daysUntil = (nextBirthday - DateTime.Today).Days;
            Console.WriteLine($"{greeting}, {name}! Det er {daysUntil} dager til du fyller {age} år.");
        }
        else
        {
            Console.WriteLine($"{greeting}, {name}! (Ugyldig bursdagsformat)");
        }
    }

    static bool TryParseBirthday(string input, out DateTime birthDate)
    {
        return DateTime.TryParseExact(input, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out birthDate);
    }

    static DateTime GetNextBirthday(DateTime birthDate)
    {
        var today = DateTime.Today;
        var thisYearBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);
        if (thisYearBirthday < today)
        {
            return thisYearBirthday.AddYears(1);
        }
        return thisYearBirthday;
    }

    static void Calculator()
    {
        Console.WriteLine("Velg type kalkulering:");
        Console.WriteLine("1. To tall");
        Console.WriteLine("2. Liste av tall");
        string type = Console.ReadLine();
        if (type == "1")
        {
            Console.Write("Første tall: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Andre tall: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Summen er: {Add(a, b)}");
        }
        else if (type == "2")
        {
            Console.Write("Antall tall: ");
            int n = int.Parse(Console.ReadLine());
            List<double> numbers = new List<double>();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Tall {i + 1}: ");
                numbers.Add(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"Summen er: {Add(numbers)}");
        }
        else
        {
            Console.WriteLine("Ugyldig valg.");
        }
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Add(List<double> numbers)
    {
        double sum = 0;
        foreach (double num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    static void PasswordCheck()
    {
        Console.Write("Skriv inn passord: ");
        string password = Console.ReadLine();
        int length = password.Length;
        if (length < 8)
        {
            Console.WriteLine("Svakt passord");
        }
        else if (length <= 12)
        {
            Console.WriteLine("Medium passord");
        }
        else
        {
            Console.WriteLine("Sterkt passord");
        }
    }

    static void TemperatureCheck()
    {
        Console.Write("Skriv inn temperatur: ");
        double temp = double.Parse(Console.ReadLine());
        if (temp < 0)
        {
            Console.WriteLine("Det er kaldt ute");
        }
        else if (temp <= 20)
        {
            Console.WriteLine("Det er behagelig");
        }
        else
        {
            Console.WriteLine("Det er varmt ute");
        }
    }
}