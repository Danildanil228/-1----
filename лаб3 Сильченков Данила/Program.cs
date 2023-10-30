Console.Write("Введите значение x: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите количество членов ряда n: ");
double n = double.Parse(Console.ReadLine());
double sum = 1;
double fac = 1;
double p = 1;
for (int i = 1; i <= n; i++)
{
    p = x * x;
    fac = (2 * i) * (2 * i - 1);
    double t = p / fac;
    sum += t;
}
Console.WriteLine($"Сумма {n} членов ряда = {sum}") ;
