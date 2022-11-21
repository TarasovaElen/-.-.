Console.WriteLine("Введите число:");
int A = Convert.ToInt32(Console.ReadLine());

if (A%2 == 1)
{
    Console.WriteLine($"нечетное {A}.");
}
else
{
    Console.WriteLine($"четное {A}.");
}