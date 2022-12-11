//Напишите программу, которая принимает на вход координаты
// точки (X и Y), причем X и Y не равны 0, и выдает номер
// четверти плоскости, в которой находится эта точка

Console.Write("Введите координату X: ");
int X = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Y: ");
int Y = int.Parse(Console.ReadLine()!);

if (X > 0 && Y > 0) Console.WriteLine("I");
if (X < 0 && Y > 0) Console.WriteLine("II");
if (X < 0 && Y < 0) Console.WriteLine("III");
if (X > 0 && Y < 0) Console.WriteLine("IV");