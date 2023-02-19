// Упорядочить элементы массива  


// int[] array = {1, 1, 8, 4, 7, 3, 5, 2, 4, 1}; 
Console.WriteLine("Введите количество элементов массива");
int lengthArray = Int32.Parse(Console.ReadLine());
int[] array = new int [lengthArray];

Console.WriteLine("Введите элементы массива");
for (int x = 0; x < array.Length; x++)
{
    array[x] = Int32.Parse(Console.ReadLine());
    //Console.WriteLine(array[x]);
}


void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

// // От минимального к максимальному
// void SelectSort(int[] arr)
// {
//     for (int j = 0; j < arr.Length - 1; j++)
//     {
//         int minPos = j;
//         for (int i = j + 1; i < arr.Length; i++)
//         {
//             if (arr[i] <= arr[minPos]) minPos = i;
//         }
//         int temporary = arr[j];
//         arr[j] = arr[minPos];
//         arr[minPos] = temporary;
//     }
// }

// От максимального к минимальному
void SelectSort(int[] arr)
{
    for (int j = 0; j < arr.Length - 1; j++)
    {
        int maxPos = j;
        for (int i = j + 1; i < arr.Length; i++)
        {
            if (arr[i] >= arr[maxPos]) maxPos = i;
        }
        int temporary = arr[j];
        arr[j] = arr[maxPos];
        arr[maxPos] = temporary;
    }
}

PrintArr(array);
SelectSort(array);

PrintArr(array);