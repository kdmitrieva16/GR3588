int number = ReadData("Введите число N: ");
string resultLine = LineGenRec(number);
PrintResult(resultLine);

// Read data from user
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Print result
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}


// Recur generation
string LineGenRec(int num)
{
    if (num <= 0)
    {
        return string.Empty;
    }
    else
    {
        string outLine = LineGenRec(num - 1) + " " + num;
        return outLine;
    }
}

