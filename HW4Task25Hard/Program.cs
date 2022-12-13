int numA = ReadData("Input number A: ");
string mathOper = Operation();
int numB = ReadData("Input number B: ");
int resOfOper = 0;
if (mathOper == "+")
{
    resOfOper = Sum(numA, numB);
}
else if (mathOper == "-")
{
    resOfOper = Subtract(numA, numB);
}
else if (mathOper == "*")
{
    resOfOper = Mult(numA, numB);
}
else if (mathOper == "/")
{
    resOfOper = Div(numA, numB);
}
else if (mathOper == "^")
{
    resOfOper = Pow(numA, numB);
}
else
{
    PrintResult("Неизвестный оператор.");
}

PrintResult(numA + mathOper + numB + " = " + resOfOper);

// Read numbers from user
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Read math oper
string Operation()
{
    Console.WriteLine("Input math operation");
    string mOper = Console.ReadLine() ?? "";
    return mOper;
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

// Calculate Sum

int Sum(int a, int b)
{
    int res = a + b;
    return res;
}


// Calculate Difference

int Subtract(int a, int b)
{
    int res = a - b;
    return res;
}

// Calculate Multiplication

int Mult(int a, int b)
{
    int res = a * b;
    return res;
}

// Calculate Divide

int Div(int a, int b)
{
    int res = a / b;
    return res;
}