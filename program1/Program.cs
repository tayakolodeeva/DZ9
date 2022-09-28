// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("Вывести натуральные числа в диапозоне до 1 от :");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Натуральные числа в диапазоне от "+size+" до 1 ->");

NaturalNumbers(size); //Выведет все натуральные числа в промежутке от N до 1.

void NaturalNumbers(int size)
{
    if (size < 0)
    {
        Console.Write($"{size} не является натуральным числом");
        return;
    }
    if (size == 0) 
    {
        return;
    }
    Console.Write("{0,4}", size);
    NaturalNumbers (size - 1);
}
