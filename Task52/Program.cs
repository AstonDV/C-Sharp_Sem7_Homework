// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 
// 4,6; 5,6; 3,6; 3.


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

double[] AverageColumnsIn2DArray(int[,] inArray)
{
    double[] averageArray = new double[inArray.GetLength(1)];
    for (int col = 0; col < inArray.GetLength(1); col++)
    {
        for (int row = 0; row < inArray.GetLength(0); row++)
        {
            averageArray[col] += inArray[row, col];
        }
    }
    for (int i = 0; i < averageArray.Length; i++)
    {
        averageArray[i] /= inArray.GetLength(0);
    }
    return averageArray;
}

void PrintResult(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]:f1}, ");
    }
    Console.Write($"{array[array.Length - 1]:f1}");
    Console.WriteLine();
}

void Main()
{
    Console.Clear();
    int row = Input("Введите кол-во строк");
    int col = Input("Введите кол-во столбцов");
    Console.WriteLine();
    int[,] array = GetArray(row, col, 1, 9);
    PrintArray(array);
    Console.WriteLine();
    double[] resultAverage = AverageColumnsIn2DArray(array);
    PrintResult(resultAverage);
}

Main();