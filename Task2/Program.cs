// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

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

int[] GetIndexMinElement(int[,] array)
{
    int min = array[0, 0];
    int row = 0;
    int column = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                row = i;
                column = j;
            }
        }
    }

    int[] indexMinElement = { row, column };
    return indexMinElement;
}

int[,] ArrayWithoutMinColumnAndRow(int[,] array, int[] indexMinElement)
{
    int[,] arrayWithoutMinColumnAndRow = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0, k = 0; i < array.GetLength(0); i++)
    {
        if (i != indexMinElement[0])
        {
            for (int j = 0, l = 0; j < array.GetLength(1); j++)
            {
                if (j != indexMinElement[1])
                {
                    arrayWithoutMinColumnAndRow[k, l] = array[i, j];
                    l++;
                }
            }
            k++;
        }

    }
    return arrayWithoutMinColumnAndRow;
}

int n = SetArray("Введите количество строк массива: ");
int m = SetArray("Введите количество столбцов массива: ");
if (n == 1 || m == 1)
{
    Console.WriteLine("Данная матрица будет полностью удалена. Решение не имеет смысла. \nНажмите enter для завершения программы.");
    Console.ReadLine();
    System.Environment.Exit(0);
}
int[,] array = FillArray(n, m);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
int[] indexinElement = GetIndexMinElement(array);
int[,] arrayWithoutMinColumnAndRow = ArrayWithoutMinColumnAndRow(array, indexinElement);
Console.WriteLine("Матрица, полученная после удаления строки и столбца, содержащих минимальный элемент:");
PrintArray(arrayWithoutMinColumnAndRow);