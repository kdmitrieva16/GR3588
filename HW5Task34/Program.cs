int[] array = GenArr(10,100,999);
PrintDataArr(array);
int result=CountEvenElements(array);
PrintResult("Count of even elements= "+ result);

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

//Calculate count of even elements

int CountEvenElements(int[]arr)
{
    int res=0;
    for (int i=0; i<arr.Length;i++)
    {
        if (arr[i]%2==0)
        {
            res++;
        }
        
    }
    return res;
}