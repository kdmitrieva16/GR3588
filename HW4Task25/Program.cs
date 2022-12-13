int numA = ReadData("Input number A: ");
int numB = ReadData("Input number B: ");
int powBOfA = Pow(numA, numB);
PrintResult(numA + "^" + numB + " = " + powBOfA);

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

// Calculate Pow

int Pow(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
        res = a * res;
    }
    return res;
}