// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Sum(int number)
{
    int sum =0;
    int div = number;
    while (div > 0)
    {
        int temp = div % 10;
        div = div / 10;
        sum = sum + temp;
    }
    System.Console.WriteLine($"Сумма цифр в числе {number} равна => {sum}");
    return sum;
}

int number = Prompt("Введите число => ");

Sum(number);
