// Задача 3: Напишите программу, которая выводит массив из 
// 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] FillArray(int size)
{
    int [] myArray = new int[size];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(0,2);
    }
    return myArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine();
}

int InputArraySize(string msg)
{
    System.Console.WriteLine(msg);
    if(int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    System.Console.WriteLine("It's not a number");
    Environment.Exit(1);
    return 0;
}

int sizeArray = InputArraySize("Enter array size:");
int[] userArray = FillArray(sizeArray);
PrintArray(userArray);
