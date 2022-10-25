// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.Clear();
Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N <= 0 )
{
    Console.WriteLine("Число не натуральное");
}
else
{
    for (int i = 1; i < N; i++)
    {
        Console.Write($"{Math.Pow(i,3)}, ");
    }
    Console.WriteLine($"{Math.Pow(N,3)}.");
}

