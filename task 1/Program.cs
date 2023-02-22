// Задача 1: Напишите программу, которая принимает на вход 
// число (А) и выдаёт сумму чисел от 1 до А.

int InputInt(string msg)
{
    System.Console.WriteLine($"{msg}:");
    int num;
    if (int.TryParse(Console.ReadLine(), out num))
    {
        return num;
    }
    System.Console.WriteLine("It's not a number.");
    Environment.Exit(1);
    return 0;
}


bool ValidatePositive(int num)
{
    if(num <= 0)
    {
        System.Console.WriteLine("Enter positive value pls");
        return false;
    }
    return true;
}

int SumNumbers(int num)
{
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

int SumGaussWay(int value) //Gauss way
{
    return (1+value)*value/2;
}

int number = InputInt("Enter some number pls");
if(ValidatePositive(number))
{
    int sum = SumNumbers(number);
    System.Console.WriteLine($"Sum of numbers from 1 to {number} is equal: {sum}");
    System.Console.WriteLine($"Sum of numbers by Gauss method from 1 to {number} is equal: {SumGaussWay(number)}");
}