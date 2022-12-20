int[] array = GenArr(10,-100,999);
PrintDataArr(array);
int sumOddPos=SumOfOddElements(array);
PrintResult("Sum of not even elements= "+ sumOddPos);

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

// Print Array

void PrintDataArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// Print result

void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Calculate sum of odd position elements

int SumOfOddElements(int[]arr)
{
    int res=0;
    int i=1;
    while (i<arr.Length)
    {
        res=res+arr[i];
        i=i+2;   
    }
    return res;
}