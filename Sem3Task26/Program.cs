
int numberA=ReadData("Input number A");
int res1=NumberOfDigits(numberA);
PrintResult("Count of digits is:"+res1);


// Read data from user
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Print result

void PrintResult(string  line)
{
    Console.WriteLine(line);
}

//Lenghs of number (Log)
int NumberOfDigits(int numN)
{
    int count = (int)Math.Log10(numN) + 1;
    return count;
}