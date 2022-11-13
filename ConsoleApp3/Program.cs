// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.

void GetCubeNumbers(double numbers)
{
   double cube  = 0;
   for (double i = 1; i <= numbers; i++)
    {
        cube = Math.Pow(i, 3);
        Console.WriteLine(cube);
    }
   
}

Console.WriteLine("Введите число: ");
double x = Convert.ToDouble(Console.ReadLine());
GetCubeNumbers(x);
