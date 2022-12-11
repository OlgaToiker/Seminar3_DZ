//Напишите программу, которая принимает на вход координаты
//двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты первой точки (A): ");
Console.Write("Введите координаты точки Х: ");
float x = float.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки Y: ");
float y = float.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки Z: ");
float z = float.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты второй точки (B): ");
Console.Write("Введите координаты точки Х1: ");
float x1 = float.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки Y1: ");
float y1 = float.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки Z1: ");
float z1 = float.Parse(Console.ReadLine()!);

float sum = MathF.Pow((x - x1), 2) + MathF.Pow((y - y1), 2) + MathF.Pow((z - z1), 2);

Console.WriteLine($"A({x}, {y}, {z}); B({x1}, {y1}, {z1}) -> {MathF.Round(MathF.Sqrt(sum), 2)}");