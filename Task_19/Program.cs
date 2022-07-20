// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
string numbers = Console.ReadLine();
string palindrom()
{
    if (numbers.Length == 5)
    {
        if (numbers[0] == numbers[4] && numbers[1] == numbers[3])
        {
            return "Введенное число является палиндромом";
        }
        else
        {
            return "Введенное число не является палиндром";
        }
    }
    else
    {
        return "Введите пятизначное число!";
    }
}

Console.WriteLine(palindrom());