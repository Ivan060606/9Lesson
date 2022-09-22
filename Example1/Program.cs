string Sum(int N, int M)
{
    if (N == M) return $"{M} ";
    return Sum(N - 1, M) + N + " ";
}

Console.WriteLine("Введите число М");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(Sum(N, M));