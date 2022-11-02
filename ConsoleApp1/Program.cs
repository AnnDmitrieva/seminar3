// вместо переменной в теле метода (намберАреа) можно использовать только возврат значения, либо через консоль вовращать сразу номер четверти,
// но метод будет войд, а при вызове  вызывается просто метод, скрины есть в notion

int GetPointArea(int coordX, int coordY)
{
    int numberArea = 0;
    if (coordX > 0 && coordY > 0)
    {
        numberArea = 1;
    }

    if (coordX < 0 && coordY > 0)
    {
        numberArea = 2;
    }

    if (coordX < 0 && coordY < 0)
    {
        numberArea = 3;
    }

    if (coordX > 0 && coordY < 0)
    {
        numberArea = 4;
    }
    return numberArea;
}

Console.WriteLine("Введите число Х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int numberArea = GetPointArea(x, y);
Console.WriteLine(numberArea);

