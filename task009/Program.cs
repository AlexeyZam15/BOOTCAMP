using System.Diagnostics;

const int N = 800; // размер матрицы

int[,] firstMatrix = FillRndIntMatrix(N, N, -100, 100);
int[,] secondMatrix = FillRndIntMatrix(N, N, -100, 100);

Stopwatch sw = new ();
sw.Start();

int[,] serialMulRes = SerialMultMatrices(firstMatrix, secondMatrix); // результат выполнения умножения матриц в однопотоке
sw.Stop();
Console.WriteLine($"Serial mult time = {sw.ElapsedMilliseconds} Milliseconds");
int[,] threadsMulRes = new int[N, N]; // результат параллельного умножения матриц
sw.Reset();
sw.Start();
ParallelMultMatrices(firstMatrix, secondMatrix, 10);
sw.Stop();
Console.WriteLine($"Parallel mult time = {sw.ElapsedMilliseconds} Milliseconds");
Console.WriteLine(EqualityMatrix(serialMulRes, threadsMulRes)? "Result matrices are equal" : "Result matrices are not equal");

int[,] FillRndIntMatrix(int rows, int columns, int min = 0, int max = 10)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[,] SerialMultMatrices(int[,] matrix, int[,] matrix2)
{
    int rows1 = matrix.GetLength(0);
    int columns1 = matrix.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int columns2 = matrix2.GetLength(1);
    if (columns1 != rows2) throw new Exception("Нельзя умножать такие матрицы");
    int[,] multMatrices = new int[rows1, columns2];
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            for (int k = 0; k < rows2; k++)
            {
                // if (k >= columns1) k = 0;
                multMatrices[i, j] += matrix[i, k] * matrix2[k, j];
            }
        }
    }
    return multMatrices;
}

void ParallelMultMatrices(int[,] matrix, int[,] matrix2, int THREADS_NUMBER)
{
    int rows1 = matrix.GetLength(0);
    int columns1 = matrix.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int columns2 = matrix2.GetLength(1);
    if (columns1 != rows2) throw new Exception("Нельзя умножать такие матрицы");
    int eachThreadCalc = rows1 / THREADS_NUMBER;
    var threadsList = new List<Thread>();
    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        int startPos = i * eachThreadCalc;
        int endPos = (i + 1) * eachThreadCalc;
        //если последний поток
        if (i == THREADS_NUMBER - 1) endPos = rows1;
        threadsList.Add(new Thread(() => MultMatrices(matrix, matrix2, startPos, endPos)));
        threadsList[i].Start();
    }
    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        threadsList[i].Join();
    }
}

bool EqualityMatrix(int[,] fmatrix, int[,] smatrix)
{
    bool res = true;
    for (int i = 0; i < fmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < fmatrix.GetLength(1); j++)
        {
            res = res && (fmatrix[i, j] == smatrix[i, j]);
        }
    }
    return res;
}

void MultMatrices(int[,] matrix, int[,] matrix2, int startPos, int endPos)
{
    int rows1 = matrix.GetLength(0);
    int columns1 = matrix.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int columns2 = matrix2.GetLength(1);
    if (columns1 != rows2) throw new Exception("Нельзя умножать такие матрицы");
    for (int i = startPos; i < endPos; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            for (int k = 0; k < rows2; k++)
            {
                // if (k >= columns1) k = 0;
                threadsMulRes[i, j] += matrix[i, k] * matrix2[k, j];
            }
        }
    }
}

