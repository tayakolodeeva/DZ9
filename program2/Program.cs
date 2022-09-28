// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Вывести натуральные числа в диапозоне от :");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("до :");
int numN = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма натуральных элементов в промежутке от {numM} до {numN}");

SumOfNaturalNumbers(numM,numN,0); //Выводит сумму натуральных элементов в промежутке от M до N.

void SumOfNaturalNumbers(int numM, int numN, int sum)
{
    if (numM > numN) 
    {
        Console.Write($" -> {sum}."); 
        return;
    }
    sum = sum + numM;
    numM++;
    SumOfNaturalNumbers(numM, numN, sum);
}