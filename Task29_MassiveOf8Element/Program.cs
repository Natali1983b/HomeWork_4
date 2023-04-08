// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int [] CreateArray(int Length, int min, int max)
{
int [] numbers = new int [Length];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(min,max +1);
}
return numbers;
}



void PrintArray(int [] numbers)
{
Console.Write("[");
for (int i = 0; i < numbers.Length -1; i++)
{
    Console.Write(numbers[i] + "; ");
}
Console.WriteLine(numbers[numbers.Length -1] + "]");
}

int Num (string arg)
{
    Console.WriteLine($"Введите {arg} ");
    return int.Parse(System.Console.ReadLine());
}

int Length = Num("длину массива");
int min = Num("меньшее число");
int max = Num("максимальное число");
int [] numbers = CreateArray(Length, min, max);
PrintArray(numbers);