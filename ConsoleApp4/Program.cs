//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


bool isInt;
string input = " ";
int N = 0, even = -1, countEven = 0;


Console.WriteLine("Введите колличество чисел, которые будем сравнивать."); 
input = Console.ReadLine();
isInt = int.TryParse(input, out N);



if(isInt == true && N > 0){
    int[] list = new int[N];

    Console.WriteLine("Вводите числа, которые будем сравнивать.");
    for(int i = 0; i < list.Length;){
        input = Console.ReadLine();
        isInt = int.TryParse(input, out int num);
    
        if(isInt == true){
            list[i] = num;
            i++;
        } else { Console.Write("Нужно ввести целое число, введите повторно: "); }

    }

    Console.WriteLine("Вывод чётных чисел (при их наличии):");
    for(int i = 0; i < list.Length; i++){
        even = list[i] % 2;

        if (even == 0) {
            Console.WriteLine(list[i]);
            countEven ++;

        }     

    }



} else {
    Console.WriteLine("Чтобы задать количество чисел для сравнения нужно было ввести целое положительное число.\nНоль тоже не подойдёт.");
}

     



