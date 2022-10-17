// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static System.Console;
Clear();
Write("Введите положительное число n ");
int n = Convert.ToInt32(ReadLine());
int m = 1;

WriteLine(NumFromNtoM(n, m));

int NumFromNtoM(int n1, int m1)
{
    if (n1 == m1)
        return n1;
    else
        Write($"{NumFromNtoM(n1, m1 + 1)}, ");
    return m1;
}