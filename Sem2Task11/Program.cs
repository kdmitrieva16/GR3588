// Создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

// Получаем новое случайное число
int number = numberSintezator.Next(100, 1000);

// Выводим данные в консоль
Console.WriteLine(number);

//Получаем первое число
int firstNumber = number/100;

//Получаем третье число
int thirdNumber = number%10;
int result =firstNumber*10+thirdNumber;

Console.WriteLine(result);