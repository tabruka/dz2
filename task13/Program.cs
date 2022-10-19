// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int num = 999;

if(number < 100)
{
    Console.WriteLine($"В указанном числе {number} отсутствует третья цифра");
}

int FindThirdDigit(int number)
{   
    while(number > num)
    {
        number = number / 10;
    }
        if(number < 1000 && number > 99)
        {
            number = number % 10;
        }
    return number;
}
if(number>99)
{
Console.WriteLine($"Третья цифра Вашего числа, {FindThirdDigit(number)}");
}