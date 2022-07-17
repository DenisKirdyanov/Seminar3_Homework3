// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("введите координаты x, y, z первой точки");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("введите координаты x, y, z второй точки");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());

double Distance(int xA, int yA, int zA, int xB, int yB, int zB)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow((xA - xB), 2) + Math.Pow((yA - yB), 2) + Math.Pow((zA - zB), 2));
    return result;
}

Console.WriteLine($"Расстояние между точками равно: {Distance(x1, y1, z1, x2, y2, z2)}");