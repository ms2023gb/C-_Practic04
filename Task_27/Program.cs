/*
Задача 27: Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

*/

int GetIntInput(string msg) // Функция ввода числа с выводом сообщения
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int AmountDigit(int num) // Функция подсчета количества цифр в числе
{
    int amount = 0;
    while (num != 0)
    {
        num /= 10;
        amount++;
    }
    return amount;
}

int Digit(int num, int dig) // Функция вывода цифры по номеру
{
    int digN = 0;
    for (int i = 1; i <= dig; i++)
    {
        digN = num % 10;
        num /= 10;
    }
    return digN;
}

int SumDigit(int number) // Функция подсчета суммы цифр в числе
{
    int sum = 0;
    for (int i = 1; i <= AmountDigit(number); i++)
    {
        sum += Digit(number, i);
    }
    return sum;
}

Console.Clear();

int numDigit = GetIntInput("Введите число: ");

int addDigit = SumDigit(numDigit);
Console.WriteLine($"Сумма цифр в числе {numDigit} = {addDigit}");
