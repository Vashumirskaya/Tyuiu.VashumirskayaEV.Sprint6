using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task4.V12.Lib
{
    public class DataService : ISprint6Task4V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] values = new double[length];

            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;

                // Проверка деления на ноль: 3x + 0.5 == 0
                if (3 * x + 0.5 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Sin(x) + (2.0 / (3 * x + 0.5)) - 2 * Math.Cos(x) * 2 * x;
                }

                values[index] = Math.Round(y, 2);
                index++;
            }

            return values;
        }
    }
}
