// Задача N3 Задайте двумерный массив из целых чисел размера NxN. 
// Укажите два числа,означающие строки, которые нужно поменять местами.

Console.WriteLine("Введите количество строчек массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine("Введите первую строку, которую хотите поменять: ");
int rowchange = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите вторую строку, которую хотите поменять: ");
int rowchange2 = Convert.ToInt32(Console.ReadLine()) - 1;

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



void ChangeRows(int[,] array4)
{
    int x = 0;
    for(int j = 0; j < array4.GetLength(1); j++)
    {
        x = array4[rowchange, j];
        array4[rowchange, j] = array4[rowchange2, j];
        array4[rowchange2, j] = x;
    }
}


int[,] array6 = new int[row, column];
FillArray(array6);
Console.WriteLine();
PrintArray(array6);
Console.WriteLine();
Console.WriteLine("Итог:");
Console.WriteLine();
ChangeRows(array6);
PrintArray(array6);
