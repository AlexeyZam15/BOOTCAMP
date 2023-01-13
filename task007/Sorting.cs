public static class Sorting
{
    public static int[] SortQuick(this int[] collection, int left, int right, bool log = false)
    {
        int i = left;
        int j = right;

        int pivot = collection[(left + right) / 2];

        if (log == true)
        {
            Console.WriteLine($"i = {i}, j = {j}");
            Console.WriteLine($"Опорный элемент = {pivot}");
        }

        while (i <= j)
        {
            while (collection[i] < pivot)
            {
                if (log == true)
                    Console.WriteLine($"[{string.Join(", ", collection)}] | {collection[i]}<{pivot}  | i++ | i = {i + 1}");
                i++;
            }
            while (collection[j] > pivot)
            {
                if (log == true)
                    Console.WriteLine($"[{string.Join(", ", collection)}] | {collection[j]}>{pivot}  | j-- | j = {j - 1}");
                j--;
            }

            if (i <= j)
            {
                if (log == true)
                {
                    Console.WriteLine($"[{string.Join(", ", collection)}] | i<=j | {collection[i]}<->{collection[j]}");
                    Console.WriteLine($"i++ | j++ | i = {i + 1} | j = {j - 1}");
                }
                int t = collection[i];
                collection[i] = collection[j];
                collection[j] = t;
                i++;
                j--;
            }
            else if (log == true)
                Console.WriteLine($"[{string.Join(", ", collection)}] | i>j  | {collection[i]} X {collection[j]}");
        }
        if (i < right)
        {
            if (log == true)
                Console.WriteLine($"i<right  | повторяем алгоритм");
            SortQuick(collection, i, right);
        }
        else if (log == true) Console.WriteLine($"i>=right | завершение работы алгоритма");
        if (j > left)
        {
            if (log == true)
                Console.WriteLine($"j>left | повторяем алгоритм");
            SortQuick(collection, left, j);
        }
        return collection;
    }
}