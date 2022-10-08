// Программа проверяет пятизначное число на палиндромом
Console.WriteLine("Введите пятизначное число");
int a = int.Parse (Console.ReadLine () );
int a10 =a%10;
int a10000 =a/10000;
int a1000 =a/1000%10;
int a100 = a/10%10;
if (a10==a10000 && a100==a1000)
{
    Console.WriteLine("Число " + a + " палиндром ");
}
else
{
     Console.WriteLine("Число " + a+ " не палиндром ");

}    
    