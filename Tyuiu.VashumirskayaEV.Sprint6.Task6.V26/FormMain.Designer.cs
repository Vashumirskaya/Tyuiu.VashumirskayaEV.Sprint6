namespace Tyuiu.VashumirskayaEV.Sprint6.Task6.V26
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelCondition_VEV = new Label();
            textBoxIn_VEV = new TextBox();
            textBoxOut_VEV = new TextBox();
            buttonOpenFile_VEV = new Button();
            buttonDone_VEV = new Button();
            buttonHelp_VEV = new Button();
            openFileDialogTask_VEV = new OpenFileDialog();
            labelIn_VEV = new Label();
            labelOut_VEV = new Label();
            toolTip1_VEV = new ToolTip(components);
            SuspendLayout();
            // 
            // labelCondition_VEV
            // 
            labelCondition_VEV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCondition_VEV.Font = new Font("Segoe UI", 10F);
            labelCondition_VEV.Location = new Point(12, 60);
            labelCondition_VEV.Name = "labelCondition_VEV";
            labelCondition_VEV.Size = new Size(939, 40);
            labelCondition_VEV.TabIndex = 0;
            labelCondition_VEV.Text = "Дан файл InPutDataFileTask6V26.txt, который находится в любой папке. Загрузить файл в textBoxIn через openFileDialog. Вывести последнее слово каждой строки в результирующую строку и вывести ее в textBoxOut.";
            // 
            // textBoxIn_VEV
            // 
            textBoxIn_VEV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxIn_VEV.Location = new Point(12, 140);
            textBoxIn_VEV.Multiline = true;
            textBoxIn_VEV.Name = "textBoxIn_VEV";
            textBoxIn_VEV.ScrollBars = ScrollBars.Both;
            textBoxIn_VEV.Size = new Size(450, 392);
            textBoxIn_VEV.TabIndex = 1;
            // 
            // textBoxOut_VEV
            // 
            textBoxOut_VEV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxOut_VEV.Location = new Point(489, 140);
            textBoxOut_VEV.Multiline = true;
            textBoxOut_VEV.Name = "textBoxOut_VEV";
            textBoxOut_VEV.ScrollBars = ScrollBars.Both;
            textBoxOut_VEV.Size = new Size(462, 392);
            textBoxOut_VEV.TabIndex = 2;
            // 
            // buttonOpenFile_VEV
            // 
            buttonOpenFile_VEV.Location = new Point(12, 10);
            buttonOpenFile_VEV.Name = "buttonOpenFile_VEV";
            buttonOpenFile_VEV.Size = new Size(50, 45);
            buttonOpenFile_VEV.TabIndex = 3;
            buttonOpenFile_VEV.Text = "📂";
            toolTip1_VEV.SetToolTip(buttonOpenFile_VEV, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile_VEV.UseVisualStyleBackColor = true;
            buttonOpenFile_VEV.Click += buttonOpenFile_VEV_Click;
            // 
            // buttonDone_VEV
            // 
            buttonDone_VEV.Enabled = false;
            buttonDone_VEV.Location = new Point(70, 10);
            buttonDone_VEV.Name = "buttonDone_VEV";
            buttonDone_VEV.Size = new Size(50, 45);
            buttonDone_VEV.TabIndex = 4;
            buttonDone_VEV.Text = "✔";
            toolTip1_VEV.SetToolTip(buttonDone_VEV, "Выполнить задание");
            buttonDone_VEV.UseVisualStyleBackColor = true;
            buttonDone_VEV.Click += buttonDone_VEV_Click;
            // 
            // buttonHelp_VEV
            // 
            buttonHelp_VEV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_VEV.Location = new Point(901, 10);
            buttonHelp_VEV.Name = "buttonHelp_VEV";
            buttonHelp_VEV.Size = new Size(50, 45);
            buttonHelp_VEV.TabIndex = 5;
            buttonHelp_VEV.Text = "?";
            toolTip1_VEV.SetToolTip(buttonHelp_VEV, "О программе");
            buttonHelp_VEV.UseVisualStyleBackColor = true;
            buttonHelp_VEV.Click += buttonHelp_VEV_Click;
            // 
            // openFileDialogTask_VEV
            // 
            openFileDialogTask_VEV.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // labelIn_VEV
            // 
            labelIn_VEV.AutoSize = true;
            labelIn_VEV.Location = new Point(12, 120);
            labelIn_VEV.Name = "labelIn_VEV";
            labelIn_VEV.Size = new Size(46, 20);
            labelIn_VEV.TabIndex = 6;
            labelIn_VEV.Text = "Ввод:";
            // 
            // labelOut_VEV
            // 
            labelOut_VEV.AutoSize = true;
            labelOut_VEV.Location = new Point(510, 120);
            labelOut_VEV.Name = "labelOut_VEV";
            labelOut_VEV.Size = new Size(57, 20);
            labelOut_VEV.TabIndex = 7;
            labelOut_VEV.Text = "Вывод:";
            // 
            // FormMain
            // 
            ClientSize = new Size(963, 553);
            Controls.Add(labelOut_VEV);
            Controls.Add(labelIn_VEV);
            Controls.Add(buttonHelp_VEV);
            Controls.Add(buttonDone_VEV);
            Controls.Add(buttonOpenFile_VEV);
            Controls.Add(textBoxOut_VEV);
            Controls.Add(textBoxIn_VEV);
            Controls.Add(labelCondition_VEV);
            MinimumSize = new Size(850, 500);
            Name = "FormMain";
            Text = "Спринт 6 | Task 6 | Вариант 26 | Вашумирская Е.В.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCondition_VEV;
        private TextBox textBoxIn_VEV;
        private TextBox textBoxOut_VEV;
        private Button buttonOpenFile_VEV;
        private Button buttonDone_VEV;
        private Button buttonHelp_VEV;
        private OpenFileDialog openFileDialogTask_VEV;
        private Label labelIn_VEV;
        private Label labelOut_VEV;
        private ToolTip toolTip1_VEV;
    }
}
