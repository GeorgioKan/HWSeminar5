// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] RandomArrayCreation(int size, int leftValue, int rightValue)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftValue, rightValue + 1);
    }
    return arr;
}

int SummOfOddNumbers(int[] arr)
{
    int summ = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        summ += arr[i];
    }
    return summ;
}

int[] array = RandomArrayCreation(4, -20, 20);
System.Console.WriteLine("[" + string.Join(",", array) + "]");
int summ = SummOfOddNumbers(array);
System.Console.WriteLine(summ);