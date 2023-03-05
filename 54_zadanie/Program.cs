// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
// Функция сортировки
void GetSortDown(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
//*******************************************************************

int rows = GetEnterAtribute("Введите количество строк: ");
int colum = GetEnterAtribute("Введите количество столбцов: ");
int minValMas = GetEnterAtribute("Минимальное значение массива: ");
int maxValMas = GetEnterAtribute("Максимальное значение массива: ");

int[,] result = GetArray(rows, colum, minValMas, maxValMas);
PrintArray(result);
GetSortDown(result);
PrintArray(result);
Console.WriteLine();