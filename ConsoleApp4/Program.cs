/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A(3, 6); B(2, 1)-> 5,09
A(7, -5); B(1, -1)-> 7,21 

d = √ (х А – х В) 2 + (у А – у В) 2

*/

double GetDistance(double x1 = 0, double y1 = 0, double x2 = 0, double y2 = 0)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return distance;
}

Console.WriteLine("Введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double distance1 = GetDistance(x1, y1, x2, y2);
Console.WriteLine(distance1);



