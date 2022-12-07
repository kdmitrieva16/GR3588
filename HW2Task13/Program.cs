// Считываем данные с консоли  проверяем на 0 и парсим
//int inputNumber = int.Parse(Console.ReadLine() ?? "0");

// Проверяем есть ли третья цифра 
//if (inputNumber>99)
//{
//Определяем третью цифру и выводим ее

//char[] digits = inputNumber.ToString().ToCharArray();
//Console.WriteLine("Третья цифра числа  "+inputNumber+" - "+digits[2]);
//}
//else
//{
// Выводим сообщение что число не трехзначное
//Console.WriteLine(inputNumber+" - Третьей цифры нет ");
//}


// Вариант 2

// Считываем данные с консоли  проверяем на 0 и парсим
int inputNumber = int.Parse(Console.ReadLine() ?? "0");
//Определяем длину введенного числа
int lengthOfInputNumber = (int)Math.Log(inputNumber, 10) + 1;

//Проверяем есть ли третья цифра в числе

if (lengthOfInputNumber > 2)
{
    //Определяем третью цифру и выводим результат
    int degree = (int)Math.Pow(10, lengthOfInputNumber - 3);
    int thirdNumber = (inputNumber / degree) % 10;
    Console.WriteLine("Третья цифра в числе " + inputNumber + " - " + thirdNumber);
}
else
{
    // Выводим сообщение об отсутствии третьей цифры
    Console.WriteLine(inputNumber + " - Третьей цифры нет ");
}


