using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task7.V25.Lib
{
    public class DataService : ISprint6Task7V25
    {
        public int rows = 0;
        public int column = 0;
        public int[,] GetMatrix(string path)
        {

            string line;
            int index = 0;
            using (StreamReader sr = new StreamReader(path))
            {

                while ((line = sr.ReadLine()) != null)
                {
                    string[] mass = line.Split(";");
                    column = mass.Length;
                    rows++;
                }

            }
            int[,] matrix = new int[rows, column];
            using (StreamReader sr = new StreamReader(path))
            {
                string[] z = new string[column];

                while ((line = sr.ReadLine()) != null)
                {
                    z = line.Split(";");
                    for (int i = 0; i < z.Length; i++)
                    {
                        matrix[index, i] = Convert.ToInt32(z[i]);
                    }
                    index++;
                    z = [];
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        if (j == 6)
                        {
                            if ((matrix[i, j] % 5) == 0)
                            {
                                matrix[i, j] = 2;
                            }
                        }


                    }
                }

            }

            return matrix;
        }
    }
}
