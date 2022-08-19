void Cubes(int numberN)
{
    for (int i = 1; i <= numberN; i++)
    {
        double cube = Math.Pow(i, 3);
        Console.Write(cube + " ");
    }
}

Console.WriteLine("Введите число N (большее или равное 1)");
int N = int.Parse(Console.ReadLine());
if (N >= 1)
{
    Console.WriteLine("Таблица кубов от 1 до " + N + ":");
    Cubes(N);
}
else
{
    Console.WriteLine("Попробуйте еще раз!");
}