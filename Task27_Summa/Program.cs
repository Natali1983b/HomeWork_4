// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Read()
{
    System.Console.WriteLine("Введите число: ");
    int Num = int.Parse(Console.ReadLine());
    return Num;
}
int Num = Read();

void Task()
{
    int summa = 0;
    while(Num > 0)
    {
        int remain = Num % 10;
        summa += remain;
        Num = Num / 10;
    }
    Console.WriteLine(summa);
}
Task();
