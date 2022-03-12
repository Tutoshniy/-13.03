Console.Clear();
Console.WriteLine("Введите конечное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int proizv = 1;
for (int i = 1; i <= N; i++)
{
    proizv *= i;
}
Console.Write("Произведение чисел равно ");
Console.WriteLine(proizv);