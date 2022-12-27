int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArray(arr2D);
double[] averageCol = AwgCol(arr2D);
PrintDataArr(averageCol);

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

//Calculation average 

double[] AwgCol(int[,] arr)
{
    int i = 0;
    int j = 0;

    double[] average = new double[arr.GetLength(1)];
    for (j = 0; j < arr.GetLength(1); j++)
    {


        for (i = 0; i < arr.GetLength(0); i++)
        {
            average[j] += arr[i, j];
        }
        average[j] = Math.Round((average[j] / arr.GetLength(0)),2);
    }
    return average;
}

// Print Array

void PrintDataArr(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}