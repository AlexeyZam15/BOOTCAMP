using static System.Console;
using static System.String;

public static class Infrastructure
{
    /// <summary>
    /// Метод создания и заполнения массива
    /// </summary>
    /// <param name="size">Размер нового массива</param>
    /// <param name="min">Нижняя граница заполнения</param>
    /// <param name="max">Верхняя граница заполнения</param>
    /// <returns>Новый массив</returns>
    public static int[] CreateArray(this int size, int min = 0, int max = 10)
    {
        return Enumerable.Range(1, size)
               .Select(item => Random.Shared.Next(min, max))
               .ToArray();
    }

    /// <summary>
    /// Вывод массива в консоль
    /// </summary>
    /// <param name="title">Текст перед выводом массива</param>
    /// <param name="array">Исходный массив</param>
    /// <param name="separator">Символ-разделитель элементов массива</param>
    /// <returns>Исходный массив</returns>
    public static int[] Show(this int[] array, string title = "", string separator = ",")
    {
        Write(title);
        string output = Join(separator, array);
        WriteLine($"[{output}]");
        return array;
    }

    /// <summary>
    /// Заполнение массива
    /// </summary>
    /// <param name="array">Исходный массив</param>
    /// <returns>Заполненный массив</returns>
    public static int[] FillArray(this int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите значение элемента массива с индексом {i}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        return array;
    }
    /// <summary>кто
    /// Запрос на ввод числа
    /// </summary>
    /// <returns>Целое число</returns>
    public static int CountInput(string text = "Введите кол-во элементов массива: ")
    {
        Console.Write(text);
        int n = Convert.ToInt32(Console.ReadLine());
        return n;
    }
}