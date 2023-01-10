int n = 5;
int[] array = new int[n];
for (var i = 0; n < 5; i++)
{
    Console.Write($"Введите {i} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[ {string.Join(", ", array)} ]");
Console.WriteLine(array[3]);
// [4, 5, 3, 1, 2]
// O(n)
// [1,2,3,4,5] - O(n*logn)
// ((5+1)/2)*5 - O(1)
// n < n * log(n) + 1
int summa = 0;
for (int i = 0; i < n; i++)
    summa += array[i];
Console.WriteLine($"Сумма элементов массива = {summa}");
// O(n)