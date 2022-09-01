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

int[] SumRow(int [,] array)
{
    int[] arr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        arr[i] = sumRow;
    }
    return arr;
}

void MinSumRow(int[] array)
{
    int minSum = array[0];
    int row = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minSum) 
        {
            minSum = array[i];
            row = i;
        }
    }
    Console.WriteLine($"Строка массива с наименьшей суммой элементов: {row}");
}

int rows = 3;
int columns = 4;
int[,] array = Array(rows, columns);
Console.WriteLine("Массив:");
PrintArray(array);
MinSumRow(SumRow(array));