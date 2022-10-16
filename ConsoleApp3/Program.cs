//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int input;
string yes = "Число чётное.", no = "Число нечётное";


Console.Write("Введите число: ");
input = Convert.ToInt32(Console.ReadLine());
Console.Write("");


if(
input % 2 == 0) Console.WriteLine(yes); 
else Console.WriteLine(no);
