// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// x = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1*x+b1=k2*x+b2
// k1*x-(k2*x)=b2-b1
// x(k1-k2)=b2-b1
// x=(b2-b1)/(k1-k2)

double Calculating(double bx1, double kx1, double bx2, double kx2)
{
    double x = 0;
    x = (bx2 - bx1) / (kx1 - kx2);
    return x;
}
double TheEquationK1B1(double x, double bx1, double kx1)
{
    double y = 0;
    y = kx1 * x + bx1;
    return y;
}


Console.WriteLine("The equations are given |y = k1 * x + b1|  and  |y = k2 * x + b2|");
Console.Write("Enter k1 -> ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b1 -> ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2 -> ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2 -> ");
double b2 = Convert.ToDouble(Console.ReadLine());
if (b1 != b2)
{
    double x = Math.Round(Calculating(k1, b1, k2, b2), 1, MidpointRounding.ToZero);
    double y = Math.Round(TheEquationK1B1(x, k1, b1), 1, MidpointRounding.ToZero);
    Console.WriteLine($"Intersection point -> ({x};{y})");
}
else Console.WriteLine("Straight lines are parallel");