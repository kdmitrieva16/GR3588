int numberM = ReadData("Enter number M:");
int numberN = ReadData("Enter number N:");
int ackRes=AckFun(numberM,numberN);
PrintResult(ackRes);

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

// ackerman function
int AckFun(int  numM, int numN)
{
  if (numM == 0)
    return numN + 1;
  else
    if ((numM!= 0) && (numN == 0))
      return AckFun(numM - 1, 1);
    else
      return AckFun(numM - 1, AckFun(numM, numN - 1));
}