int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D1 = Fill2DArray(row, column, 10, 99);
Print2DArray(arr2D1);
Console.WriteLine();
int[,] arr2D2 = Fill2DArray(row, column, 10, 99);
Print2DArray(arr2D2);
Console.WriteLine();
int [,] multResult=ArrayMultiplication(arr2D1,arr2D2);
Print2DArray(multResult);

//Read data from user
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Generation 2-x array
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}


// Print 2-x array
void Print2DArray(int[,] matrix)
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

  // Array multiplication
    static int[,] ArrayMultiplication(int[,] arrayA, int[,] arrayB)
    {       
        
        int [,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

        for (int i = 0; i < arrayA.GetLength(0); i++)
        {
            for (int j = 0; j < arrayB.GetLength(1); j++)
            {
                arrayC[i, j] = 0;

                for (int k = 0; k < arrayA.GetLength(1); k++)
                {
                    arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
                }
            }
        }

        return arrayC;
    }