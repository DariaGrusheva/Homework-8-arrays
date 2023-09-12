// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int SetArray(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] FillArray(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] ProductOfArrays(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    int result = 0;
    int sum = 0;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                array3[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }

    return array3;
}

bool CheckDimension(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) != array2.GetLength(0))
    {
        Console.WriteLine("Количество столбцов 1 и  строк 2 матриц должны совпадать! Программа будет завершена.");
        return false;
    }
    return true;
}

int n1 = SetArray("Введите количество строк первого массива: ");
int m1 = SetArray("Введите количество столбцов первого массива: ");
int[,] array1 = FillArray(n1, m1);
Console.WriteLine();
Console.WriteLine("Первый массив:");
PrintArray(array1);
Console.WriteLine();
int n2 = SetArray("Введите количество строк второго массива: ");
int m2 = SetArray("Введите количество столбцов второго массива: ");
int[,] array2 = FillArray(n2, m2);
Console.WriteLine();
Console.WriteLine("Второй массив:");
PrintArray(array2);
Console.WriteLine();
if (!CheckDimension(array1, array2))
{
    Console.ReadLine();
    System.Environment.Exit(0);
}
int[,] array3 = ProductOfArrays(array1, array2);
Console.WriteLine("Произведение матриц равно: ");
PrintArray(array3);