int[] array = GenArr(10, 0, 99);
PrintDataArr(array);
int[] insSortedArr = InsertSortArr(array);
PrintDataArr(insSortedArr);
int result=insSortedArr[9]-insSortedArr[0];
PrintResult("max - min  = "+ result);
int[] countSortedArr = CountingSort(array, 99);
PrintDataArr(countSortedArr);

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


//Sort by insert

int[] InsertSortArr(int[] arr)
{
    {
        for (int i = 1; i < array.Length; i++)
        {
            int temp = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > temp)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = temp;
        }
        return array;
    }

}
//Sort by count

 static int[] CountingSort(int[] array, int k)
    {
        var count = new int[k + 1];
        for (var i = 0; i < array.Length; i++)
        {
            count[array[i]]++;
        }

        var index = 0;
        for (var i = 0; i < count.Length; i++)
        {
            for (var j = 0; j < count[i]; j++)
            {
                array[index] = i;
                index++;
            }
        }

        return array;
    }

    // Print result

void PrintResult(string line)
{
    Console.WriteLine(line);
}