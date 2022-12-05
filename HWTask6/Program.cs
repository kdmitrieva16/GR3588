// Считываем данные с консоли
string? inputLine = Console.ReadLine();

//  Проверяем, что бы данные были не пустыми
if (inputLine != null)
{
    // Парсим введенное число
    int inputNumber = int.Parse(inputLine);

    // Определяем остаток от деления на 2
    int outLine = inputNumber % 2;
    //
    if (outLine == 0)
    {
        Console.WriteLine("Число " + inputNumber + " - Четное");
    }
    else
    {
        Console.WriteLine("Число " + inputNumber + " - Нечетное");
    }
}