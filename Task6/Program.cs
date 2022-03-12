Console.Clear();
int [] num = new int [12];
int sum = 0;
Console.WriteLine("Получившийся массив: ");
for (int i = 0; i < num.Length; i++)
{
    num[i] = new Random().Next(0,10);
    sum += num[i];
    Console.Write(num[i] + " ");
}
Console.WriteLine();
Console.Write("Сумма элементов массива равна: ");
Console.WriteLine(sum);