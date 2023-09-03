// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double enterDate(string message=" ")
{
    Console.WriteLine($"{message}: ");
    string Date=Console.ReadLine();
    double setDate=double.Parse(Date);
    return setDate;
}

double[] Peresech(double k1, double b1, double k2, double b2)
{
    double x=(b2-b1)/(k1-k2);
    double y=k1*x+b1;

    double[] peres=new double[2];
    peres[0]=x;
    peres[1]=y;

    return peres;
}

double k1=enterDate("Введите k1: ");
double b1=enterDate("Введите b1: ");
double k2=enterDate("Введите k2: ");
double b2=enterDate("Введите b2: ");

double[] tochka=Peresech(k1,b1,k2,b2);

System.Console.WriteLine(string.Join(" ",tochka));