# Сортировка подсчётом

## Реализация на псевдокоде
### Пример 1
```
int size
arr[size] =  {1,1,1,5,5,1,1,0,0,0,1,1,1,2,2,2,3,3,3,3,3,3,4,1,2,7,7,7,7,7,7}

max = 7             0 1 2 3 4 5 6 7
counter[max + 1] = {3,9,4,6,1,2,0,6}

for i:0..>size:
    counter[arr[i]]++

index = 0
for i:0..>max+1
    for j:0..counter[i]
        arr[index++] = i

arr[size] = {0,0,0,1,1,1,1,1,1,1,1,1,2,2,2,2,3,3,3,3,3,3,4,5,5,7,7,7,7,7,7}
```
### Пример 2 и оценка сложности
```
int size
arr[size] = {-1,-2,-3,-1,0,0,0,1,2,-2,2,-2,-3,4,6,6,6,6}

min = -3                          -3 -2 -1 0 1 2 3 4 5 6     N 2*N => O(2*N- => O(N)
max = 6                            0  1  2 3 4 5 6 7 8 9     O(N)
counter[max + 1 + |min|] =       { 1, 3, 2,3,1,2,0,1,0,4}

for i:0..>size:
    counter[arr[i]+ |min|]++                                 O(N)

index = 0
for i:0..>max+1
    for j:0..counter[i]   // идёт перебор массива, поэтому   O(N)
        arr[index++] = i + min

Общая сложность O(3*N) => O(N)
```
### Краткий Пример 3
```
arr[size] = {-3,-3,-2,-2,-2,-1,-1,0,0,0,1,2,2,4,6,6,6,6}

0.1 2 3.5

0 0.1 0.2               1  1.1     2  2.1
0 1   2   3 4 5 6 7 8 9 10  11 ... 20  21 22 .... 30 31 32 .... 40
```