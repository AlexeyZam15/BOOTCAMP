using System.Diagnostics;

int[] CreateRandomArrayInt(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(0, 11);
    }
    return array;
}

int size = 1000000;
int m = 3000;
int[] array = CreateRandomArrayInt(size);

// Console.WriteLine($"[{string.Join(", ", array)}]");

Stopwatch sw = new();
sw.Start();

int max = 0;
for (int i = 0; i < array.Length - m; i++)
{
    int t = 0;
    for (int j = i; j < i + m; j++) t += array[j];
    if (t > max) max = t;
}

sw.Stop();

Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
Console.WriteLine($"Способ 1: {max}");

sw.Reset();
sw.Start();

int max1 = 0;
for (int j = 0; j < m; j++) max1 += array[j];
int t1 = max1;
for (int i = 1; i < array.Length - m; i++)
{
    t1 = t1 - array[i - 1] + array[i + (m - 1)];
    if (t1 > max1) max1 = t1;
}
sw.Stop();

Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
Console.WriteLine($"Способ 2: {max1}");
