int numberN = ReadData("Input number N: ");
int sumOfDigits = SumDigit(numberN);
PrintResult("Sum of digits " + numberN + " = " + sumOfDigits);


// Read data from user
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Print result

void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Calculate sum of digits of number

int SumDigit(int numN)
{
    int res = 0;

    while (numN > 0)
    {
        res += numN % 10;
        numN = numN / 10;
    }
    return res;
}