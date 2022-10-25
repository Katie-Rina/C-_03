Console.Clear();
bool PalindromeYesNo (int number)
{
    bool pal = false;
    if ((number / 10000 == number % 10) && (number / 1000 % 10 == number % 100 / 10))
    {
        pal = true;
    }
    return pal;
}
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 | number > 99999)
{
    Console.WriteLine("Число не пятизначное");
}
else
{
    bool p = PalindromeYesNo(number);
    if (p == true) Console.WriteLine("Палиндром");
    else Console.WriteLine("Не палиндром");
}