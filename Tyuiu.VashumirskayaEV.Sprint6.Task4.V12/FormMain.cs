using Tyuiu.VashumirskayaEV.Sprint6.Task4.V12.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task4.V12
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_VEV_Click(object sender, EventArgs e)
        {
            textBoxResult_VEV.Clear();
            chartFunction_VEV.Series[0].Points.Clear();

            int start = -5;
            int stop = 5;

            double[] values = ds.GetMassFunction(start, stop);

            int x = start;

            for (int i = 0; i < values.Length; i++)
            {
                textBoxResult_VEV.AppendText($"x = {x}: {values[i]}" + Environment.NewLine);

                chartFunction_VEV.Series[0].Points.AddXY(x, values[i]);

                x++;
            }
        }

        private void buttonSave_VEV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V12.txt");

                File.WriteAllText(path, textBoxResult_VEV.Text);

                DialogResult result = MessageBox.Show(
                    $"Файл сохранён:\n{path}\nОткрыть файл?",
                    "Сохранение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    var psi = new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = path,
                        UseShellExecute = true
                    };

                    System.Diagnostics.Process.Start(psi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
            }
        }

        private void buttonHelp_VEV_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Выполнила студентка группы СМАРТБ-25-1 Вашумирская Елизавета Владимировна",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
