// Считываем данные с консоли
string? inputLine = Console.ReadLine();

//  Проверяем, что бы данные были не пустыми
if (inputLine != null)
{
    // Парсим введенное число
    int inputNumber = int.Parse(inputLine);
    // Определяем остаток от деления на 10
    int outLine = inputNumber % 10;
    //Выводим данные в консоль
    Console.WriteLine(outLine);
}

