/* task 54Задайте двумерный массив. Напишите программу, которая упорядочит по 
убыванию элементы каждой строки двумерного массива. */

int [,] Fillarr (int rows, int columns )
{
    int[,] newArr = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArr[i, j] =  new Random().Next(1, 10);

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
            Console.Write(arr [i,j]+" ");
        }
        Console.WriteLine();
    }
}

int [,] StringOrdering (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int k = 0;
            while (k < arr.GetLength(1)-1 )
            {
                if (arr[i,k+1] > arr[i,k])
                {
                    int x = arr[i,k];
                    arr[i,k] = arr[i,k+1];
                    arr[i,k+1] = x;
                    k++;
                 }
                 k++;

            }

        }
    }
    return arr;
}

Console.Write("Количество строк = ");
int countLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов = ");
int countColumns = Convert.ToInt32(Console.ReadLine());



int [,] array = Fillarr(countLines, countColumns);
Printarr (array);
Console.WriteLine();

StringOrdering(array);
Printarr (array);