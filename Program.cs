// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
/*
void ShowNumber (int n)
{
    if (n < 0)
    { 
        Console.Write($"{n} не натуральное число");
    }
    if (n == 0) return;
    Console.Write(n + " ");
    ShowNumber (n - 1);
}
Console.WriteLine(" Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

ShowNumber(number);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
/*
int SumNumbers(int M, int N)
{
    if (M == 0) 
    return (N * (N + 1)) / 2;            
    else if (N == 0) 
    return (M * (M + 1)) / 2;       
    else if (M == N) 
    return M;                       
    else if (M < N) 
    return N + SumNumbers(M, N - 1); 
    else 
    return N + SumNumbers(M, N + 1);   
}

Console.WriteLine("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int sum = SumNumbers(numM, numN);
Console.WriteLine(sum + " ");
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Akkerman(m, n);
Console.WriteLine(result);


