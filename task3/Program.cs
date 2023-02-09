// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3, 7, 2, 22, 78] -> 76

double[] GenerateArray(int len = 10) // функция генерации массива
{
    double[] array = new double[len];
    Random rnd = new Random(); // рандомные элементы массива
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 10);
    }
    return array;
}

void PrintArray(double[] array)// вызывает фугкцию, написанную выше
{
    foreach (int item in array) // альтернативный цикл фор (работает не с индексами, а с элементами саммисва)
    {
        System.Console.Write($"{item}\t"); // вовдит элемент массива
    }
    System.Console.WriteLine();
}

double min = Int32.MaxValue;
double max = Int32.MinValue;
double[] MinMax(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return array;
}
double[] array = GenerateArray(5);
PrintArray(MinMax(array));
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
