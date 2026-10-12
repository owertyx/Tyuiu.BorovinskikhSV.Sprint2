using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BorovinskikhSV.Sprint2.Task3.V18.Lib
{
    public class DataService : ISprint2Task3V18
    {
        public double Calculate(double x)
        {
            double res = 0;

            if (x > 1)
            {
                res = Math.Pow(x, 2) * Math.Pow((x + 1) / (x - 1), x);
            }
            else
            {
                if (x == 0)
                {
                    res = (Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10) /
                          (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12);
                }
                else
                {
                    if (x > -22 && x < 2)
                    {
                        res = Math.Pow(1 + 1 / Math.Pow(x, 2), x);
                    }
                    else
                    {
                        if (x < -22)
                        {
                            res = x + 10 * x - (1 / x);
                        }
                        else
                        {
                            res = 0; 
                        }
                    }
                }
            }

            res = Math.Round(res, 3);
            return res;
        }
        
    }
}
