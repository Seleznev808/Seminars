int[,] Array(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMeanColumns(int[,] arr)
{
    double arithMeanColumns = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            arithMeanColumns += arr[i, j];
        }
        arithMeanColumns = arithMeanColumns / arr.GetLength(0);
        Console.WriteLine($"Среднее арифметическое {j} столбца: {arithMeanColumns:f2}");
        arithMeanColumns = 0;
    }
}

int rows = 3;
int columns = 4;
int[,] array = Array(rows, columns);
Console.WriteLine("Массив:");
PrintArray(array);
ArithmeticMeanColumns(array);