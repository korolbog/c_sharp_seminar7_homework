/*
Задача 52.
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Random random = new Random();
int rows = random.Next(3,4);
int columns = random.Next(4,5);
double[,] array = new double[rows, columns];
Fill2DArray();
Print2DArray();
double[] counterArray = new double[columns];
CounterArray();
Print1DArray();

void CounterArray()
{
for (int k = 0; k < columns; k++)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (j==k)
            {
                counterArray[k] += array[i,j];
            }
        }
    }
}
}
void Print1DArray()
{
Console.WriteLine("Среднее арифметическое каждого столбца:");
for (int k = 0; k < columns; k++)
    {
        Console.Write($"{Math.Round(counterArray[k] / rows, 1)} \t");
    }
    Console.WriteLine();
}
void Fill2DArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(0,11);
        }
    }
}
void Print2DArray()
{
    Console.WriteLine();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}