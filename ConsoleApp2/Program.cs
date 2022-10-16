// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int num1 = 40, num2 = 40, num3 = 40;
int max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3; 

Console.WriteLine("Максимальное число из трёх равно: " + max);
