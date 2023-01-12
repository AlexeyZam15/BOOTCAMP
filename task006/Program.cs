// Сортировка пузырьком

Console.Write($"Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите значение элемента массива с индексом {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

int[] BubbleArraySort(int[] array)
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

array = BubbleArraySort(array);
Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");