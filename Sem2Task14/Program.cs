// Считываем данные с консоли  проверяем на 0 и парсим
int number= int.Parse(Console.ReadLine()??"0");

//Проверяем делится ли введенное число на 7 
int result1=number%7;

//Проверяем делится ли введенное число на 23 
int result2=number%23;

// выводим результат
if (result1==0&&result2==0)
{
    Console.WriteLine(number +" делится на 7 и на 23");
}
else
{
Console.WriteLine(number +" не делится на 7 и на 23");
}