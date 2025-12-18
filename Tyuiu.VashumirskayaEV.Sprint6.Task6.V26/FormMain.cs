using Tyuiu.VashumirskayaEV.Sprint6.Task6.V26.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task6.V26
{
    public partial class FormMain : Form
    {
        private string openFilePath_VEV = "";
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_VEV_Click(object sender, EventArgs e)
        {
            if (openFileDialogTask_VEV.ShowDialog() == DialogResult.OK)
            {
                openFilePath_VEV = openFileDialogTask_VEV.FileName;
                textBoxIn_VEV.Text = File.ReadAllText(openFilePath_VEV);
                buttonDone_VEV.Enabled = true;
            }
        }

        private void buttonDone_VEV_Click(object sender, EventArgs e)
        {
            if (openFilePath_VEV == "")
            {
                MessageBox.Show("Файл не выбран!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string result = ds.CollectTextFromFile(openFilePath_VEV);
            textBoxOut_VEV.Text = result;
        }

        private void buttonHelp_VEV_Click(object sender, EventArgs e)
        {
            FormAbout_VEV about = new FormAbout_VEV();
            about.ShowDialog();
        }
    }
}
