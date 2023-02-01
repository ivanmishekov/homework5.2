/*
Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] CreateNumbersArray()
{
    Console.Write("Введите кол-во чисел для массива > ");
    int len = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
    return array;
}


void PrintArray(int[] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}


int Sum(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            summ += array[i];
        }
    }
    return summ;
}

int[] numbersArray = CreateNumbersArray();
PrintArray(numbersArray, "Массив:");
System.Console.WriteLine($"Сумма элементов на нечётных позициях -> {Sum(numbersArray)}");