// **Задача 57:**Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит информацию о том,
//  сколько раз встречается элемент входных данных.

// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// 1, 2, 3,4, 6, 1, 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] arrayOne = GetArray(rows, columns);
PrintArray(arrayOne);
Console.WriteLine();

int[] arrayTwo = ArrayOneDimensional(arrayOne);
PrintArrayOneDimensional(arrayTwo);
Console.WriteLine();

int[] arrayThree = SortingArray(arrayTwo);
PrintArrayOneDimensional(arrayThree);
Console.WriteLine();

PrintData(arrayThree);

int[,] GetArray(int M, int N)
{
    int[,] result = new int[M, N];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            result[i, j] = new Random().Next(10, 100);
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

int[] ArrayOneDimensional(int[,] N)
{
    int[] result = new int [N.GetLength(1) * N.GetLength(0)];
    int index = 0;
    for (int i = 0; i < N.GetLength(0); i++)
    {
        for (int j = 0; j < N.GetLength(1); j++)
        {
            result[index] = N[i, j];
            index++;
        }
    }
    return result;
}

void PrintArrayOneDimensional(int[] N)
{
    for (int i = 0; i < N.Length; i++)
    {
        Console.Write($"{N[i]} ");
    }
}

int[] SortingArray(int[] N)
{
    for (int i = 0; i < N.Length; i++)
    {
        for (int j = i + 1; j < N.Length; j++)
        {
            if (N[i] > N[j])
            {
                int Q = N[i];
                N[i] = N[j];
                N[j] = Q;
            }
        }
    }
    return N;
}

void PrintData(int[] N)
{
    int element = N[0];
    int count = 1;
    for (int i = 1; i < N.Length; i++)
    {
        if (N[i] != element)
        {
            Console.WriteLine($"{element} встречается {count}");
            element = N[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{element} встречается {count}");
}

