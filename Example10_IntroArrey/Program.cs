int Max (int arg1, int arg2, int arg3)
    {
        int result = arg1;
        if (arg2 > result) result = arg2;
        if (arg3 > result) result = arg3;
        return result;
    }

// индекс элементов массива:
//              0   1   2   3   4   5   6   7   8
int[] arrey = {13, 22, 37, 24, 55, 96, 37, 80, 29};

int max = Max
            (Max (arrey[0], arrey[1], arrey[2]),
            Max (arrey[3], arrey[4], arrey[5]),
            Max (arrey[6], arrey[7], arrey[8]));

Console.Write("Максимальное число из массива: ");
Console.WriteLine(max);