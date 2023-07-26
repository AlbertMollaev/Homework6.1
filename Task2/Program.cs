// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void GetLine (double B1, double K1, double B2, double K2)
{
    double x = (B2 - B1) / (K1 - K2);
    double y1 = K1 * x + B1;
    double y2 = K2 * x + B2;
    Console.WriteLine($"Точки , B1 = {B1}, K1 = {K1}, B2 = {B2}, K2 = {K2} , пересечения двух прямых , заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; : --> ({y1}; {y2} )");

}

double GetInput(string text)
{
        Console.Write(text);
        return Convert.ToDouble(Console.ReadLine());
}

double B1 = GetInput("Введите значение B1: ");
double K1 = GetInput("Введите значение K1: ");
double B2 = GetInput("Введите значение B2: ");
double K2 = GetInput("Введите значение K2: ");


GetLine(B1,K1,B2,K2);