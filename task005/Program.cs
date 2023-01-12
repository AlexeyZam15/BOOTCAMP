int[] arr = { 1, 2, 3, 4, 5, 1, 2, 3 };
Console.WriteLine(string.Join("", arr));

// void sortIntArrayMinMax(int[] arr)
// {
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         for (int j = i + 1; j < arr.Length; j++)
//         {
//             if (arr[j] < arr[i])
//             {
//                 int t = arr[j];
//                 arr[j] = arr[i];
//                 arr[i] = t;
//             }
//         }
//     }
// }

void SortSelection(int[] collection)
{
    int size = collection.Length;
    for (int i = 0; i < size - 1; i++)
    {
        int pos = i;
        for (int j = i+1; j < size; j++)
        {
            if (collection[j] < collection[pos]) pos = j;
        }
        int temp = collection[i];
        collection[i] = collection[pos];
        collection[pos] = temp;
    }
}

// sortIntArrayMinMax(arr);
SortSelection(arr);
Console.WriteLine(string.Join("", arr));
