// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Numbers();

void Numbers()
{
    int A = ReadInt("first number");
    int B = ReadInt("second number");
    int result = 1;
if(B > 0)
{
for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Error, enter a natural number");
}
}


int ReadInt(string argument)
{
    int number;
    Console.Write($"Input (argument): ");
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It's not a number!");
        Console.Write("Try again: ");
    }
    return number;
}

System.Console.WriteLine(" ");