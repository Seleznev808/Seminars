double[] Array()
{
    double[] array = new double[6];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    Console.WriteLine("Массив чисел:");
    Console.WriteLine(string.Join(", ", array));
    return array;
}

void DiffMaxMin(double[] arr)
{
    double diff = 0;
    double min = arr[0];
    double max = arr[1];
    if (max < min)
    {
        max = arr[0];
        min = arr[1];
    }
    for (int i = 2; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    diff = max - min;
    Console.WriteLine("Разница между максимальным и минимальным элементами массива (" + max + " и " + min + "): " + diff);
}

DiffMaxMin(Array());