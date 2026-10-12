using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BorovinskikhSV.Sprint2.Task1.V14.Lib
{
    public class DataService : ISprint2Task1V14
    {

        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a + c > d) || (b == a);       // False
            res[1] = (a != b) && (c < d);           // True
            res[2] = (a + b >= c) | (d <= a);       // True
            res[3] = !(a > b) & (c * 2 < d);        // True
            res[4] = (a < b) ^ (c > d);             // True
            res[5] = (b - a == 31) & (c > a);       // False

            return res;
        }
    }
}
