// Сложности алгоритмов.
// 1. Константы O(1)
// const int x = 5;
// Console.WriteLine(x);

// 2. Линейная сложность O(N)
// int[] arr = { 1, 2, 3, 4 };
// Console.WriteLine(string.Join(" ", arr));
// int sum = 0;
// for (int i = 0; i < arr.Length; i++)
//     sum += arr[i];
// Console.WriteLine(sum);

// 3. Квадратичная сложность O(N^2)
// for (int i = 0; i < arr.Length; i++)
//     for (int j = 0; j < arr.Length; j++)
//     {

//     }

// 4. Сложность O(A * B)
// int[][] arr = new int[2][];

// arr[0] = new int[5] { 1, 3, 5, 7, 9 };
// arr[1] = new int[4] { 2, 4, 6, 8 };

// int sum = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     for (int j = 0; j < arr[i].Length; j++)
//     {
//         sum+=arr[i][j];
//     } 
// }

// Console.WriteLine(sum);

// 5. Отбрасывание не доминантных функций O(2*N)

// for (int i = 0; i < arr.Length; i++)
// {
    
// }

// for (int i = 0; i < arr.Length; i++)
// {
    
// }

// O(N^2 * N) -> O(N^2)

// for (int i = 0; i < arr.Length; i++)
// {
//     for (int j = 0; j < arr.Length; j++)
//     {
        
//     }
// }

// for (int i = 0; i < arr.Length; i++)
// {
    
// }

// 6. O(logN)
// Бинарный поиск
int[] sortedArr = {1,2,3,5,7,100,201};
int n = 16;
n = 8;
n = 4;
n = 2;
n = 1;

// 2^4 = 16 logN = 4

// 7. Рекурсии O(2^N)
int myRecursion(int n) {
    if (n<=1) return 1;
    return myRecursion(n-1) + myRecursion(n-1);
}