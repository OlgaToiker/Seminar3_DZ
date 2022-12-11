// Напишите программу, которая на вход принимает
// пятизначное число и проверяет, является ли оно
// палиндромом. 
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите пятизначное число: ");
int num = Math.Abs(int.Parse(Console.ReadLine()!));
int num1= num / 1000;
int num2= num % 100;
int num3 = num2 % 10*10 + num2 / 10;
if (num < 10000 || num > 99999)
{Console.WriteLine("Введенное число не пятизначное!!!");}
    else if (num1==num3)
        {Console.WriteLine($"{num} -> да");}
        else Console.WriteLine($"{num} -> нет");