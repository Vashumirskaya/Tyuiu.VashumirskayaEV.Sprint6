using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task3.V23.Lib
{
    public class DataService : ISprint6Task3V23
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = matrix[i, j];

            int[] column = new int[rows];
            for (int i = 0; i < rows; i++)
                column[i] = result[i, 1];

            Array.Sort(column);

            for (int i = 0; i < rows; i++)
                result[i, 1] = column[i];

            return result;
        }
    }
}
