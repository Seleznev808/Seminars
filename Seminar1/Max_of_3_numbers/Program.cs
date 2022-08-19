Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число");
int numberD = int.Parse(Console.ReadLine());

int maxNumber = numberA;

if (numberB > maxNumber)
{
    maxNumber = numberB;
}

if (numberD > maxNumber)
{
    maxNumber = numberD;
}

Console.WriteLine("Максимальное из этих трех чисел - " + maxNumber);