using Tyuiu.VashumirskayaEV.Sprint6.Task0.V27.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task0.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonCalc_VEV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int x = Convert.ToInt32(textBoxVarX_VEV.Text);
                textBoxResult_VEV.Text = Convert.ToString(ds.Calculate(x));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_VEV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_VEV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполняла студентка группы СМАРТ6-25-1 Вашумирская Елизавета Владимировна",
                "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
