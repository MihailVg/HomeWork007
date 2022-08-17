// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введиье количество строчек массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введиье количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());

void FillArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10) + Convert.ToDouble(new Random().Next(100))/10;
        }
    }
}

void PrintArray(double[,] array1)
{
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write(array1[i, j] + " ");
        }
        Console.WriteLine();
    }
}

double[,] array2 = new double[row, column];
FillArray(array2);
Console.WriteLine();
PrintArray(array2);
