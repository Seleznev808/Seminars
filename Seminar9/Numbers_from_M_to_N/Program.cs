int NumbersFromMtoN(int m, int n)
{
    if (m < n) 
    {
        Console.Write($"{m} ");
        return NumbersFromMtoN(m + 1, n);
    }
    else return n;
}

Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение n, большее m: ");
int n = int.Parse(Console.ReadLine());
Console.Write(NumbersFromMtoN(m, n));