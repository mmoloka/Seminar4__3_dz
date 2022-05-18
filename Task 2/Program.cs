/*
Напишите программу, которая принимает на вход
координаты двух точек и находит расстояние между ними
в 3D пространстве.
A(3, 6, 8); B(2, 1, -7) -> 15.84
A(7, -5, 0); B(1, -1, 9) -> 11.53
*/
int GetNumber(string msg)
{
while(true)
{
Console.WriteLine(msg);
string valueFromConsole = Console.ReadLine();

    if(int.TryParse(valueFromConsole, out int number))
    {
        return number;
    }
    else
    {
        Console.WriteLine("Вы ввели не число. Нужно ввести число.");
    }
}
}
double GetLengthVector(double x1, double y1, double z1, double x2, double y2,  double z2)
{
    double difx = Math.Pow((x2-x1), 2);
    double dify = Math.Pow((y2-y1), 2);
    double difz = Math.Pow((z2 - z1), 2);
    double length = Math.Sqrt(difx + dify + difz);
    return length;
}
int x1 = GetNumber("Введите координату точки A по оси x:");
int y1 = GetNumber("Введите координату точки A по оси y:");
int z1 = GetNumber("Введите координату точки A по оси z:");
int x2 = GetNumber("Введите координату точки B по оси x:");
int y2 = GetNumber("Введите координату точки B по оси y:");
int z2 = GetNumber("Введите координату точки B по оси z:");

double result = GetLengthVector( x1,  y1, z1, x2,  y2, z2);
Console.WriteLine(result);
