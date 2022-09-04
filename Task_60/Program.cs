//Задача 60. Ввести трёхмерный массив из неповторяющихся двузначных чисел, 
//построчно вывести массив с индексами каждого элемента.

Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество Z:");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] GetArray(int m, int n, int k)
{
    int[,,] matrix = new int[m, n, k];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
            {
                matrix[i, j, l] = new Random().Next(10, 100);


            }
        }
    }

    return matrix;

}
void ChangeSame(int[,,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1) - 1; j++)
        {
            for (int l = 0; l < inputMatrix.GetLength(2) - 1; l++)
            {

                if (inputMatrix[i, j, l] == inputMatrix[i + 1, j + 1, l + 1])
                {
                    inputMatrix[i, j, l] = new Random().Next(100);

                }
            }
        }

    }


}

void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)

    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
            {

                Console.Write(matrix[i, j, l] + " (" + i + "," + j + "," + l + ") ");
            }
        }
        Console.WriteLine();
    }
}


int[,,] resultMatrix = GetArray(rows, columns, z);
ChangeSame(resultMatrix);
PrintArray(resultMatrix);    //печать на экран, вызов метода печати на экран