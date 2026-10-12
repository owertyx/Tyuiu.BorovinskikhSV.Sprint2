using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BorovinskikhSV.Sprint2.Task4.V12.Lib
{
    public class DataService : ISprint2Task4V12
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Sqrt(x) > y * 2
                ? Math.Pow(7 + 2 / Math.Pow(y, 2), x)
                : (3 * Math.Pow(x, 2) - Math.Pow(Math.Cos(y), 2) + 10) /
                  (Math.Pow(y, 2) - Math.Sin(Math.Pow(x, 2)) + 12);

            res = Math.Round(res, 3);
            return res;
        }
    }
}
