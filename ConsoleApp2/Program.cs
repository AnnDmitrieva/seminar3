// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).
// результат записать в стороке

string GetCoordinateRange(int numberArea)
{
    string coordinateRange = "x, y.";
    if (numberArea == 1) coordinateRange = "x > 0, y > 0.";
    if (numberArea == 2) coordinateRange = "x < 0, y > 0.";
    if (numberArea == 3) coordinateRange = "x < 0, y < 0.";
    if (numberArea == 4) coordinateRange = "x > 0, y < 0.";
    return coordinateRange;
}

Console.WriteLine("Введите номер четверти: ");
int x = Convert.ToInt32(Console.ReadLine());

string coordinate = GetCoordinateRange(x);
Console.WriteLine(coordinate);