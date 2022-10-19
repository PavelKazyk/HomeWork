// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите число =>");
int N = Convert.ToInt32(Console.ReadLine());
int printNumber = 0;
Console.Write("Четные числа от 1 до введенного значения: ");
while (printNumber <= N-4)
{
    printNumber = printNumber + 2;
    Console.Write($"{printNumber}, ");
}
Console.WriteLine(printNumber+2);
