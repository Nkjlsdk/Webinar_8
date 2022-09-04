//Задача 58. Задать две матрицы. Найти их произведение.


Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] TwoArray(int m, int n)
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

void EnterArrayA(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)

    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();

    }
}

void EnterArrayB(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)

    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();

    }
}

int[,] Multiplication(int a, int b)
{
    int[,] matrix = new int[rows, columns];
    int[,] AB = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            AB[i, j] = 0;
            for (int k = 0; k < rows; k++)
            {
                AB[i, j] += matrix[i, k] * matrix[k, j];
            }

        }
    }
    return AB;
}

void PrintResult(int[,] AB)
{
    for (int i = 0; i < AB.GetLength(0); i++)
    {
        for (int j = 0; j < AB.GetLength(1); j++)
        {
            Console.Write(AB[i, j] + "\t");

        }
        Console.WriteLine();
    }
}


int[,] matrix = TwoArray(rows, columns);
EnterArrayA(matrix);
Console.WriteLine();
EnterArrayB(matrix);
Console.WriteLine();
int[,] result = Multiplication(rows, columns);
PrintResult(matrix);