/*
Задача 47.
Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

*/

int rows = new Random().Next(3,4);
int columns = new Random().Next(4,5);
double[,] array = new double[rows, columns];
FillArray();
PrintArray();

void FillArray()
{
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = Math.Round(random.Next(-10,11) + random.NextDouble(),2);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
    
}
