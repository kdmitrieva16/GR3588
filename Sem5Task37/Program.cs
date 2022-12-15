int[] array = GenArr(123,-100,100);
PrintDataArr(array);
Console.WriteLine();
int[] result = ConvertArr(array);
PrintDataArr(result);
Console.WriteLine();


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

int[] ConvertArr(int[] array)
{
    int[] outArr = new int[array.Length/2];
    for (int i = 0; i < array.Length/2; i++)
    {
        outArr[i]=array[i]*array[array.Length-1 -i];
    }
    return outArr;
}