int[] Array()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine("Массив трехзначных чисел:");
    Console.WriteLine(string.Join(", ", array));
    return array;
}

int EvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.Write("Количество четных чисел в массиве: ");
    return count;
}


Console.Clear();
Console.WriteLine(EvenNumbers(Array()));