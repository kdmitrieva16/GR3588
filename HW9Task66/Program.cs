int number1 = ReadData("Input number M: ");
int number2 = ReadData("Input number N: ");
int sum = number1<number2? SumMN(number1, number2):SumMN(number2, number1);
PrintResult(sum);

// Read data from user
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Print Result
void PrintResult(int prefix)
{
    Console.Write(prefix);
}

int SumMN(int M, int N)
{
    int outRes = 0;
    if (M >= N) return N;
     outRes = M + SumMN(M + 1, N);
    return outRes;
}

