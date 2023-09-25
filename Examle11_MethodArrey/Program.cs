int[] arrey = {2, 4, 15, 3, 73, 23, 4, 67, 34, 21, 154, 6, 33};
int n = arrey.Length;
int index = 0;

// Ниже - число, индекс которого нужно найти в массиве
int find = 4;

// Ниже правило поиска по массиву

while (index < n) {
    if (find == arrey[index])
    {
        Console.WriteLine(index);
        break;
    }  
    index++;
}