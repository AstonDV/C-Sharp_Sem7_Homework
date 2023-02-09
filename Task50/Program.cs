// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


int Input(string text)
{
    Console.Write($"{text}: ");
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void PrintResult(int[,] searchInArray, int searchRow, int searchCol)
{
    if (searchRow > searchInArray.GetLength(0) || searchCol > searchInArray.GetLength(1))
        Console.WriteLine("В заданном массиве такого элемента нет!");
    else Console.WriteLine($"Значение указанного вами элемента равно {searchInArray[searchRow - 1, searchCol - 1]}");
}

void Main()
{
    Console.Clear();
    int row = Input("Введите кол-во строк");
    int col = Input("Введите кол-во столбцов");
    int indexRow = Input("Введите номер строки");
    int indexCol = Input("Введите номер элемента в строке");
    Console.WriteLine();
    int[,] array = GetArray(row, col, 10, 99);
    PrintArray(array);
    Console.WriteLine();
    PrintResult(array, indexRow, indexCol);
}

Main();