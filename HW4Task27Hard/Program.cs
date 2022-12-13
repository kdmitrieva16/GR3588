int numberN = ReadData("Input number N: ");
int sumOfDigits = SumDigit(numberN);
DateTime d1 = DateTime.Now;
PrintResult("Sum of digits " + numberN + " = " + sumOfDigits);
Console.WriteLine(DateTime.Now - d1);

int sumOfDigits2 = SumDigitString(numberN);
DateTime d2 = DateTime.Now;
PrintResult("Sum of digits " + numberN + " = " + sumOfDigits2);
Console.WriteLine(DateTime.Now - d2);


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

// Calculate sum of digits of number (string)

int SumDigitString(int numN)
{
    string stringDigit = numN.ToString();
    char[] digits = stringDigit.ToCharArray();
    int sum = 0;
    for (int i = 0; i < stringDigit.Length; i++)
    {
        sum += Convert.ToInt32(digits[i] - '0');
    }
    return sum;
}