Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число");
int b = Convert.ToInt32(Console.ReadLine());

if ( a > b) 
{
    Console.WriteLine($"Число {a} больше числа {b}");
}
else if (a < b)
{
    Console.WriteLine($"Число {a} меньше числа {b}");
}
else
{
    Console.WriteLine($"Число {a} равно числу {b}");
}