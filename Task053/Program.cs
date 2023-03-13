//Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();

ArrayReversalFirstLastLine(array);
PrintArray(array);

int[,] GetArray(int M, int N)
{
    int[,] result = new int[M, N];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void PrintArray(int[,] N)
{
    for (int i = 0; i < N.GetLength(0); i++)
    {
        for (int j = 0; j < N.GetLength(1); j++)
        {
            Console.Write($"{N[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArrayReversalFirstLastLine(int[,] N)
{
    int A = N.GetLength(0) - 1;
    for (int j = 0; j < N.GetLength(1); j++)
    {
        int i = 0;
        int Q = N[i, j];
        N[i, j] = N[N.GetLength(0) - 1, j];
        N[N.GetLength(0) - 1, j] = Q;
    }
}