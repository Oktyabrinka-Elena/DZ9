//  Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//  M = 1; N = 15 -> 120
//  M = 4; N = 8. -> 30
//
 
Console.Write("Введите число M: ");
int NumberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int NumberN = Convert.ToInt32(Console.ReadLine());

SumAll(NumberM, NumberN);

int SumMtoN(int M, int N)
{
    int result = M;
    if (M == N)
        return 0;
    else
    {
        M++;
        result = M + SumMtoN(M, N);
        return result;
    }
}

void SumAll(int NumberM, int NumberN)
{
    Console.Write($"Сумма =  {SumMtoN(NumberM - 1, NumberN)}");
}

Console.WriteLine();

