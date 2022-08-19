double SumDigits (string number)
{
    double sum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        sum += Char.GetNumericValue(number[i]);
    }
    return sum;
}

Console.WriteLine("Введите число");
string number = Console.ReadLine();
Console.WriteLine("Сумма цифр в числе " + number + " - " + SumDigits(number));