Console.WriteLine("Введите число");
int numberA = int.Parse(Console.ReadLine());

if (numberA <= 1)
{
    Console.WriteLine("Введите число большее или равное 2");
}

int counter = 2;

while (counter <= numberA)
{
    Console.Write(counter + " ");
    counter += 2;
}