using Tyuiu.VashumirskayaEV.Sprint6.Task3.V23.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task3.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_VEV_Click(object sender, EventArgs e)
        {
            int[,] matrix =
            {
                { 0, -19, 25, 34, 0 },
                { -19, -16, 1, -5, 34 },
                { 1, 13, -5, -17, -5 },
                { 3, -9, -15, -1, 0 },
                { 1, 20, 15, -5, 31 }
            };

            int[,] result = ds.Calculate(matrix);

            dataGridViewMatrix_VEV.Rows.Clear();
            dataGridViewMatrix_VEV.Columns.Clear();

            // Создаем 5 столбцов
            for (int c = 0; c < 5; c++)
            {
                dataGridViewMatrix_VEV.Columns.Add($"col{c}", $"Ст {c + 1}");
            }

            // Вывод результата
            for (int i = 0; i < 5; i++)
            {
                dataGridViewMatrix_VEV.Rows.Add(
                    result[i, 0],
                    result[i, 1],
                    result[i, 2],
                    result[i, 3],
                    result[i, 4]
                );
            }
        }

        private void buttonHelp_VEV_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 3 выполнила студентка группы СМАРТб-25-1 Вашумирская Елизавета Владимировна",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
