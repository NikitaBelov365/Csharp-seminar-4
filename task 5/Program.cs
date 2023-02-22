void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length / 2; i++)
    {
        array[rnd.Next(0, array.Length)] = 1;
    }
}

void PrintArray(int[] array)
{
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write(", " + array[i]);
    }
}

int InputArraySize(string msg)
{
    System.Console.WriteLine(msg);
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    System.Console.WriteLine("Only integers pls.");
    Environment.Exit(1);
    return 0;
}
// int arraySize = ;
// int [] array = new int[8]; задал массив новый длиной 8
int[] array = new int[InputArraySize("Input array size: ")];
FillArray(array);  // вызвали функцию заполнения массива
PrintArray(array);