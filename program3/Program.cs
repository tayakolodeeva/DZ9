// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите первое положительное число:");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("второе положительное число:");
int numN = Convert.ToInt32(Console.ReadLine());

if (numM > 0 && numN > 0) 
{
    AckermanFunctions(numM,numN);//Вычисления функции Аккермана.
    Console.WriteLine($"Вычисления функции Аккермана двух положительных чисел {numM},{numN} -> "+AckermanFunctions(numM,numN));
} 
else
{
    Console.WriteLine("Необходимо ввести положительные значения.");
}

int AckermanFunctions(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM != 0 && numN == 0) return AckermanFunctions(numM - 1, 1);
    if (numM > 0 && numN > 0) return AckermanFunctions(numM - 1, AckermanFunctions(numM, numN - 1));
    return AckermanFunctions(numM,numN);
}
