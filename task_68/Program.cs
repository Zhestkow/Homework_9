// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using static System.Console;
Clear();
Write("Введите положительное число M ");
int M = Convert.ToInt32(ReadLine());
Write("Введите положительное число N ");
int N = Convert.ToInt32(ReadLine());

WriteLine(Akkerman(M, N));

int Akkerman(int m1, int n1)
{
    if (m1 == 0)
        return n1 + 1;
    if (m1 > 0 && n1 == 0)
        return Akkerman(m1 - 1, 1);
    else
        return Akkerman(m1 - 1, Akkerman(m1, n1 - 1));
}