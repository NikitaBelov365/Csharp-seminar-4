// Задача 2: Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.

int InputInt(string prompt)
{
    System.Console.WriteLine($"{prompt}:");
    if(int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    System.Console.WriteLine("It's not a number");
    Environment.Exit(1);
    return 0;
}

int ProductNumbers(int value)
{
    int product = 1;
    for (int i = 1; i <= value; i++)
    {
        product *=i;
    }
    return product;
}

int promptValue = InputInt("Enter number");
System.Console.WriteLine($"Product of numbers from 1 to {promptValue} = {ProductNumbers(promptValue)}");
