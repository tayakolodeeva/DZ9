// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("Вывести натуральные числа в диапозоне до 1 от :");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Натуральные числа в диапазоне от "+num+" до 1 ->");

NaturalNumbers(num); //Выведет все натуральные числа в промежутке от N до 1.

void NaturalNumbers(int num)
{
    if (num < 0)
    {
        Console.Write($"{num} не является натуральным числом");
        return;
    }
    if (num == 0) 
    {
        return;
    }
    Console.Write("{0,4}", num);
    NaturalNumbers (num - 1);
}
