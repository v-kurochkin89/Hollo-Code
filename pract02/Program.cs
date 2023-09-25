int a = 5;
int b = 10;
int c = 7;
int max = a;

if (max < b)
    max = b;

if (max < c)
    max = c;

// Console.Write("Максимальное число из представленных: ");
Console.WriteLine(max);