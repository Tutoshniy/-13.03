Console.Clear();
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int Sum = 0;
for (; N > 0; N /= 10)
{
    Sum += N%10;
}
Console.Write("Сумма цифр числа равна ");
Console.WriteLine(Sum);
