int positivSum = 0;
int negativSum = 0;
int[] testArr = GenArr(12, -9, 9);
NegativePositiveSum(testArr);
PrintDataArr(testArr);
PrintData("Sum of positive: ", positivSum);
PrintData("Sum of negative: ", negativSum);

// Array generated

int[] GenArr(int len, int minV, int maxV)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minV, maxV + 1);
    }
    return arr;
}

// Print result

void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

void NegativePositiveSum(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positivSum += arr[i];
        }
        else
        {
            negativSum += arr[i];
        }
    }
}

// Print Array

void PrintDataArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

