int number = ReadData("Сколько чисел будете вводить:");
int result=CountPosNum(number);
PrintData("Количество положительных чисел: "+result);
// Count Positive Number
int CountPosNum(int  num)
{
int res=0;
while(num>0)
{
    if (ReadData("Input number")>0)
    res++;
    num--;
}
return res;
}

//Input data
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Print Result

void PrintData(string res)
{
    Console.WriteLine(res);
}