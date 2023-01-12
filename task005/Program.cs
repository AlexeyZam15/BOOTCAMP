
int[] arr = { 1, 2, 3, 4, 5, 1, 2, 3 };
Console.WriteLine(string.Join("", arr));

void sortIntArrayMinMax(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i+1; j < arr.Length; j++)
        {
            if (arr[j] < arr[i])
            {
                int t = arr[j];
                arr[j] = arr[i];
                arr[i] = t;
            }
        }
    }
}

sortIntArrayMinMax(arr);
Console.WriteLine(string.Join("", arr));
