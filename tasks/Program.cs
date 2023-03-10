                        /* Задача 34
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int a = Convert.ToInt32(System.Console.ReadLine());
    return a;

}

int[] GenerateArray(int Length)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(100, 999);
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

int length = Prompt("Введите длину массива:");
int[] array = GenerateArray(length);
PrintArray(array);
CountEven(array);

_________________________________________________________________________________
                       Задача 36
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0


int Prompt(string message)
{
System.Console.WriteLine(message);
string a = System.Console.ReadLine();
int length = int.Parse(a);
return length;
}
int[] GenerateArray(int Length)
{
    int [] Array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        Array[i] = random.Next(1, 10);
    }
    return Array;
}
void PrintArray(int[] Array)
{
    System.Console.Write("Массив: {");
    for (int i = 0; i < Array.Length - 1; i++)
    {
        System.Console.Write($"{Array[i]}, ");
    }
    System.Console.Write($"{Array[Array.Length - 1]}");
    System.Console.WriteLine("}");
}
int Sum(int[] Array)
{
    int result = 0;
    int i = 0;
    while (i < Array.Length)
    {
        result = result + Array[i];
        i = i+2;  
    }
    return result;
    
}
int length = Prompt("Введите размер массива");
int [] array = GenerateArray(length);
PrintArray(array);
Sum(array);
System.Console.WriteLine($"Сумма нечетных элементов массива: {Sum(array)}");
________________________________________________________________________________

                            Задача 38
Задайте массив вещественных чисел. Найдите разницу между максимальным
и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] GenerateArray(int Length)
{
    int[] Array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = random.Next(1, 1000);
    }
    return Array;
}

void PrintArray(int[] Array)
{
    System.Console.Write("Массив: {");
    for (int i = 0; i < Array.Length - 1; i++)
    {
        System.Console.Write($"{Array[i]}, ");
    }
    System.Console.Write($"{Array[Array.Length - 1]}");
    System.Console.WriteLine("}");
}

int Min(int[] Array)
{
    int min = Array[0];
    for (int i = 0; i < Array.Length; i++)

    {
        if (Array[i] < min)
        {
            min = Array[i];
        }
    }
    return min;
}
int Max(int[] Array)
{
    int max = Array[0];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > max)
        {
            max = Array[i];
        }
    }
    return max;
}
int[] array = GenerateArray(5);
PrintArray(array);
System.Console.WriteLine($"Минимальное значение = {Min(array)}");
System.Console.WriteLine($"Максимальное значение = {Max(array)}");
System.Console.WriteLine($"Разница Max-Min = {Max(array)-Min(array)}");
