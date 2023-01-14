using static Infrastructure;
using static Sorting;

int size = CountInput();
var arr = size.CreateArray()
            // .FillArray()
            .Show(title: "Начальный массив: ")
            .ShakerSort()
            .Show(title: "Конечный массив:  ");