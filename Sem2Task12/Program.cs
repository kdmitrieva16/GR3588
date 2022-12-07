// Считываем данные с консоли  проверяем на 0 и парсим
int number1= int.Parse(Console.ReadLine()??"0");
int number2= int.Parse(Console.ReadLine()??"0");

// Проверяем делится ли второе число на первое без остатка и выводим результат
int result=number2%number1;
if (result==0)
{
    Console.WriteLine(number1+" кратно "+number2);
}
else
{
Console.WriteLine(result);
}