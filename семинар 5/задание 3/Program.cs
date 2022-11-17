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
    double [] tempArray = new double [length];
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = new Random() .Next(min, max) + new Random() .NextDouble();
    }
    return tempArray;
}

void PrintArray(double[] intArray)
{
    System.Console.Write($"{intArray[0]:f2}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]:f2}");
    }
    System.Console.WriteLine();
}

double MaxVal(double[] array)
{
    double maxVal = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i]>maxVal)
        {
            maxVal = array[i];
        }
        
    }
    return maxVal;
}

double MinVal(double[] array)
{
    double minVal = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i]<minVal)
        {
            minVal = array[i];
        }
        
    }
    return minVal;
}

int lenght = Prompt("Введите длинну массива   ");
int min = Prompt("Введите минимальное число   ");
int max = Prompt("Введите максимальное число  ");

double[] tempArray = CreateArray(lenght, min, max);

PrintArray(tempArray);

double minVal = MinVal(tempArray);
double maxVal = MaxVal(tempArray);

System.Console.WriteLine($"Разници между максимальным и минимальным значениями равна {maxVal-minVal}");