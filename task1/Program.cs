//Задайте массив, заполненный случайными трехзначными числами.
//Напишите программу, которая покажет количество четных чисел в массиве.
//[345, 897, 568, 234] -> 2.

int[] GenerateArray(int len = 10) // функция генерации массива
{
    int[] array = new int[len];
    Random rnd = new Random(); // рандомные элементы массива
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(99, 1000);
    }
    return array;
}

int number(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

void PrintArray(int[] array)// вызывает фугкцию, написанную выше
{
    foreach (int item in array) // альтернативный цикл фор (работает не с индексами, а с элементами массива)
    {
        System.Console.Write($"{item}\t"); // вовдит элемент массива
    }
    System.Console.WriteLine();
}
int[] array = GenerateArray(10);
PrintArray(array);
System.Console.WriteLine($"чётных чисел в массиве: {number(array)}");