public static class Sorting
{
    /// <summary>
    /// Сортировка методом пузырька
    /// </summary>
    /// <param name="array">Исходный массив</param>
    /// <returns>Отсортированный массив</returns>
    public static int[] BubbleArraySort(this int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    Console.WriteLine($"[{string.Join(", ", array)}] | {array[j]}<->{array[j + 1]}");
                    int t = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = t;
                }
                else
                    Console.WriteLine($"[{string.Join(", ", array)}] | {array[j]} X {array[j + 1]}");
            }
        }
        return array;
    }
}