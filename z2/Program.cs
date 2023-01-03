// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите минимально число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное число: ");
int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumIntegers(num1, num2));
int SumIntegers(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return m + SumIntegers(m + 1, n);
    }
}
