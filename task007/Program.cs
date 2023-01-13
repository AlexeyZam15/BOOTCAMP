using static Infrastructure;
using static Sorting;

int size = CountInput();
var arr = size.CreateArray()
            // .FillArray()
            .Show(title: "Начальный массив: ")
            .SortQuick(0, size - 1)
            .Show(title: "Конечный массив:  ");