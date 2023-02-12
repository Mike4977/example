void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
    
} 

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    //int position = 0; Если числа нет (например find = 18) выдает '0' 
    // некорректное значение
    int position = -1; //возвращает '-1', если элемента нет в массиве
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine(); //вывод пустой строки

int pos = IndexOf(array, 18);
Console.WriteLine(pos);