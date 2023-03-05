// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.WriteLine();

// Функция для ввода значений от пользователя
int GetEnterAtribute(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
//*******************************************************************
int[,] GetArray(int r, int c, int minValueRand, int maxValueRand)
{
    int[,] result = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            result[i, j] = new Random().Next(minValueRand, maxValueRand + 1);
        }
    }
    return result;
}
//*******************************************************************
void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

}
//*******************************************************************
// Функция 
int RowSumEl(int[,] array, int i)
{
    int rowSum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        rowSum += array[i, j];
    }
    return rowSum;
}

//*******************************************************************
Console.WriteLine("Задайте прямоугольный двумерный массив");
int rowCol = GetEnterAtribute("Введите количество строк и столбцов: ");
// int colum = GetEnterAtribute("Введите количество столбцов: ");
// int minValMas = GetEnterAtribute("Минимальное значение массива: ");
// int maxValMas = GetEnterAtribute("Максимальное значение массива: ");

int[,] result = GetArray(rowCol, rowCol, 0, 10);
PrintArray(result);

int minRowSum = 0;
int rowSum = RowSumEl(result, 0);
for (int i = 1; i < result.GetLength(0); i++)
{
    int tempRowSum = RowSumEl(result, i);
    if (rowSum > tempRowSum)
    {
        rowSum = tempRowSum;
        minRowSum = i;
    }
}
Console.WriteLine($"\n{minRowSum + 1} - строкa с наименьшей суммой ({rowSum}) элементов ");
// PrintArray(result);
Console.WriteLine();