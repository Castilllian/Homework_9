// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;

int Prompt(string message) // Ввод числа с консоли
{
    Write(message);
    return Convert.ToInt32(ReadLine()!);
}

int m = Prompt("M = ");
int n = Prompt("N = ");

Write(Sum(m, n));

int Sum(int m, int n)
{
    if (n == m)
    {
        return m;
    }
    
    int result = n + Sum(m, n-1);
    return result;
}