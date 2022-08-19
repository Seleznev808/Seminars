void Palindrom(string str)
{
    if (str[0] == str[4] && str[1] == str[3])
    {
        Console.WriteLine("Число " + str + " - палиндром");
    }
    else
    {
        Console.WriteLine("Число " + str + " - не является палиндромом");
    }
}

Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
Palindrom(number);