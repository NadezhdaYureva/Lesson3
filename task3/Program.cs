// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int promt(string message)
{
    Console.WriteLine(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

int x = promt("Введите число:");

for (int i = 1; i <= x; i++)
{
    Console.Write($"{i * i * i} ");
}
