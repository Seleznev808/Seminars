Console.WriteLine("Введите трехзначное число");
string number = Console.ReadLine();
if (number.Length != 3)
{
    Console.WriteLine("Попробуйте снова!");
}
else
{
    Console.WriteLine("Вторая цифра вашего числа - " + number[1]);
}