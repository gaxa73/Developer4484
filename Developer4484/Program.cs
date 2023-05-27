//Задача 2:
//Напишите программу, которая на вход принимает два числа
//и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7->max = 7
//a = 2 b = 10->max = 10
//a = -9 b = -3->max = -3

//Console.Write("Введите первое число: ");
//int a = int.Parse(Console.ReadLine()!);

//Console.Write("Введите второе число: ");
//int b = int.Parse(Console.ReadLine()!);

//if (a > b)
//{
//    Console.WriteLine($"{a} больше, чем {b}");
//    Console.WriteLine($"{b} меньше, чем {a}");
//}
//else if (b > a)
//{
//    Console.WriteLine($"{b} больше, чем {a}");
//    Console.WriteLine($"{a} меньше, чем {b}");
//}
//else
//{
//    Console.WriteLine($"Числа равны");
//}



//Задача 4:
//Напишите программу,
//которая принимает на вход три числа
//и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


//Console.Write("Введите первое число: ");
//int a = int.Parse(Console.ReadLine()!);

//Console.Write("Введите второе число: ");
//int b = int.Parse(Console.ReadLine()!);

//Console.Write("Введите второе число: ");
//int c = int.Parse(Console.ReadLine()!);
//int max = a;

//if (a > max) max = a;
//if (b > max) max = b;
//if (c > max) max = c;
//Console.Write("max = ");
//Console.WriteLine(max);


//Задача 6:
//Напишите программу,
//которая на вход принимает число и выдаёт,
//является ли число чётным
//делится ли оно на два без остатка.
//4->да
//- 3->нет
//7->нет

//Console.Write("Введите первое число: ");
//int num = int.Parse(Console.ReadLine()!);

//while (num > 0)
//{
//    if (num % 2 == 0)
//    {
//        Console.WriteLine("Да");
//    }
//    else
//    {
//        Console.WriteLine("Нет");
//    }
//    break;
//}



//Задача 8:
//Напишите программу,
//которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

//Console.Write("Введите первое число: ");
//int n = int.Parse(Console.ReadLine()!);
//int i = 2;

//while (i <= n)
//{
//    Console.WriteLine(i);
//    i += 2;
//}

//Домашнее задание:
//к второму семминару.

//Урок 2. Базовые алгоритмы

//Задача 10:
//Напишите программу,
//которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

//Console.WriteLine("Введите трехзначное число:>>> ");
//int number = int.Parse(Console.ReadLine()!);
//string num = Convert.ToString(number);
//Console.WriteLine($"вторая цифра числа >>> {num[1]} ");


//Задача 13:
//Напишите программу,
//которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//Console.Write("Введи число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//string num1 = Convert.ToString(num);
//if (num1.Length > 2)
//{
//    Console.WriteLine($"третья цифра >>> {num1[2]} ");
//}
//else
//{
//    Console.WriteLine(">>> третьей цифры нет");
//}

//Задача 15:
//Напишите программу,
//которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1->нет

//Console.WriteLine("Введите день недели от 1, до 7, ");
//int dNum = Convert.ToInt32(Console.ReadLine());

//if (dNum == 6 || dNum == 7)
//{
//    Console.Write("Этот день выходной Ура -> Да");
//}
//else if (dNum < 1 || dNum > 7)
//{
//    Console.Write("Введите число от 1 до 7, ");
//}
//else Console.Write("Этот день не выходной -> Нет");

