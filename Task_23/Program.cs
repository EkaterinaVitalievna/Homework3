// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Куб чисел от 1 до введённого числа: ");
int cubeNum(int n)
{
    for (int i = 1; i <= n; i++)
    {
        //int result = i * i * i;
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    return n;
}
cubeNum(number);