int[] array = GenArr(10, -100, 999);
PrintDataArr(array);
Console.WriteLine();
int[] sortedArray = BubbleSortArr(array);
PrintDataArr(sortedArray);

int[] GenArr(int len, int minV, int maxV)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
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

//Bubble sort array

int[] BubbleSortArr(int[] arr)
{
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                int temp = 0;
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        return array;
    }

}