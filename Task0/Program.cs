// Задайте двумерный массив.
//  Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] matrix = new int[3, 4];

void CreateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int mean = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = mean;

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

CreateMatrix(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
ChangeMatrix(matrix);
PrintMatrix(matrix);