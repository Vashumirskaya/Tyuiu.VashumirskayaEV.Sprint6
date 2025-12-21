using Tyuiu.VashumirskayaEV.Sprint6.Task7.V25.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task7.V25
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        static string openFilePath;
        static int colums;
        static int rows;

        public FormMain()
        {
            InitializeComponent();
            openFileDialog_VEV.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialog_VEV.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";
            Shown += FormMain_Shown;
        }

        private void FormMain_Shown(object? sender, EventArgs e)
        {
            textBoxCond_VEV.Text =
                "Дан файл InPutFileTask7V25.csv в котором хранится матрица целочисленных значений.\r\n" +
                "Загрузить файл через openFileDialog в объект dataGridViewIn.\r\n" +
                "Изменить в седьмом столбце элементы кратные 5 на 2.\r\n" +
                "Результат вывести в объект dataGridViewOut.\r\n" +
                "Сохранить результат в файл OutPutFileTask7.csv через saveFileDialog.";
        }
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            colums = lines[0].Split(";").Length;
            int[,] arrayValues = new int[rows, colums];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(";");
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[i, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpen_VEV_Click(object sender, EventArgs e)
        {
            openFileDialog_VEV.ShowDialog();
            openFilePath = openFileDialog_VEV.FileName;
            int[,] arrayValues = new int[rows, colums];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_VEV.ColumnCount = colums;
            dataGridViewIn_VEV.RowCount = rows;
            dataGridViewOut_VEV.ColumnCount = colums;
            dataGridViewOut_VEV.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewIn_VEV.Columns[i].Width = 35;
                dataGridViewOut_VEV.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewIn_VEV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDown_VEV.Enabled = true;
        }

        private void buttonDown_VEV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = ds.GetMatrix(openFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewOut_VEV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSave_VEV.Enabled = true;
        }

        private void buttonSave_VEV_Click(object sender, EventArgs e)
        {
            saveFileDialog_VEV.FileName = saveFileDialog_VEV.FileName;
            saveFileDialog_VEV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_VEV.ShowDialog();

            string path = saveFileDialog_VEV.FileName;

            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_VEV.RowCount;
            int column = dataGridViewOut_VEV.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column - 1; j++)
                {
                    if (j != column - 1)
                    {
                        str = str + dataGridViewOut_VEV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_VEV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonQuestion_VEV_Click(object sender, EventArgs e)
        {
            FormAbout_VEV formAbout = new FormAbout_VEV();
            formAbout.ShowDialog();
        }
    }
}
