// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] RandomArrayCreation(int size)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
    return array;
}

int CounterOfParity(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)    
    {
      if (arr[i] % 2 == 0)
      {
        counter++;
      }
    }
    return counter;
}

int size = 4;
int[] arr = RandomArrayCreation(size);
int numb = CounterOfParity(arr);
Console.WriteLine("[" + string.Join(",", arr) + "]");
Console.WriteLine($"The number of even numbers is {numb}.");
