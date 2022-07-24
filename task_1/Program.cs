// task 62. Заполните спирально массив 4 на 4.
/*
 int rows = 5;
 int columns = 5;
int x = 0;
int y = 0;
int bx = 1;
int by = 0;
int [,] array = new int [rows,columns];

for (int i = 0; i <= rows*columns; i++)
{
    array [y, x] = i+1;
    int test = 0;
    if (bx != 0) test = x + bx;
    else test = y + by;
    if (test < 0 || test == rows || array[y + by, x + bx] != 0)
    {
        int oldX = bx;
        bx = -by;
        by = oldX;
    }
    y += by;
    x += bx;
}
for (int i = 0; i < columns; i++)
{
    for (int j = 0; j <columns; j++)
    {
        Console.Write (array [i,j]+"    ");
    }
    Console.WriteLine();
} 
*/
//Заполните спирально массив 4 на 4.

//Заполните спирально массив 4 на 4.

int[] FillArray (int n)
{
    int[] newArray = new int [n*n];
    for (int i = 0; i < n*n; i++)
    {
        newArray [i] = i+1;
    }
    return newArray;
}


int number = 4;
int [] array = FillArray(number);
Console.Clear();
int rows = Console.CursorTop;
int columns = Console.CursorLeft;

for (int i = 0; i < number*number; i++)
{
       if (array[i] <= number)
        {
            columns += 4;
            Console.SetCursorPosition(columns, rows);
            Console.Write (array[i]);

        }

        if (array[i] > number && array[i] <= number+number-1)
        {
           rows += 4;
           Console.SetCursorPosition(columns, rows);
           Console.Write (array[i]);

        }
        if (array[i] > number+number-1 && array[i] <= number*3-2)
        {
           columns -= 4;
           Console.SetCursorPosition(columns, rows);
           Console.Write (array[i]);

        }
        if (array[i] > number*3-2 && array[i] <= number*3)
        {
           rows -= 4;
           Console.SetCursorPosition(columns, rows);
           Console.Write (array[i]);

        }
        if (array[i] > number*3 && array[i] <= number*3+2)
        {
           columns += 4;
           Console.SetCursorPosition(columns, rows);
           Console.Write (array[i]);

        }
        if (array[i] > number*3+2 && array[i] <= number*4-1)
        {
           rows += 4;
           Console.SetCursorPosition(columns, rows);
           Console.Write (array[i]);

        }
        if (array[i] > number*4-1 && array[i] <= number*4)
        {
           columns -= 4;
           Console.SetCursorPosition(columns, rows);
           Console.Write (array[i]);

        }
    }
  