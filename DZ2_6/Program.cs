// Найти расстояние между точками в пространстве 3D
Console.WriteLine("Введите координату Х 1 точки");
int X1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координату Y 1 точки");
int Y1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координату Z 1 точки");
int Z1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координату Х 2 точки");
int X2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координату Y 2 точки");
int Y2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координату Z 2 точки");
int Z2 = int.Parse(Console.ReadLine() ?? "0");
int X = 0;
int Y = 0;
int Z = 0;
double L = 0;
if (X1<=X2 && Y1<=Y2 && Z1<=Z2 )
{
 X= X2-X1;
 Y=Y2-Y1;
 Z=Z2-Z1;
 L= Math.Sqrt(X*X+Y*Y+Z+Z);
 Console.WriteLine("Растояние между точками = "+ L );
}
else if (X1>=X2 && Y1>=Y2 && Z1>=Z2)
    {
    X= X1-X2;
    Y=Y1-Y2;
    Z=Z1-Z2;
    L= Math.Sqrt(X*X+Y*Y+Z*Z);
    Console.WriteLine("Растояние между точками = "+ L );
    }  


