// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string Check(string str)
{
    int i = 0;
    int j = 0;
    int n = str.Length;
    int k = n / 2;
   
    while (i < k)
    {
        if (str[i] == str[(n - 1) - i]) j = j + 1;
        else j = 0;
        i = i + 1;
    }

    if (j == str.Length / 2) str = "является";
    else str = "не является";
    return str;
}

Console.WriteLine("Введите число");
string number = Console.ReadLine();

Console.WriteLine(Check(number));