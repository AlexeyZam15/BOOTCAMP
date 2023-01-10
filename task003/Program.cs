using System.Diagnostics;

Console.Write($"Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
// O(n^2)

Stopwatch sw = new();
sw.Start();

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
     Console.Write($"{i * j,4}");  
    }
    Console.WriteLine();
}

sw.Stop();
Console.WriteLine($"time = {sw.ElapsedMilliseconds}");

// for (int i = 0; i < n; i++)
// {
//     matrix[i, n - i - 1] = (i + 1) * (n - i);
//     matrix[i, i] = (i + 1) * (i + 1);
// }

sw.Reset();
sw.Start();

for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
            matrix[i, j] = (i+1) * (j+1);
            matrix[j, i] = matrix[i, j];
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
        Console.Write($"{matrix[i, j],4}");
    Console.WriteLine();
}

// O(n^2 / 2 )

sw.Stop();
Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
