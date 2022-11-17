// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int Prompt(string message)
{
    Console.Write(message);
    int lenght = int.Parse(Console.ReadLine());
    return lenght;
}


double[] CreateArray(int length, int min, int max)
{
    double[] tempArray = new double[length];
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = new Random().Next(min, max);
    }
    return tempArray;
}

int[] tempArray = CreateArray();