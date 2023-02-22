int InputInt(string prompt)
{
    System.Console.WriteLine($"{prompt}:");
    if(int.TryParse(Console.ReadLine(), out int value));
    {
        return value;
    }
    System.Console.WriteLine("It's not a number.");
    Environment.Exit(1);
    return 0;
}

int NumberLength(int value)
{
    int length = 0;
    while (value > 0)
    {
        value /= 10;
        length++;
    }
    return length;
}

int number = InputInt("Enter number");
System.Console.WriteLine($"Length of number = {NumberLength(number)}");