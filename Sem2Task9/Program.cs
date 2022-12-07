// Создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

// Получаем новое случайное число
int number = numberSintezator.Next(10, 100);

// Выводим данные в консоль
Console.WriteLine(number);

//
int firstNumber = number / 10;
int secondNumber = number % 10;

//
if (firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(secondNumber);
}
