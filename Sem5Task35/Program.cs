int[] array = GenArr(123, -100, 100);
PrintDataArr(array);
int result = CountElement(array, 10, 99);
Console.WriteLine();
PrintData("Количество элементов массива, значения которых лежат в отрезке [10,99] составляет: ", result);

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

// Print Array

void PrintDataArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// Count element

int CountElement(int[] array, int min, int max)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > min && array[i] < max)
        {
            res++;
        }
    }
    return res;
}


// Print result

void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}