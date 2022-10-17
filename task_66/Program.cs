// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30




using static System.Console;
Clear();
Write("Введите положительное число M ");
int M = Convert.ToInt32(ReadLine());
Write("Введите положительное число N ");
int N = Convert.ToInt32(ReadLine());

WriteLine(NumSumFromMtoN(M, N));

int NumSumFromMtoN(int m1, int n1)
{
    if (m1 == n1)
        return n1;
    return (n1 > m1) ? n1 + NumSumFromMtoN(m1, n1 - 1) : m1 + NumSumFromMtoN(n1, m1 - 1);
}