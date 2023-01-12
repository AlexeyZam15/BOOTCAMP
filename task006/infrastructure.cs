using static System.Console;
using static System.String;

public static class Infrastructure
{
    /// <summary>кто
    /// Запрос на ввод
    /// </summary>
    /// <returns>Целое число</returns>
    public static int CountInput(string text = "Введите кол-во элементов массива: ")
    {
        Console.Write(text);
        int n = Convert.ToInt32(Console.ReadLine());
        return n;
    }
    /// <summary>
    /// Создание пустого массива
    /// </summary>
    /// <param name="size">Размер создаваемого массива</param>
    /// <returns>Пустой массив</returns>
    public static int[] CreateEmptyArray(this int size)
    {
        int[] array = new int[size];
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
/// <summary>
/// Вывод массива в консоль
/// </summary>
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
}