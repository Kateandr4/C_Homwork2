// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("введите число 1");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите число 2");
int b = int.Parse(Console.ReadLine());
if (a == b*b) 
{
   Console.WriteLine("число " + a + " является квадратом числа  " + b); 
}
if (b == a*a) 
{
   Console.WriteLine("число " + b + " является квадратом числа  " + a); 
}
else 
{
    Console.WriteLine( " Квадрата числа нет"); 
}