// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Без использования строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateNumber(int number)
{
    if (number < 10000 || number > 99999)
    {
        Console.WriteLine("Введено не пятизначное число");
        return false;
    }
    return true;
}

int ValidatePalindrom(int number)
{
    int x = number / 1000;
    int y = (number % 100) % 10 * 10 + (number % 100) / 10;
    return x - y;
}


void result(int number)
{
  if (ValidatePalindrom(number) == 0)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}  
}


int number = Prompt("Введите пятизначное число => ");

if(ValidateNumber(number))
{
    result(ValidatePalindrom(number));
}