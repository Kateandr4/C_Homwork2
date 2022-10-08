// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("введите введите номер четверти");
int a = int.Parse(Console.ReadLine() ?? "0");
if (a==1)
{
    Console.WriteLine("координаты для " + a + " четверти х>0, y>0" );
}
else if (a==2)
    {
        Console.WriteLine("координаты для " + a + " четверти х<0, y>0" );
    }
    else if (a==3)
        {
            Console.WriteLine("координаты для " + a + " четверти х<0, y<0" );
        }
        else if (a==4)
            {       
                Console.WriteLine("координаты для " + a + " четверти х>0, y<0" );
            }
            else 
            {
                Console.WriteLine("Заданное число не является четвертью" );
            }
