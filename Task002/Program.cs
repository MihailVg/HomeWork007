// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

Console.WriteLine("Введите количество строчек массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите строчку элемента массива: ");
int rowfind = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите стоблец элемента массива: ");
int columnfind = Convert.ToInt32(Console.ReadLine());

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write(array1[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindElement(int[,] array2)
{
    int i = 0;
    int j = 0;
    for (i = 0; i < array2.GetLength(0); i++)
    {
        for (j = 0; j < array2.GetLength(1); j++)
        {
            if (j == columnfind)
            {
                break;
            }
        }
        if (i == rowfind)
        {
            break;
        }
    }
    if (rowfind <= row && columnfind <= column)
        {
            if (array2[i, j] == array2[rowfind, columnfind])
            {
                Console.WriteLine("Элемент с заданными коорданитами равен: " + array2[i, j]);
            }
            else
            {
                Console.WriteLine("Данных координат нет в массиве");
            }
        }
    else
    {
        Console.WriteLine("Данных координат нет в массиве");
    }
}

int[,] array3 = new int[row, column];
FillArray(array3);
Console.WriteLine();
PrintArray(array3);
FindElement(array3);


