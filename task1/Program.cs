// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


System.Console.WriteLine("Напишите 5 значное число: ");
string? number = Console.ReadLine();
char[] str = new char[number.Length];
if(number.Length == 5)
{
    if(number[0] == number[4] && number[1] == number[3])
    {
        System.Console.WriteLine($"Данное число {number} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Данное число {number} не является палиндромом");
    }
}
else
{
    Console.WriteLine("Введите пятизначное число.");
}
