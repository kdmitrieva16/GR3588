
int numberA=ReadData("Input number A");
int res1=VariantSumSimple(numberA);
int res2=VariantSumGause(numberA);
DateTime d1=DateTime.Now;
PrintResult("Sum of numbers from 1 to A (simple) is:"+res1);
Console.WriteLine(DateTime.Now-d1);
DateTime d2=DateTime.Now;
PrintResult("Sum of numbers from 1 to A (simple) is:"+res2);
Console.WriteLine(DateTime.Now-d2);


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

// Calculate sum
int VariantSumSimple(int numA)
{

    int sumOfNumbers=0;
    for (int i = 1; i <= numA; i++)
    {
        sumOfNumbers += i;
    }
    return sumOfNumbers;
}

//Calulate sum Gause
int VariantSumGause(int numA)
{
    int sumOfNumbers=0;
    sumOfNumbers=((1+numA)*numA)/2;
    return sumOfNumbers;
}