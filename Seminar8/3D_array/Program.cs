int[] ArrayFrom10To99()
{
    int[] array = new int[90];
    for (int i = 0; i < 90; i++)
    {
        array[i] = i + 10;
    }
    return array;
}

int[] ArrayMixFrom10To99(int[] array)
{
    for (int i = array.Length - 1; i >= 0; i--)
    {
        int j = new Random().Next(i + 1);
        int temp = array[j];
        array[j] = array[i];
        array[i] = temp;
    }
    return array;
}

int[,,] Array3D(int rows, int columns, int depth, int[] array)
{
    int[,,] array3D = new int[rows, columns, depth];
    int count = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = array[count];
                count++;
            }
        }
    }
    return array3D;
}

void PrintArray3D(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}




int[] array10To99 = ArrayFrom10To99();
int[] arrayMix10To99 = ArrayMixFrom10To99(array10To99);
int rows = 2;
int columns = 2;
int depth = 2;
int[,,] array3D = Array3D(rows, columns, depth, arrayMix10To99);
PrintArray3D(array3D);