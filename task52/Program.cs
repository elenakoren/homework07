/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
столбце.
Например, задан массив:
1472
5 9 23
8424
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int GetNumber (string message)
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

int[,] InitMatrix(int m, int n)
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

void CountAverageForColumn(int[,] matrix)
{
    for(int j=0; j< matrix.GetLength(1); j++)
    {
        int columnTotal = 0;
        double average = 0.0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            columnTotal += matrix[i,j];
        }
        double doubleColumnTotal = Convert.ToDouble(columnTotal);
        double doubleElementsAmount = Convert.ToDouble(matrix.GetLength(0));
        average = doubleColumnTotal / doubleElementsAmount;
        Console.Write($"{average} ");
    }
}

int m = GetNumber("Введите кол-во строк");
int n = GetNumber("Введите кол-во столбцов");

int[,] matrix = InitMatrix(m,n);

PrintArray(matrix);

CountAverageForColumn(matrix);
