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

int Reverse(int input) //меняет знак
{
    if(input < 0)
    return input *= -1;
    else return input;
}

void PrintResult(int result) //выводит результат
{
    System.Console.WriteLine($"Третье число: {result}");
}

void PrintException() //выводит исключение
{
    Console.WriteLine("Третьей цифры нет");
}

bool InRange(int input) //проврка диапазона числа
{
    if(input <= -100 || input >= 100) return true;
    else return false;
}

Console.Write("Введите любое целое число: ");
int input = Convert.ToInt32(Console.ReadLine());

bool range = InRange(input);

if(!range) PrintException();
else
{
    input = Reverse(input);
    int offTail = CutTail(input);
    int result = CutHead(offTail);
    PrintResult(result);
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
    else
    {
        WeekdayText();
    } 
}
else ExceptionText();