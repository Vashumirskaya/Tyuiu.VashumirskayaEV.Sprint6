using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task5.V2.Lib
{
    public class DataService : ISprint6Task5V2
    {
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден!", path);

            string[] lines = File.ReadAllLines(path);

            double[] values = Array.ConvertAll(lines, line =>
            {
                double num = double.Parse(line.Replace(",", "."), CultureInfo.InvariantCulture);
                return num;
            });

            values = Array.FindAll(values, v => v < 0);

            for (int i = 0; i < values.Length; i++)
                values[i] = Math.Round(values[i], 3);

            return values;
        }
    }
}       
