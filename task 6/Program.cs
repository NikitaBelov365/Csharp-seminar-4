// Задача *: Напишите программу, которая из массива случайных 
// чисел. Ищет второй максимум (число меньше максимального элемента, 
// но больше всех остальных). Постарайтесь сделать одним циклом.

int InputArraySize(string msg)
{
    System.Console.WriteLine(msg);
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    System.Console.WriteLine("Input integer pls.");
    return 0;
}

int[] ArrayCreation(int arraySize)
{
    int[] array = new int[arraySize];
    return array;
}

void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 9);
    }
}

void PrintArray(int[] array)
{
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write(", " + array[i]);
    }
    System.Console.WriteLine();
}

int SecondMaxValue(int[] array)
{
    int maxValue = 0;
    int secondMaxValue = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxValue)
        {
            secondMaxValue = maxValue;
            maxValue = array[i];
        }
        else if (array[i] > secondMaxValue)
        {
            secondMaxValue = array[i];
        }
    }

    return secondMaxValue;
}

int arraySize = InputArraySize("Enter array size:");
int[] array = ArrayCreation(arraySize);
FillArray(array);
PrintArray(array);
int secondMaxValue = SecondMaxValue(array);
System.Console.WriteLine(secondMaxValue);