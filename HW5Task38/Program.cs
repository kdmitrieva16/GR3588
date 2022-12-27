double[] array = GenArr(5, 10, 200);
PrintDataArr(array);
double min = double.MaxValue;
double max = double.MinValue;
MinMax(array);
double res = max-min;
PrintResult(max + "-"  +min +" = "+ res);


double[] GenArr(int len, int minV, int maxV)
{
    Random rnd = new Random();
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((minV + rnd.NextDouble() * (maxV - minV)),2);

    }
    return arr;
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


// Define min and max value

void MinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }

        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
}

// Print result

void PrintResult(string line)
{
    Console.WriteLine(line);
}