using System.Numerics;

int numberA=ReadData("Input number A");
BigInteger res1=CalcFactor(numberA);
PrintResult("Factorial is:"+res1);


// Read data from user
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


//Calculate factorial
BigInteger CalcFactor(int numA)
{
    BigInteger res = 1;
    for (int i = 1; i <= numA; i++)
    {
        res *= i;
    }
    return res;
}


// Print result

void PrintResult(string line)
{
    Console.WriteLine(line);
}
