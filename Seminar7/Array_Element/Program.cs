int[,] Array(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
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

void SearchElementArray(int[,] arr, int number)
{
    bool found = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == number) 
            {
                found = true;
                Console.WriteLine($"Индексы числа {number}: i (номер строки) = {i}, j (номер столбца) = {j}");
            }
        }
    }
    if (found == false) Console.WriteLine($"Числа {number} в массиве нет");
}


Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int rows = 3;
int columns = 4;
int[,] array = Array(rows, columns);
Console.WriteLine("Массив:");
PrintArray(array);
SearchElementArray(array, number);