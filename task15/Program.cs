// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру от 1 до 7");
int number = int.Parse(Console.ReadLine());
if(number < 6 && number > 0)
{
    Console.WriteLine("Это будний день");
}
if(number > 8 || number < 1)
{
    Console.WriteLine("В неделе всего 7 дней. Попробуйте еще раз.");
}

if(number == 6 || number == 7)
{
    Console.WriteLine("Этот день является выходным");
}
