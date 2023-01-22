Console.Clear();
Console.WriteLine("8. Определить, присутствует ли в заданном массиве, некоторое число.");

Console.Write("Введите длинну массива: ");
int sizeArray = int.Parse(Console.ReadLine());

int min = 1;
int max = 50;

Console.WriteLine($"Создан массив длинной {sizeArray} сгененированными значениями от {min} до {max}.");

int[] array = CreateArray(sizeArray, min, max);
PrinArray(array);

Console.Write($"Введите искомое число от {min} до {max}: ");
int searchNumber = int.Parse(Console.ReadLine());

string Result = "отсутствует";
if (FindNumber(array, searchNumber)) Result = "присутствует";

Console.WriteLine($"Число {searchNumber} {Result} в массиве.");

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

bool FindNumber(int[] array, int Number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == Number) return true;
    }
    return false;
}

void PrinArray(int[] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}