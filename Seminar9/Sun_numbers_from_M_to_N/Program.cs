int SumNumbersFromMToN(int m, int n)
{
    if (m == n) return m;
    else return m + SumNumbersFromMToN(m + 1, n);
}

Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение n, большее m: ");
int n = int.Parse(Console.ReadLine());
Console.Write(SumNumbersFromMToN(m, n));