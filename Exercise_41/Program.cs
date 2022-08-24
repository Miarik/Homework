Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите число номер {i+1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int CountPositiveNumbers (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
         count++;  
        }
    }
    return count;
}

Console.WriteLine(CountPositiveNumbers(array));