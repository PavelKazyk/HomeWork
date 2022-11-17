// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArray(int length, int min, int max)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max);
    }
    return tempArray;
}



int SumEven(int[] array)
{
    int sum = 0;
    foreach (int item in array)
    {
        if(item%2==0)
        {
            sum += 1;
        }
           }
    System.Console.WriteLine($"колл-во четных чисел равно => {sum}");       
    return sum;       
}

void PrintArray(int[] intArray)
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
    System.Console.WriteLine();
}

int[] tempArray = CreateArray(10, 100, 1000);

PrintArray(tempArray);

SumEven(tempArray);


