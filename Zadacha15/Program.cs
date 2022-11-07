Console.Write("Введите число дня недели:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 1 | number < 7)
{
    switch (number)
    {
        case 1:
            Console.WriteLine("Это не выходной");
            break;
        case 2:
            Console.WriteLine("Это не выходной");
            break;
        case 3:
            Console.WriteLine("Это не выходной");
            break;
        case 4:
            Console.WriteLine("Это не выходной");
            break;
        case 5:
            Console.WriteLine("Это не выходной");
            break;
        case 6:
            Console.WriteLine("Да, это выходной!");
            break;
        case 7:
            Console.WriteLine("Да, это выходной!");
            break;
    }
}
else
{
    Console.WriteLine("Не соответствует ни одному дню недели");
}
