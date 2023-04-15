//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int NumberEntry()
{
    Console.Write("Введите трехзначное число= ");
    return Convert.ToInt32(Console.ReadLine());
}

void ThirdDigit(int number)
{
    number = number / 100;
    if (number == 0)
    {
        Console.WriteLine("Нет третей цифры");
    }
    else
    {
        number = number % 10;
        Console.WriteLine($"Третяя цифра = {number}");
    }
}

int num = NumberEntry();
ThirdDigit(num);