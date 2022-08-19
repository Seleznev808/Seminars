int Exponentiation (int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
    return result;
}

Console.WriteLine("Введите число А");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное число В");
int numberB = int.Parse(Console.ReadLine());

if (numberB < 0)
{
    Console.WriteLine("Попробуйте еще раз!");
}
else
{
    Console.WriteLine();
    Console.WriteLine(numberA + " ^ "+ numberB + " = " + Exponentiation (numberA, numberB));
}