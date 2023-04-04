/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16

*/

int GetIntInput(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int Exponention(int digOne, int digTwo)
{
    int multiplication = digOne;
    for (int i = 1; i < digTwo; i++)
    {
        multiplication *= digOne;
    }
    return multiplication;
}

Console.Clear();

int numA = GetIntInput("Введите число A: ");
int numB = GetIntInput("Введите число B: ");

int powAB = Exponention(numA, numB);
Console.WriteLine($"{numA} ^ {numB} = {powAB}");
