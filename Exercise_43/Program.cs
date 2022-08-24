Console.WriteLine("Введите значения переменных для прямой по формуле ax+by+c=0");
Console.Write("Введите значение a для первой прямой: ");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b для первой прямой: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение a для второй прямой: ");
int a2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение a для второй прямой: ");
int b2 = Convert.ToInt32(Console.ReadLine());


void LineCrossing(int a1, int b1, int a2, int b2)
{
    double x = (a2/b2-a1/b1);
    Console.WriteLine(x);
    double y = (a1*x)/b1;
    Console.WriteLine(y);
    Console.WriteLine($"{x}; {y}");
    }

// void PrintArray(double[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}; ");
//     }
// }

// Console.Write("Координаты пересечения прямых ");
// PrintArray(LineCrossing(a1,b1,a2,b2));
