﻿//Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

Console.WriteLine("Введите любое число NNN");
int n = Convert.ToInt32(Console.ReadLine());

if (n <= 99)
{
    Console.WriteLine("Введено число меньше трехзначного");
}
if (n >= 100 && n <= 999)
{
    Console.WriteLine("Введено " + n);
    Console.WriteLine("Последняя цифра = " + n%10);
}
if (n >= 1000)
{
    Console.WriteLine("Введено число больше трехзначного");
}
//----------------------------------------------
//Короткое решение:

//Console.WriteLine("Введите число");
//string number = Console.ReadLine();
//int num = Convert.ToInt32(number);
//int c=num%10;

//Console.Write(c );