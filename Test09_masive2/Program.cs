void FillArray(int[] collection)
{
    int lengtn = collection.Length;
    int index = 0;
    while (index < lengtn)
    {
        collection[index] = new Random().Next(0, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] Array = new int[10];

FillArray(Array);
PrintArray(Array);