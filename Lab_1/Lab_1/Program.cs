using System;

class Program
{
    static void Main()
    {
        string[] cars = { "Кросовер", "Купе", "Седан", "Унiверсал" };
        double[] prices = { 850000, 1200000, 700000, 950000 };

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Нашi автомобiлi:\n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        for (int i = 0; i < cars.Length; i++)
            Console.WriteLine($"{i + 1}. {cars[i]} — {prices[i]} грн");

        Console.ForegroundColor = ConsoleColor.White;
        int[] quantities = new int[cars.Length];
        for (int i = 0; i < cars.Length; i++)
        {
            Console.Write($"\nСкiльки {cars[i]} бажаєте купити? ");
            quantities[i] = int.Parse(Console.ReadLine());
        }

        double total = 0;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nВартiсть кожного типу авто:");
        Console.ForegroundColor = ConsoleColor.Green;
        for (int i = 0; i < cars.Length; i++)
        {
            double sum = prices[i] * quantities[i];
            Console.WriteLine($"{cars[i]}: {prices[i]} x {quantities[i]} = {sum} грн");
            total += sum;
        }

        Random rnd = new Random();
        double discountPercent = rnd.Next(5, 11);
        double discount = total * discountPercent / 100;
        double toPay = total - discount;

        total = Math.Round(total, 2);
        discount = Math.Round(discount, 2);
        toPay = Math.Round(toPay, 2);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n===============================");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Загальна сума: {total} грн");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Знижка ({discountPercent}%): -{discount} грн");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"До сплати: {toPay} грн");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("===============================\n");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Дякуємо за покупку!");

        Console.ResetColor();
    }
}
