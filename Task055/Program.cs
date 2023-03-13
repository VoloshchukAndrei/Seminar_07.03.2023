// **Задача 55:**Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] arrayOne = GetArray(rows, columns);
PrintArray(arrayOne);
Console.WriteLine();

int[,] arrayTwo = ArrayReversalRowsColumns(arrayOne);
PrintArray(arrayTwo);

// ArrayReversalRowsColumns(arrayOne);
// PrintArray(arrayOne);

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

// int[,] ArrayReversalRowsColumns(int[,] N)
// {
//     int[,] result = new int [N.GetLength(1), N.GetLength(0)];
//         for (int i = 0; i < N.GetLength(0); i++)
//         {
//             for (int j = 0; j < N.GetLength(1); j++)
//             {
//                 result[j, i] = N[i, j];
//             }   
//         }
//     return result;
// }

// void ArrayReversalRowsColumns(int[,] N)
// {
//     if (N.GetLength(0) != N.GetLength(1))
//     {
//         Console.WriteLine("В данной матрице нельзя заменить элементы!");
//         return;
//     }

//     for (int i = 0; i < N.GetLength(0); i++)
//     {
//         for (int j = i; j < N.GetLength(1); j++) // J = I
//         {
//             int Q = N[j, i];
//             N[j, i] = N[i, j];
//             N[i, j] = Q;
//         }
//     }
// }

int[,] ArrayReversalRowsColumns(int[,] N)
{
    if (N.GetLength(0) != N.GetLength(1))
    {
        Console.WriteLine("В данной матрице нельзя заменить элементы!");
        return new int[0, 0]; // возвращение нулевого массива
    }

    for (int i = 0; i < N.GetLength(0); i++)
    {
        for (int j = i; j < N.GetLength(1); j++) // J = I
        {
            int Q = N[j, i];
            N[j, i] = N[i, j];
            N[i, j] = Q;
        }
    }
    return N;
}