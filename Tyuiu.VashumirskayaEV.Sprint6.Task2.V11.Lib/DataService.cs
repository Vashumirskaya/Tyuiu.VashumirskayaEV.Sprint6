using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task2.V11.Lib
{
    public class DataService : ISprint6Task2V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];

            int k = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == -1) 
                {
                    res[k] = 0;
                }
                else
                {
                    double xd = x;
                    double y = Math.Cos(xd) / (xd + 1) - Math.Cos(xd) * 1.3 + 3 * xd;
                    res[k] = Math.Round(y, 2);
                }

                k++;
            }

            return res;
        }
    }
}
