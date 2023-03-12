using System;

//Задача 10. Напишите программу которая принимает на вход трёхзначное число,
//и на выходе показывает вторую цифру этого числа

int CutMiddleDigit(int input)
{
    return input / 10 % 10;
}

Console.Write("Введите трёхзначное число: ");
int userInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Среднее число: {CutMiddleDigit(userInput)}");

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int CutTail(int input) //отрезает хвост
{
    while(input >= 1000)
    {
        input = input / 10;
    }
    return input;
}

int CutHead(int input) //отрезает голову
{
     return input % 10;
}

void PrintException() //выводит исключение
{
    Console.WriteLine("Третьей цифры нет");
}

int Reverse(int input) //меняет знак
{
    return input *= -1;
}

Console.Write("Введите любое целое число: ");
int input = Convert.ToInt32(Console.ReadLine());

if(input < 0)
{
    input = Reverse(input);
} 

if(input < 100)
{
    PrintException();
} 
else
{
    int offTail = CutTail(input);
    int result = CutHead(offTail);
    Console.WriteLine($"Третье число: {result}");
} 

//Задача 15: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.

bool RangeCheck(int day)
{
    if(day > 0 && day < 8)
    {
        return true;
    } 
    return false;
}

bool WeekendCheck(int day)
{
    if(day == 6 || day == 7)
    {
        return true;
    }
    return false;
}

void WeekendText()
{
    Console.WriteLine("Сегодня выходной!");
}

void WeekdayText()
{
    Console.WriteLine("Сегодня рабочий день!");
}

void ExceptionText()
{
    Console.WriteLine("Вы ввели некорректное число!");
}

Console.Write("Введите день недели от одного до семи: ");
int day = Convert.ToInt32(Console.ReadLine());

bool inRange = RangeCheck(day);
bool isWeekend = WeekendCheck(day);

if(inRange)
{
    if(isWeekend)
    {
        WeekendText();
    }
    else WeekdayText();
}
else ExceptionText();