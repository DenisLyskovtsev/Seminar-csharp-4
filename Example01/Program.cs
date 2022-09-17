int Exponentiation(int numberA, int numberB)
{
    int result = numberA;

    for (int i = 1; i < numberB; i++)
    {
        result = result * numberA;
    }

    return result;
}
Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{numberA} в степени {numberB} = {Exponentiation(numberA, numberB)}");