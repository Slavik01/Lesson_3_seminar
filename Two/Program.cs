// Напишите программу, которая принимает на вход координаты двух точек и находит
//  расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты x3: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y3: ");
int y3 = Convert.ToInt32(Console.ReadLine());
// double distance = Math.Sqrt(Math.Pow(x1 - y1, 2) + Math.Pow(x2 - y2, 2) + Math.Pow(x3 - y3, 2));
// Console.WriteLine($"Расстояние между тремя точками в пространстве равно: {distance}");

// Метод:
double distance (double x1, double y1,double x2, double y2,double x3, double y3) 
{
    return Math.Sqrt(Math.Pow(x1 - y1, 2) + Math.Pow(x2 - y2, 2) + Math.Pow(x3 - y3, 2));
}
Console.WriteLine($"Расстояние между тремя точками в пространстве равно: {Math.Round(distance(x1, y1, x2, y2, x3, y3))}");
// double result = Console.WriteLine(distance (x1, y1, x2, y2, x3, y3));
// Console.WriteLine($"Расстояние между тремя точками в пространстве равно: {Math.Round(result)}");