//task 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int [,] Fillarr (int rows, int columns )
{
    int[,] newArr = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArr[i, j] =  new Random().Next(1, 5);

        }
    }
    return newArr;
}

void Printarr (int[,] arr )
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr [i,j]+"   ");
        }
        Console.WriteLine();
    }
}

int [,] ProductTwoMatrices (int [,] matrix1, int [,] matrix2)
{   

    int [,] NewMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            NewMatrix[i,j] = matrix1[i,j] * matrix2[i,j];
        }

    }
    return NewMatrix;
}

Console.WriteLine("Введите размер массива");
Console.Write("Количество строк = ");
int countLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов = ");
int countColumns = Convert.ToInt32(Console.ReadLine());

while (countLines <= 0 || countColumns <= 0)
{
    Console.Write("Количество строк = ");
    countLines = Convert.ToInt32(Console.ReadLine());
    Console.Write("Количество столбцов = ");
    countColumns = Convert.ToInt32(Console.ReadLine());
}

int [,] array1 = Fillarr(countLines, countColumns);
int [,] array2 = Fillarr(countLines, countColumns);
int [,] productArrays = ProductTwoMatrices(array1, array2);
Console.WriteLine();
Console.WriteLine("Первый массив");
Printarr (array1);
Console.WriteLine();
Console.WriteLine("Второй массив");
Printarr (array2);
Console.WriteLine();
Console.WriteLine("Произведение массивов");
Printarr (productArrays);

