public static class Sorting
{
    public static int[] ShakerSort(this int[] collection, bool log = false)
    {
        int left = 0,
            right = collection.Length - 1;
        int count = 1;
        while (left < right)
        {
            if (log == true)
                Console.WriteLine($"{count++}.");
            for (int i = left; i < right; i++)
            {
                if (collection[i] > collection[i + 1])
                {
                    if (log == true)
                        Console.WriteLine($"[{string.Join(", ", collection)}]| {collection[i]}>{collection[i + 1]}  | {collection[i]}<->{collection[i + 1]}");
                    int t = collection[i];
                    collection[i] = collection[i + 1];
                    collection[i + 1] = t;
                }
                else
                if (log == true)
                    Console.WriteLine($"[{string.Join(", ", collection)}]| {collection[i]}<={collection[i + 1]} | {collection[i]}X{collection[i + 1]}");
            }
            right--;

            for (int i = right; i > left; i--)
            {
                if (collection[i - 1] > collection[i])
                {
                    if (log == true)
                        Console.WriteLine($"[{string.Join(", ", collection)}]| {collection[i - 1]}>{collection[i]} | {collection[i - 1]}<->{collection[i]}");
                    int t = collection[i - 1];
                    collection[i - 1] = collection[i];
                    collection[i] = t;
                }
                else
                if (log == true)
                    Console.WriteLine($"[{string.Join(", ", collection)}]| {collection[i - 1]}<={collection[i]} | {collection[i - 1]}X{collection[i]}");
            }
            left++;
        }
        return collection;
    }
}