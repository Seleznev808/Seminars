Console.WriteLine("Введите порядковый номер дня недели");
int number = int.Parse(Console.ReadLine());
if (number > 7 | number < 1)
{
    Console.WriteLine("Попробуйте снова!");
}
else if (number == 6 | number == 7)
{
    Console.WriteLine("Этот день выходной!");
}
else
{
    Console.WriteLine("Этот день будний");
}