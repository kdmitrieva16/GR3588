// Считываем данные с консоли  проверяем на 0 и парсим
int inputNumber = int.Parse(Console.ReadLine() ?? "0");

// Проверяем является ди введенное число днем недели
if (inputNumber < 8 && inputNumber > 0)
{
    // Определяем является ли введенное число выходным днем и выводим результат
    if (inputNumber > 5)
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }

}
else
{
    // Выводим сообщение что число не трехзначное
    Console.WriteLine("Введенное число не является днем недели");
}