// Напишите программу, которая на вход принимает число (N),а на выходе показывает все четные числа от 1 до N.

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int min = 1;

while(N >= min)

{
    if(min % 2 == 0)
    {
        Console.Write($"{min} ");
        min++;
    }
    else min++;    
}



