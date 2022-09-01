int[,] ArraySpiral(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int i = 0;
    int j = 0;
    int k = 1;
    while (k <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = k;
        k++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++;
        else if (i < j && i + j >= array.GetLength(0) - 1) i++;
        else if (i >= j && i + j > array.GetLength(1) - 1) j--;
        else i--;
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10) Console.Write($"0{arr[i, j]} ");
            else Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int rows = 4;
int columns = 4;
int[,] array = ArraySpiral(rows, columns);
PrintArray(array);