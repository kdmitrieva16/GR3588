// Считываем данные с консоли  проверяем на 0 и парсим
int inputNumber = int.Parse(Console.ReadLine() ?? "0");

// Проверяем является ди введенное число трехзначным 
if (inputNumber < 1000 && inputNumber > 99)
{
    int secondDigit = ((inputNumber / 10) % 10);

    //Определяем воторую цифру и выводим ее
    Console.WriteLine("Вторая цифра - " + secondDigit);
}
else
{
    // Выводим сообщение что число не трехзначное
    Console.WriteLine("Введенное число не трёхзначное");
}