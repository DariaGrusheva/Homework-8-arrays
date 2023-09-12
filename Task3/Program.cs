// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string element = array[i, j].ToString();
            if (array[i, j] < 10) element = "0" + element;
            Console.Write(element + "\t");

        }
        Console.WriteLine();
    }
}

int[,] array = new int[4, 4];
Console.WriteLine("ВВедите первый элемент массива: ");
int startElement = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < array.GetLength(1); i++)
{
    array[0, i] = startElement;
    startElement++;
}

for (int i = 1; i < array.GetLength(0); i++)
{
    array[i, 3] = startElement;
    startElement++;
}

for (int i = 2; i >= 0; i--)
{
    array[3, i] = startElement;
    startElement++;
}

for (int i = 2; i > 0; i--)
{
    array[i, 0] = startElement;
    startElement++;
}

for (int i = 1; i < array.GetLength(1) - 1; i++)
{
    array[1, i] = startElement;
    startElement++;
}
for (int i = 2; i > 0; i--)
{
    array[2, i] = startElement;
    startElement++;
}

PrintArray(array);