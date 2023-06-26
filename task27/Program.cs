// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(String message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int sumCifr(int num)
{
    int sum = 0;
    while(num>0)
    {
        sum+=num%10;
        num/=10;
    }
    return sum;
}


int number = Prompt("Введите число : ");
int result = sumCifr(number);
Console.WriteLine($"Сумма цифр числа {number} = {result}");