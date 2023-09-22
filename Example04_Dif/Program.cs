double numberA = new Random().Next(1,10); // 1 2 3 ... 9 - здесь минимальное включает, а максимальное нет, то есть [min,max)
double numberB = new Random().Next(10,20);
Console.WriteLine(numberA);
Console.WriteLine(numberB);
Console.WriteLine(numberA / numberB);
