  Задача 34
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
___________________________________________________________________________________


int Prompt(string message)
{
    System.Console.WriteLine(message);
    int a = Convert.ToInt32(System.Console.ReadLine());
    return a;

}

int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;

}

void PrintArray(int[] array)
{
    System.Console.Write("Массив: {");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("}");
}

int CountEven(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result = result + 1;
        }
    }
    System.Console.WriteLine($"Количество четных чисел в массиве = {result}");
    return result;

   
}

 bool CheckNum(int number)
 {
    while (number<99 || number>999)
    {
        System.Console.WriteLine("Неверное число");
        return false;
    }
        return true;
 }
int length = Prompt("Введите длину массива:");

int min = Prompt("Введите минимальное значение массива:");
int max = Prompt("Введите максимальное значение массива:");

int[] array = GenerateArray(length, min, max);
PrintArray(array);
CountEven(array);