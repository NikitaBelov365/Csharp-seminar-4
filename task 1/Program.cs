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

int number = InputInt("Enter some number pls");
int sum = 0;

for (int i = 0; i <= number; i++)
{
    sum = sum + i;
}

System.Console.WriteLine(sum);