// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1
// y = k2 * x + b2
Console.WriteLine("Поиск точки пересечения двух прямых, заданных формулой: y = k * x + b");

Console.Write("Введите значение К для первой прямой: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение В для первой прямой: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение К для второй прямой: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение В для второй прямой: ");
double b2 = Convert.ToDouble(Console.ReadLine());

string PointIntersectionLine(double k1, double b1, double k2, double b2)
{
    if(k1 == k2)
    {
        return "Решения не существует";
    }
    else{
    double x = Convert.ToDouble((b1 - b2) / (k2 - k1));
    double y = Convert.ToDouble(k1 * x + b1);
    return $"Точка пересечения прямых: {x}; {y}";
    }
}

Console.WriteLine(PointIntersectionLine(k1, b1, k2, b2));