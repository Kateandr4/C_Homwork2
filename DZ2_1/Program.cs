// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("введите число обозначающее день недели");
int day = int.Parse(Console.ReadLine());

if  (day >0 && day <8)
{ 
    if (day <6)
    Console.WriteLine("Увы, это будний день");
    else 
    Console.WriteLine("Ура, это выходной !");
}
else 
Console.WriteLine("число введено некорректно");