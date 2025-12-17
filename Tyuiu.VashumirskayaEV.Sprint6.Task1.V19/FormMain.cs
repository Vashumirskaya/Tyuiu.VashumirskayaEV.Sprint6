using Tyuiu.VashumirskayaEV.Sprint6.Task1.V19.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task1.V19
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

                textBoxResult_VEV.Text = "";

                textBoxResult_VEV.AppendText("+-------+----------+" + Environment.NewLine);
                textBoxResult_VEV.AppendText("|   X   |   F(x)   |" + Environment.NewLine);
                textBoxResult_VEV.AppendText("+-------+----------+" + Environment.NewLine);

                int x = start;

                for (int i = 0; i < arr.Length; i++)
                {
                    string line = String.Format("|{0,7:D}|{1,10:F2}|", x, arr[i]);
                    textBoxResult_VEV.AppendText(line + Environment.NewLine);
                    x++;
                }

                textBoxResult_VEV.AppendText("+-------+----------+" + Environment.NewLine);
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
