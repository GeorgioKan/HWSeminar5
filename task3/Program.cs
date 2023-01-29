// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] RandomArrayCreation(int size, int leftValue, int rightValue)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.Next(leftValue, rightValue) + rand.NextDouble(), 3);
    }
    return arr;
}

double MaxMinFinder(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    double diff = max - min;
    return diff;
}

double[] arr = RandomArrayCreation(5, 1 , 100);
Console.WriteLine("[ " + string.Join(" ; ", arr) + " ]");
double diff = MaxMinFinder(arr);
Console.WriteLine(diff);

