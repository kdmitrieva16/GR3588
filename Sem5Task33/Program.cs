
int[] array = GenArr(20, 0, 100);
PrintDataArr(array);
int numberA = ReadData("Input number A");
int isNumberExist = SearchNum(array, numberA);
if (isNumberExist >= 0)
{
    PrintResult("Index of  " + numberA + " at the array: " + isNumberExist);
}
else
{
    PrintResult("No number " + numberA + " at the array");
}

// Read data from user
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


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

// Search number

int SearchNum(int[] arr, int num)
{
    int res = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            res = i;
            break;
        }
    }
    return res;

}

// Print result

void PrintResult(string line)
{
    Console.WriteLine(line);
}