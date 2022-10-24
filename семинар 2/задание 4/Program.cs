// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number > 7)
    {
        Console.WriteLine("Введено число больше 7");
        return false;
    }
    return true;
}

int dayWeek = Prompt("Введите натуральное целое число от 1 до 7, что бы узнать выходной ли это день =>");
if (ValidateNumber(dayWeek))
{
    if (dayWeek > 5)
    {
        Console.WriteLine("Да, выходной");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}