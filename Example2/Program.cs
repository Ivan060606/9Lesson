// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/

/*string Natu(int N)
{
    if (int i = N) return N;
    return Console.WriteLine(N);
    Natu(i+1);
}

Console.WriteLine(Natu(5));

string Sum(int N)
{
    if (N == 1) return "1 ";
    return Sum(N - 1) + N + " ";
}
Console.WriteLine(Sum(10));
*/
int Sum(int N, int M, int S)
{
    if (N == M) return 0;
    S = S + N;
    
    return Sum(N - 1, M, S) + S;
}

Console.WriteLine("Введите число М");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int S = 0;
/*
Console.WriteLine();
int summa = Convert.ToInt32(Console.ReadLine());*/
Console.WriteLine(Sum(N, M, S));
