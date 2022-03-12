Console.Clear();
Console.Write("Введите конечное число: ");
int A = Convert.ToInt32(Console.ReadLine());
int Sum = 0;
for (int i = 1; i <= A; i++)
{
    Sum += i;
}
Console.Write("Сумма цифр равна: ");
Console.WriteLine(Sum);