//  Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Не использовать строки для расчета.

// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNamber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Число меньше 100");
        return false;
    }
    return true;
}

int number = Prompt("Введите число от 100 и выше =>");
int findDigit = number;
if (ValidateNamber(number))
{
    while (findDigit > 999)
    {
        findDigit = findDigit / 10;
    }
  int result = findDigit%100;
    result = result/10;
    Console.WriteLine($"Вывод => {result}");
}
