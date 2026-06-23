namespace MissingAngle;

class Program
{
    static void Main(string[] args)
    {
        double h = 0;
        double a = 400;
        double o = 300;

        double res = 0;
        if (h == 0)
        {
            res = Math.Round(Math.Atan(o / a) * 180 / 3.14159265358979323846);
        } 
        else if (a == 0)
        {
            res = Math.Round(Math.Asin(o / h) * 180 / 3.14159265358979323846);
        }
        else if (o == 0)
        {
            res = Math.Round(Math.Acos(a / h) * 180 / 3.14159265358979323846);
        }

        Console.WriteLine(res);
    }
}