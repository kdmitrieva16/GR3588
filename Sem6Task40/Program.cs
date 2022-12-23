
int A = ReadData("Enter first number: ");//1c
int B = ReadData("Enter second number: ");//1c
int C = ReadData("Enter third number: ");//1c
//TriangleTest(A,B,C);//50c
PrintData ("Result: "  + TriangleTest(A,B,C));//1





int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

bool TriangleTest (int a, int b, int c)
{
    return ((a+b>c)&& (a+c>b)&& (b+c>a));
}