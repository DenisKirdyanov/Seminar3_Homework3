// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

void Func(int n)
{
    Console.WriteLine($"таблица кубов от 1 до {n}:");
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{i} в кубе: {Math.Pow(i, 3)}");
    }
}

Func(number);