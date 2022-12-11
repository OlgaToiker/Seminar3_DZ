// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел
// от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
double N = double.Parse(Console.ReadLine()!);
Console.Write($"{N} -> ");
for (double i = 1; i <= N; i++)
{
    double result = i * i * i;

    //int result = i * i * i;
    if (i < N) { Console.Write($"{result}, "); }
    else Console.Write($"{result}");
}