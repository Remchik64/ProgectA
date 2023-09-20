using System;
int[] Array = { 12, 2, 3, 4, 3, 52, 6, 71, 3 };

int n = Array.Length;
int find = 3;

int index = 0;

while (index < n)
{
    if (Array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;

}
