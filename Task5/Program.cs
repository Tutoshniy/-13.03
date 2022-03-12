Console.Clear();
int [] num = new int [8];
for (int i = 0; i < num.Length; i++)
{
    num[i] = new Random().Next(0, 2);
    Console.Write(num[i]);
    Console.Write(" ");
}
