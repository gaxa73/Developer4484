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

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

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

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

//Домашне задание к третьему семминару
//Базовые алгоритмы. Продолжение

//Задача 19 
//Напишите программу,
//которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

//Console.Write("Введите число >>>>>>");
//string palindrome = (Console.ReadLine()!);

//if (palindrome[0] == palindrome[4] || palindrome[1] == palindrome[3])
//{
//    Console.WriteLine($"Число палиндром >>> {palindrome} ");
//}
//else
//{
//    Console.WriteLine($"Число не палиндром > {palindrome} ");

//}


//Задача 21
//Напишите программу,
//которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B(2, 1, -7), -> 15.84
//A(7, -5, 0); B(1, -1, 9)-> 11.53

//int x1 = Cor("x", "A");
//int y1 = Cor("y", "A");
//int c1 = Cor("c", "A");
//int x2 = Cor("x", "B");
//int y2 = Cor("y", "B");
//int c2 = Cor("c", "B");
//int Cor(string A, string B)
//{
//    Console.WriteLine($"Введите координату {A}, точку {B}; ");
//    return Convert.ToInt16(Console.ReadLine());
//}
//double res = Math.Sqrt
//(Math.Pow(x2 - x1, 2) +
//Math.Pow(y2 - y1, 2) +
//Math.Pow(c2 - c1, 2));
//Console.WriteLine($"Растояние между точками: {res:f3}");




//Задача 23
//Напишите программу,
//которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

//Console.Write("Введите число >>> ");
//int N = int.Parse(Console.ReadLine()!);

//for (int i = 1; i <= N; i++)
//{
//    Console.WriteLine(Math.Pow(i, 3));
//}

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

//Домашнее задание к 4-му семминару.
//Урок 4. Функции
//Задача 25:
//Напишите цикл,
//который принимает на входдва числа (A и B) и
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4-> 16

//int a = int.Parse(Console.ReadLine()!);
//int b = int.Parse(Console.ReadLine()!);
//int result = 1;

//for (int i = 0; i < b; i++)
//{
//    result *= a;

//}
//Console.WriteLine(result);

//Console.WriteLine(Math.Pow(a, b));


//Задача 27:
//Напишите программу,
//которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

//int a = int.Parse(Console.ReadLine()!);
//int res = 0;

//for (int i = a; i != 0; i /= 10)
//{
//    res += i % 10;
//}
//Console.WriteLine(res);


//Задача 29: Напишите программу,
//которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

//int[] num = new int[8];
//for (int i = 0; i < 8; i++)
//{
//    Console.Write("Введите число >>> ");
//    num[i] = int.Parse(Console.ReadLine()!);
//}
//Console.WriteLine();
//Console.WriteLine(String.Join(", ", num));


// Входные данные:
// 2
// 10
// 20
// Выходные данные:
// 30

//Console.Write("Введите количество чисел >>> ");
//int count = int.Parse(Console.ReadLine()!);
//int res = 0;

//for (int i = 0; i < count; i++)
//{
//    Console.Write("Введите число >>> ");
//    res += int.Parse(Console.ReadLine()!);

//}
//Console.WriteLine($"Ответ: {res}");


// Входные данные:
// Введите количество чисел >>> 5
// Введите число >>> 10
// Введите число >>> 70
// Введите число >>> -15
// Введите число >>> 220
// Введите число >>> -49
// Выходные данные:
// Минимальное значение: -49
// Максимальное значение: 220


Console.Write("Введите количество чисел >>> ");
int count = int.Parse(Console.ReadLine()!);
int min = 0;
int max = 0;


for (int i = 0; i < count; i++)
{
    Console.Write("Введите число >>> ");
    int number = int.Parse(Console.ReadLine()!);
    if (number < min)
        min = number;
    if (number > max)
        max = number;
}
Console.WriteLine($"Минимальное значение: {min}");
Console.WriteLine($"Максимальное значение: {max}");




Console.ReadKey();


