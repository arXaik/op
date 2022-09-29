Console.WriteLine("Введите х:");
int x = int.Parse(Console.ReadLine());
int x1 = x / 1000;
int x2 = (x % 1000) / 100;
int x3 = (x % 100) / 10;
int x4 = x % 10;
int x12 = x1 + x2;
int x34 = x3 + x4;
int xall = x1 + x2 + x3 + x4;
if (x12 == x34)
{
    Console.WriteLine("Сумма первых двух цифр равна сумме двух последних");
}
else
{
    Console.WriteLine("Сумма первых двух цифр равна сумме двух последних");
}
if (xall % 7 == 0)
{
    Console.WriteLine("Сумма цифр чила x кратана 7");
}
else
{
    Console.WriteLine("Сумма цифр чила x не кратана 7");
}