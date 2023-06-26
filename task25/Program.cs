// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int findStepen_B_otA(int num1, int num2)
{
    
    int res = 1;
    for(int i = 0;i<num2;i++)
    {
        res*=num1;
    }
    return res;
    
}



int number1 = Prompt("введите число A(основание) :");
int number2 = Prompt("Введите число B(показатель) :");
if (number2>-1)
   {
int result = findStepen_B_otA(number1,number2);
Console.WriteLine("Число A в степени B  = " + result);
   }
   else
{
    Console.WriteLine("Показатель степени отрицательный!!!");
}

