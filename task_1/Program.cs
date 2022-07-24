// task 62. Заполните спирально массив 4 на 4.


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
  