Console.Clear();
Console.WriteLine("7. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран.");
int sizeArray = 8;
int min = 0;
int max = 1;

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

PrintArray(CreateArray(sizeArray, min, max));