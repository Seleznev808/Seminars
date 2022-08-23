int[] Array()
{
    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-50, 51);
    }
    Console.WriteLine("Массив чисел:");
    Console.WriteLine(string.Join(", ", array));
    return array;
}

int SumElements(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    Console.Write("Сумма элементов, стоящих на нечетных позициях в массиве: ");
    return sum;
}

Console.Clear();
Console.WriteLine(SumElements(Array()));