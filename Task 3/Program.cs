/*
Напишите программу, которая принимает на вход число (N) 
и выдает таблицу кубов чисел от 1 до N
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
int GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            if (number > 1)
                return number;
            else
            {
                Console.WriteLine("Число должно быть больше 1. Введите число заново");
            }
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число больше 1");
        }
    }
}
void GetCube(int num)
{
    for (int i = 1; i <= num; i++)
        Console.Write($"{i * i * i}, ");
    }
string message = "Введите число больше 1";
int N = GetNumber(message);
GetCube(N);
