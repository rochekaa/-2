using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите задачу:");
            Console.WriteLine("1 - Двоичная в десятичную");
            Console.WriteLine("2 - Десятичная в двоичную");
            Console.WriteLine("3 - Время доставки");
            Console.WriteLine("0 - Выход");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": BinaryToDecimal(); break;
                case "2": DecimalToBinary(); break;
                case "3": DeliveryTime(); break;
                case "0": return;
                default: Console.WriteLine("Неверный выбор"); break;
            }

            Console.WriteLine();
        }
    }

    static void BinaryToDecimal()
    {
        Console.Write("Введите двоичное число: ");
        string binary = Console.ReadLine();

        int result = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            result = result * 2 + (binary[i] - '0');
        }

        Console.WriteLine($"Результат: {result}");
    }

    static void DecimalToBinary()
    {
        Console.Write("Введите десятичное число: ");
        int number = int.Parse(Console.ReadLine());

        string result = "";
        while (number > 0)
        {
            result = (number % 2) + result;
            number /= 2;
        }

        result = result == "" ? "0" : result;
        Console.WriteLine($"Результат: {result}");
    }

    static void DeliveryTime()
    {
        Console.Write("Введите часы: ");
        int hours = int.Parse(Console.ReadLine());

        Console.Write("Введите минуты: ");
        int minutes = int.Parse(Console.ReadLine());

        Console.Write("Введите время доставки: ");
        int delivery = int.Parse(Console.ReadLine());

        int totalMinutes = hours * 60 + minutes + delivery;
        int resultHours = (totalMinutes / 60) % 24;
        int resultMinutes = totalMinutes % 60;

        Console.WriteLine($"Время доставки: {resultHours:D2}:{resultMinutes:D2}");
    }
}