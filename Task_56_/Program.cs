//Задача 56: Задайте прямоугольный двумерный массив. Найти строку с наименьшей суммой элементов.


Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(50);
        }
    }
    return matrix;
}
//int[,] result = GetArray(rows, columns);

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)

    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);

void Min(int[,] matrix)
{
    int minRowSum = int.MaxValue;
    int indexMinRow = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
            if (sum < minRowSum)
            {
                minRowSum = sum;
                indexMinRow = i;


            }

        }


    }
    Console.WriteLine("Строка с минимальной суммой элементов:");
    Console.WriteLine(indexMinRow);
}

Min(resultMatrix);

