// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArray(int length, int min, int max)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max);
    }
    return tempArray;
}



int SumOdd(int[] array)
{
    int sum = 0;
   for (int i = 0; i < array.Length; i++)
       {
        if(array[i]%2>0)
        {
            sum += array[i];
        }
           }
    System.Console.WriteLine($"сумма нечетных чисел равно => {sum}");       
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

int[] tempArray = CreateArray(5, 1, 10);

PrintArray(tempArray);

SumOdd(tempArray);