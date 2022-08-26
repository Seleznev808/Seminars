int[] StrInt(string str)
{
    string[] strArray = str.Split(" ");
    int[] array = new int[strArray.Length];
    for (int i = 0; i < strArray.Length; i++)
    {
        array[i] = int.Parse(strArray[i]);
    }
    return array;
}

void Greater0(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    Console.WriteLine("Вы ввели " + count + " числа/чисел больше 0");
}

Console.WriteLine("Введите несколько чисел через пробел");
string numbers = Console.ReadLine();
string str = numbers.Trim();
Greater0(StrInt(str));