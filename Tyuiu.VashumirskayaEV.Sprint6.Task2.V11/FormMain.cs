using Tyuiu.VashumirskayaEV.Sprint6.Task2.V11.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task2.V11
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
            try
            {
                int start = Convert.ToInt32(textBoxStartStep_VEV.Text);
                int stop = Convert.ToInt32(textBoxStopStep_VEV.Text);

                double[] arr = ds.GetMassFunction(start, stop);

                dataGridViewResult_VEV.Rows.Clear();

                int x = start;
                for (int i = 0; i < arr.Length; i++)
                {
                    dataGridViewResult_VEV.Rows.Add(x.ToString(), arr[i].ToString("F2"));
                    x++;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка: неверно введены данные!",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_VEV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы СМАРТб-25-1 Вашумирская Елизавета Владимировна",
                            "Справка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void labelCond_VEV_Click(object sender, EventArgs e)
        {
            
        }
    }
}
