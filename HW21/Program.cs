// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.Clear();
double DetermDistance (int x1, int x2, int y1,int y2, int z1, int z2)
{
    double dist = Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2));
    return dist;
}
Console.Write("Введите координату x первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double d = DetermDistance(x1, x2, y1, y2, z1, z2);

Console.WriteLine($"Расстояние между точками = {Math.Round(d,2)}");


