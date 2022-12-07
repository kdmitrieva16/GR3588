int number= int.Parse(Console.ReadLine()??"0");
int result1=number%7;
int result2=number%23;
if (result1==0&&result2==0)
{
    Console.WriteLine(number +" делится на 7 и на 23");
}
else
{
Console.WriteLine(number +" не делится на 7 и на 23");
}