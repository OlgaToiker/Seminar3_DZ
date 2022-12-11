//Напишите программу, которая принимает на вход координаты
//двух точек и находит расстояние между ними в 2D пространстве.

Console.WriteLine("Введите координаты первой точки (A): ");
Console.Write("Введите координаты точки Х: ");
float x = float.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки Y: ");
float y = float.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты первой точки (B): ");
Console.Write("Введите координаты точки Х1: ");
float x1 = float.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки Y1: ");
float y1 = float.Parse(Console.ReadLine()!);

float diffx = (x-x1);
float kvadratx = MathF.Pow(diffx, 2);

float diffy = (y - y1);
float kvadraty = MathF.Pow(diffy, 2);

float sum = kvadratx + kvadraty;

Console.WriteLine($"Расстояние между двумя точками (А и B): {MathF.Round(MathF.Sqrt(sum),2)}.");