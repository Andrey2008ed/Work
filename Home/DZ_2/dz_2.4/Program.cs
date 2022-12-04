string DayNumber(int num)
{
    if (num > 5)
        return $"{num} выходной";
    else    
        return $"{num} рабочий день";
}   

Console.WriteLine("Введите день недели:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(DayNumber(number));