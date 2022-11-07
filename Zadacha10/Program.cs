Console.Write("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number <= 999)
{
    int s = (number / 10) % 10;
    Console.Write("Вторая цифра трехзначного числа:" + s);
}
else
{
    Console.WriteLine("Введенное число не трехзначное");
}