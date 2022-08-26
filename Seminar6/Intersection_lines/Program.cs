double[] StrInt(string numbers)
{
    string str = numbers.Trim();
    string[] strArray = str.Split(" ");
    double[] array = new double[strArray.Length];
    for (int i = 0; i < strArray.Length; i++)
    {
        array[i] = double.Parse(strArray[i]);
    }
    return array;
}

Console.WriteLine("Введите значения k и b для первой прямой через пробел");
string kb1 = Console.ReadLine();
Console.WriteLine("Введите значения k и b для второй прямой через пробел");
string kb2 = Console.ReadLine();
double[] k1b1 = StrInt(kb1);
double[] k2b2 = StrInt(kb2);
double x = (k2b2[1] - k1b1[1]) / (k1b1[0] - k2b2[0]);
double y = (k1b1[0] * (k2b2[1] - k1b1[1])) / (k1b1[0] - k2b2[0]) + k1b1[1];
Console.WriteLine("Точка пересечения двух прямых:");
Console.WriteLine("x = " + x);
Console.WriteLine("y = " + y);