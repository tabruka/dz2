// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());

int FindSecondDigit(int number)
{
    int num3 = number / 10;
    int num2 = num3 % 10;
    return num2;
}
Console.WriteLine($"Вторая цифра числа {number} = {FindSecondDigit(number)}");