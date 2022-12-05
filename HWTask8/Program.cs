// Считываем данные с консоли
string? inputLine = Console.ReadLine();

//  Проверяем, что бы данные были не пустыми
if (inputLine != null)
{
    // Парсим введенное число
    int inputNumber = int.Parse(inputLine);

    int startNumber = 2;

    // Выходное значение
    string evenNums = string.Empty;

    // Находим четные числа до заданного
    while (startNumber < inputNumber)
    {
        evenNums = evenNums + startNumber + ",";
        startNumber = startNumber + 2;
    }

    //Выводим в консоль исходное число если оно четное
    if (inputNumber % 2 == 0)
    {
        evenNums = evenNums + inputNumber;
    }
    //Выводим данные в консоль
    Console.WriteLine(evenNums);

}