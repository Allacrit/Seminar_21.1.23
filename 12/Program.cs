Console.Clear();
Console.WriteLine("12. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.");

Console.Write("Введите длину массива: ");
int sizeArray = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество элементов массива: {sizeArray}");

int min = 1;
int max = 100;

int[] array = FillArray(sizeArray, min, max);

PrintArray(array);
PrintProductPairs(array);

int[] FillArray(int size, int randomMin, int randomMax)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(randomMin, randomMax + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

void PrintProductPairs(int[] dataArray)
{
    Console.WriteLine("Результат сложения пар:");
    int last = dataArray.Length - 1;
    for (int i = 0; i < dataArray.Length / 2; i++)
    {
        Console.WriteLine($"{dataArray[i]} x {dataArray[last]} = {dataArray[i] * dataArray[last]} ");
        last--;
    }
    if (dataArray.Length % 2 > 0) Console.WriteLine($"Число {dataArray[dataArray.Length / 2]} не имеет пары");
    Console.WriteLine();
}