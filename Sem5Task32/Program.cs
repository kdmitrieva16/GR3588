﻿int[] array = GenArr(10, -9, 9);
PrintDataArr(array);
int[] newArray = InverseArr(array);
PrintDataArr(newArray);

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

//Inverse array

int[] InverseArr(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[i] = arr[i] * (-1);
    }
    return outArr;
}