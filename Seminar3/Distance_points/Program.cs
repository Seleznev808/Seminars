Console.WriteLine("Введите координаты точки А");
double xa = double.Parse(Console.ReadLine());
double ya = double.Parse(Console.ReadLine());
double za = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки В");
double xb = double.Parse(Console.ReadLine());
double yb = double.Parse(Console.ReadLine());
double zb = double.Parse(Console.ReadLine());

double distancePoint = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
Console.WriteLine("Расстояние между точками А и В - " + Math.Round(distancePoint, 2));