// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двухмерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix, int[] position)
{
    if (position[0] >= matrix.GetLength(0) || position[1] >= matrix.GetLength(1))
        Console.WriteLine($"В матрице нет элемента с позицией [{position[0]},{position[1]}]");
    else 
        Console.WriteLine($"-> {matrix[position[0],position[1]]}");
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.Write("Введите позицию искомого элемента: ");
int[] position = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
ReleaseMatrix(matrix, position);