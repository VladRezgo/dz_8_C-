//task 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int [,] Fillarr (int rows, int columns )
{
    int[,] newarr = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newarr[i, j] =  new Random().Next(1, 10);

        }
    }
    return newarr;
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

int [] MassivSumm (int[,] arr)
{
    int [] sumArray = new int [arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr [i,j];
        }
        sumArray[i] = sum;

    }
    return sumArray;
}

int MinSum (int [] arr)
{
    int min = arr[0];
    int numStr = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]<min) 
        {
            min = arr[i];
            numStr = i;
        }

    }
    return numStr;
}

Console.WriteLine("Введите размер массива");
Console.Write("Количество строк = ");
int countLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов = ");
int countColumns = Convert.ToInt32(Console.ReadLine());

int [,] array = Fillarr(countLines, countColumns);
Printarr (array);
int MinStr = MinSum(MassivSumm(array)) + 1;
Console.WriteLine($" Строка с наименьшей суммой элементов - {MinStr} ");