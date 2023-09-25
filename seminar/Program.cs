// int n = new Random().Next(10, 100);
// Console.WriteLine("Рандомное число " + n);

// int n1 = n / 10;
// int n2 = n % 10;

// if (n1 > n2)
//     Console.WriteLine(n1);
// else
//     Console.WriteLine(n2);

// string name = "Viktor";
// int age = 40;
// string city = "Voronezh";

// Console.WriteLine("Меня зовут " + name + " и мне " + age + " лет. И я из " + city);
// Console.WriteLine($"Меня зовут {name} и мне {age} лет. И я из {city}");

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int n = new Random().Next(100, 1000);
// Console.WriteLine("Рандомное число " + n);

// int n1 = n / 100;
// int n2 = n % 100;
// int n3 = n2 % 10;

// Console.Write(n1);
// Console.WriteLine(n3);

// int n = new Random().Next(100, 1000); // [100, 999]
// Console.WriteLine("Рандомное число " + n);
// int n1 = n / 100; 
// int n3 = n % 10; 
// Console.WriteLine(n1 * 10 + n3);

// ------------------------------------------------------------------

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// int a = 5;
// int b = 100;

// if (a == 5 || b ==10)
//     Console.WriteLine("yes");

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n % 7 == 0 && n % 23 == 0)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

// -----------------------------------------------------------------------

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.Write("Введите первое число: ");
// int n1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int n2 = Convert.ToInt32(Console.ReadLine());

// if (n1 % n2 == 0)
//     Console.WriteLine("кратно");
// else
//     Console.WriteLine("не кратно, остаток " + n1 % n2);

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());






