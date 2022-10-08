//  Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//  m = 2, n = 3 -> A(m,n) = 9
//  m = 3, n = 2 -> A(m,n) = 29

//  формула аккермана
// (n+1) при m=0;
// A(m-1,1) при m>0, n=0;
// A(m-1,A(m,n-1)) при m>0, n>0
 
Console.WriteLine("Расчет функции Аккермана");
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

ResultAkkerman(m,n);

int A(int m, int n)  //расчет согласно формулам
{
    if (m == 0) // (n+1) при m=0;
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return A(m - 1, 1); //A(m-1,1) при m>0, n=0;
    }
    else
    {
        return (A(m - 1, A(m, n - 1))); // A(m-1,A(m,n-1)) при m>0, n>0
    }
}

void ResultAkkerman(int m, int n)
{
    Console.Write($"Результат расчета = {A(m, n)}"); 
}
