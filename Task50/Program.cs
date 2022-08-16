/*
Задача 50. Напишите программу,
которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет

*/
Random random = new Random();
int rows = random.Next(3,5);
int columns = random.Next(4,6);
int[,] array = new int[rows, columns];

FillArray();
PrintArray();
Console.Write("Введите адрес ячейки: ");
int cellAddress = Convert.ToInt32(Console.ReadLine());
CheckArray();

void CheckArray()
{
    int rowIndex = cellAddress / 10;
    int columnIndex = cellAddress % 10;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            
            if (rowIndex == i && columnIndex == j)
            {
                 Console.WriteLine($"Число в искомой ячейке: {array[i,j]}");
            }
            else if (rowIndex > rows || columnIndex > columns)
            {
                Console.WriteLine($"Искомая ячейка не найдена");
                return;
            }
        }
    }
}

void FillArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(-10,11);
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

