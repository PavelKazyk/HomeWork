// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

double Exponent(int A, int B)
{
double result = Math.Pow(A, B);
System.Console.WriteLine($"Число {A} в степени {B} равно {result}");
return result;
}

int A = Prompt("Введите число  =>  ");
int B = Prompt("Введите степень  =>  ");

Exponent(A, B);


