Console.Clear();
Console.WriteLine("10. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].");
int sizeArray = 123;
int min = -100;
int max = 200;

PrintCountArray(FillArray(sizeArray, min, max));

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintCountArray(int[] arr)
{
    int count = 1;
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
        if (arr[i] >= 10 && arr[i] <= 99) count++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество чисел из диапазона от 10 до 99 равно {count}.");
    Console.WriteLine();
}