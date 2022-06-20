// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите число: ");
string numberPal = Console.ReadLine();
int Lenght = numberPal.Length;

bool q = true;

for (int i = 0; i <= Lenght / 2; i++)
{
    if (numberPal[i] != numberPal[Lenght - 1 - i])
    {
        Console.WriteLine($"Число {numberPal} не палиндром");
        q = false;
        break;
    }
}

if (q == true) 
{
    Console.WriteLine($"Число {numberPal} палиндром");
}
