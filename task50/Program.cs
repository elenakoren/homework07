/*Напишите программу, которая на вход принимает позиции
элемента в двумерном массиве, и возвращает значение этого элемента
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int GetNumberFromConsole (string message)
{
    int result=0;
    
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Это не число");
        }
    }
    return result;
}
int [,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m,n];
    Random rnd = new Random();

    for(int i=0; i < matrix.GetLength(0); i++)
    {
        for (int j=0; j< matrix.GetLength(1); j++)
        {
            matrix[i,j]=rnd.Next(1,10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j=0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }

}

void GetElement(int[,] matrix, int row, int column)
{
    if(row>matrix.GetLength(0) && column>matrix.GetLength(1))
    {
        Console.WriteLine("Такого числа нет");
    }
    else
    {
        int result=matrix[row,column];
        Console.Write($"{result} ");
    }
    

}

int m = GetNumberFromConsole("Введите кол-во строк");
int n = GetNumberFromConsole("Введите кол-во столбцов");

int[,] matrix = InitMatrix(m,n);
PrintArray( matrix);

int row=GetNumberFromConsole("Введите номер строки");
int column=GetNumberFromConsole("Введите номер столбца");

GetElement(matrix, row, column);

Console.WriteLine();