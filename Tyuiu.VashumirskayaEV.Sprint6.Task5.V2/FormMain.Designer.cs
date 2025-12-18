namespace Tyuiu.VashumirskayaEV.Sprint6.Task5.V2
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelCond_VEV;
        private System.Windows.Forms.Button buttonDo_VEV;
        private System.Windows.Forms.Button buttonOpenFile_VEV;
        private System.Windows.Forms.Button buttonHelp_VEV;
        private System.Windows.Forms.DataGridView dataGridViewResult_VEV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartValues_VEV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            labelCond_VEV = new Label();
            buttonDo_VEV = new Button();
            buttonOpenFile_VEV = new Button();
            buttonHelp_VEV = new Button();
            dataGridViewResult_VEV = new DataGridView();
            chartValues_VEV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_VEV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartValues_VEV).BeginInit();
            SuspendLayout();
            // 
            // labelCond_VEV
            // 
            labelCond_VEV.AutoSize = true;
            labelCond_VEV.Font = new Font("Microsoft Sans Serif", 10F);
            labelCond_VEV.Location = new Point(12, 9);
            labelCond_VEV.Name = "labelCond_VEV";
            labelCond_VEV.Size = new Size(619, 40);
            labelCond_VEV.TabIndex = 0;
            labelCond_VEV.Text = "Прочитать данные из файла InPutFileTask5V2.txt. Вывести в dataGridView.\r\nВывести все положительные числа и построить диаграмму.";
            // 
            // buttonDo_VEV
            // 
            buttonDo_VEV.BackColor = Color.LimeGreen;
            buttonDo_VEV.Location = new Point(610, 398);
            buttonDo_VEV.Name = "buttonDo_VEV";
            buttonDo_VEV.Size = new Size(120, 40);
            buttonDo_VEV.TabIndex = 3;
            buttonDo_VEV.Text = "Выполнить";
            buttonDo_VEV.UseVisualStyleBackColor = false;
            buttonDo_VEV.Click += buttonDo_VEV_Click;
            // 
            // buttonOpenFile_VEV
            // 
            buttonOpenFile_VEV.BackColor = Color.DeepSkyBlue;
            buttonOpenFile_VEV.Location = new Point(471, 398);
            buttonOpenFile_VEV.Name = "buttonOpenFile_VEV";
            buttonOpenFile_VEV.Size = new Size(120, 40);
            buttonOpenFile_VEV.TabIndex = 4;
            buttonOpenFile_VEV.Text = "Открыть файл";
            buttonOpenFile_VEV.UseVisualStyleBackColor = false;
            buttonOpenFile_VEV.Click += buttonOpenFile_VEV_Click;
            // 
            // buttonHelp_VEV
            // 
            buttonHelp_VEV.BackColor = Color.RoyalBlue;
            buttonHelp_VEV.Location = new Point(230, 398);
            buttonHelp_VEV.Name = "buttonHelp_VEV";
            buttonHelp_VEV.Size = new Size(120, 40);
            buttonHelp_VEV.TabIndex = 5;
            buttonHelp_VEV.Text = "Справка";
            buttonHelp_VEV.UseVisualStyleBackColor = false;
            buttonHelp_VEV.Click += buttonHelp_VEV_Click;
            // 
            // dataGridViewResult_VEV
            // 
            dataGridViewResult_VEV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_VEV.Location = new Point(15, 70);
            dataGridViewResult_VEV.Name = "dataGridViewResult_VEV";
            dataGridViewResult_VEV.RowHeadersWidth = 51;
            dataGridViewResult_VEV.Size = new Size(200, 300);
            dataGridViewResult_VEV.TabIndex = 1;
            // 
            // chartValues_VEV
            // 
            chartArea1.AxisX.Title = "№";
            chartArea1.AxisY.Title = "Значение";
            chartArea1.Name = "ChartArea1";
            chartValues_VEV.ChartAreas.Add(chartArea1);
            chartValues_VEV.Location = new Point(230, 70);
            chartValues_VEV.Name = "chartValues_VEV";
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.Green;
            series1.Name = "Series1";
            chartValues_VEV.Series.Add(series1);
            chartValues_VEV.Size = new Size(500, 300);
            chartValues_VEV.TabIndex = 2;
            // 
            // FormMain
            // 
            ClientSize = new Size(760, 450);
            Controls.Add(labelCond_VEV);
            Controls.Add(dataGridViewResult_VEV);
            Controls.Add(chartValues_VEV);
            Controls.Add(buttonDo_VEV);
            Controls.Add(buttonOpenFile_VEV);
            Controls.Add(buttonHelp_VEV);
            Name = "FormMain";
            Text = "Спринт 6 | Task 5 | Вариант 2 | Вашамирская Е.В.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_VEV).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartValues_VEV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
