﻿Console.Clear();
Console.Write("Введите конечное число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    Console.WriteLine(i*i*i);
}