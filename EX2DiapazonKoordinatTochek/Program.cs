//Напишите программу, которая по заданному номеру
//четверти, показывает диапазон возможных координат
//точек в этой четверти (x и y)

Console.WriteLine("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine()!);

if (num > 4) Console.WriteLine("Такой плоскости не существует. Введите число от 1 до 4!");
if (num == 1) Console.WriteLine("Координаты X: от 0 до +oo. Координаты Y: от 0 до +oo.");
if (num == 2) Console.WriteLine("Координаты X: от 0 до -oo. Координаты Y: от 0 до +oo.");
if (num == 3) Console.WriteLine("Координаты X: от 0 до -oo. Координаты Y: от 0 до -oo.");
if (num == 4) Console.WriteLine("Координаты X: от 0 до +oo. Координаты Y: от 0 до -oo.");