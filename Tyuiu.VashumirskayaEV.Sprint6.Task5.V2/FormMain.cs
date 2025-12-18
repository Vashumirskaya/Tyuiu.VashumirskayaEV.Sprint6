using Tyuiu.VashumirskayaEV.Sprint6.Task5.V2.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task5.V2
{
    public partial class FormMain : Form
    {
        private DataService ds_VEV = new DataService();
        private string filePath_VEV = @"C:\Users\huawei\source\repos\Tyuiu.VashumirskayaEV.Sprint6\файлы\InPutDataFileTask5V2.txt";

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_VEV_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath_VEV))
            {
                MessageBox.Show("Файл найден! Открываю...", "Информация", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath_VEV,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Файл не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDo_VEV_Click(object sender, EventArgs e)
        {
            try
            {
                double[] values_VEV = ds_VEV.LoadFromDataFile(filePath_VEV);

                dataGridViewResult_VEV.Rows.Clear();
                dataGridViewResult_VEV.Columns.Clear();
                dataGridViewResult_VEV.Columns.Add("col", "Значения");

                foreach (double val_VEV in values_VEV)
                    dataGridViewResult_VEV.Rows.Add(val_VEV);

                chartValues_VEV.Series[0].Points.Clear();
                for (int i = 0; i < values_VEV.Length; i++)
                {
                    chartValues_VEV.Series[0].Points.AddXY(i + 1, values_VEV[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonHelp_VEV_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Задание выполнила студентка группы СМАРТб-25-1 Вашамирская Елизавета Владимировна"
            );
        }
    }
}
