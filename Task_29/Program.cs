/*
Задача 29: Напишите программу, которая принимает
на вход длину массива, минимальное значение массива
и максимальное значение массива, создаёт массив с 
заданными параметрами и выводит значения на экран

 5, 1, 19 -> [1, 2, 5, 7, 19]
3, 1, 33 -> [6, 1, 33]

*/

Console.Clear();

// Вводим данные
int arrayLength = GetIntInput("Введите длину массива (больше 0): ");

// Проверяем, чтобы длина массива была больше 0
if (Validation(arrayLength))
{
    int minNum = GetIntInput("Введите минимальное значение массива: ");
    int maxNum = GetIntInput("Введите максимальное значение массива: ");

    int[] array = new int[arrayLength]; // Создаем новый массив
    FillArray(array, minNum, maxNum);   // Заполняем массив
    Console.Write("Массив: ");
    PrintArray(array);                  // Выводим массив функция PrintArray

    // Выводим массив без функции (так быстрее)
    //Console.WriteLine("[{0}]", string.Join(", ", array));
}
Console.WriteLine("Нажмите любую клавишу");
Console.ReadKey();

// Функция ввода числа с выводом сообщения
int GetIntInput(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

// Функция проверки, если длина массива должна быть больше 0
bool Validation(int numArray)
{
    if (numArray <= 0)
    {
        Console.WriteLine($"Вы ввели длину массива: {arrayLength}, необходимо больше 0");
        return false;
    }
    return true;
}

// Заполняем массив случайными числами
void FillArray(int[] collection, int min, int max)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(min, max + 1);
    }
}

// Функция вывода массива
void PrintArray(int[] col)
{
    Console.Write("[");
    for (int position = 0; position < col.Length - 1; position++)
    {
        Console.Write($"{col[position]}, ");
    }
    Console.Write(col[col.Length - 1] + "]");
    Console.WriteLine();
}