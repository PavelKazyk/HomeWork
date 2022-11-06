// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int x1 = Prompt("Введите координату х точки А: ");
int y1 = Prompt("Введите координату y точки А: ");
int z1 = Prompt("Введите координату z точки А: ");
int x2 = Prompt("Введите координату x точки B: ");
int y2 = Prompt("Введите координату y точки B: ");
int z2 = Prompt("Введите координату z точки B: ");

int x = x2 - x1;
int y = y2 - y1;
int z = z2 - z1;

double Lenght = Math.Sqrt(x * x + y * y + z * z);

Console.WriteLine($"Расстояние между точками А и В равно {Lenght:f2}");