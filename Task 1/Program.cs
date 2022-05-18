/* Напишите программу, которая принимает на вход
пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да */
int GetNumber(string msg)
{
while(true)
{
Console.WriteLine(msg);
string valueFromConsole = Console.ReadLine();

    if(int.TryParse(valueFromConsole, out int number))
    {
        if(number >= 10000 && number <= 99999)  
            return number;
        else
        {
            Console.WriteLine("Число должно быть пятизначным. Введите число заново");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели не число. Нужно ввести пятизначное число.");
    }
}
}
void CheckPolindrome(int number)
{
    string numberStr = number.ToString();
    if(numberStr[0] == numberStr[4] && numberStr[1] == numberStr[3])
        
        Console.WriteLine($"Число {numberStr} является палиндромом");
    else
        Console.WriteLine($"Число {numberStr} не является палиндромом"); 
}
string message = "Введите пятизначное число: ";
int num = GetNumber(message);
CheckPolindrome(num);
