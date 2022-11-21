Console.WriteLine("Введите первое число: ");
int num_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num_B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num_С = Convert.ToInt32(Console.ReadLine());

int max=num_A;

if (num_B > max)
{
    Console.WriteLine($"маx {max=num_B}");
}
if (num_С > max)
{
    Console.WriteLine($"маx {max=num_С}");
}
{
    Console.WriteLine($"максимальное значение {max}");
}