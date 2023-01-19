// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, double min, double max)
{
double[] arr = new double[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
double num = rnd.NextDouble() * (max - min) + min;
arr[i] = Math.Round(num, 2);
}
return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

double MaxElementArray(double[] arr)
{
    double maxElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxElement) maxElement = arr[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальный элемент массива => {maxElement}");
    return maxElement;
}

double MinElementArray(double[] arr)
{
    double minElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minElement) minElement = arr[i];
    }
    Console.Write($"Минимальный элемент массива => {minElement}");
    return minElement;
}

double [] array = CreateArrayRndDouble(7, 2, 11);

PrintArray(array);

double DifferenceMaxMin = MaxElementArray(array) - MinElementArray(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {DifferenceMaxMin}");