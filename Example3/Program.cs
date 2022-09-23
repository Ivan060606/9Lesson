int Depth = 0;
    int AckermannFunc(int m, int n) 
    {
    Depth++;
    if (m == 0)
        return n + 1;
    if (n == 0)
    return AckermannFunc(m - 1, 1);
    return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
    }
Console.WriteLine("Введите число М");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AckermannFunc(M, N));