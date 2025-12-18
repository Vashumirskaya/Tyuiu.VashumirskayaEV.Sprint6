using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task4.V12
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelCond_VEV;
        private System.Windows.Forms.TextBox textBoxResult_VEV;
        private System.Windows.Forms.Button buttonDone_VEV;
        private System.Windows.Forms.Button buttonSave_VEV;
        private System.Windows.Forms.Button buttonHelp_VEV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_VEV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            labelCond_VEV = new Label();
            textBoxResult_VEV = new TextBox();
            buttonDone_VEV = new Button();
            buttonSave_VEV = new Button();
            buttonHelp_VEV = new Button();
            chartFunction_VEV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartFunction_VEV).BeginInit();
            SuspendLayout();
            // 
            // labelCond_VEV
            // 
            labelCond_VEV.AutoSize = true;
            labelCond_VEV.Location = new Point(12, 9);
            labelCond_VEV.Name = "labelCond_VEV";
            labelCond_VEV.Size = new Size(453, 60);
            labelCond_VEV.TabIndex = 5;
            labelCond_VEV.Text = "Табулирование функции F(x) на диапазоне [-5; 5]\r\nF(x) = sin(x) + 2/(3x+0.5) - 2cos(x)*2x\r\nПри делении на ноль вернуть 0. Округлить до 2 знаков после запятой.";
            // 
            // textBoxResult_VEV
            // 
            textBoxResult_VEV.Location = new Point(15, 80);
            textBoxResult_VEV.Multiline = true;
            textBoxResult_VEV.Name = "textBoxResult_VEV";
            textBoxResult_VEV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_VEV.Size = new Size(200, 350);
            textBoxResult_VEV.TabIndex = 4;
            // 
            // buttonDone_VEV
            // 
            buttonDone_VEV.Location = new Point(870, 12);
            buttonDone_VEV.Name = "buttonDone_VEV";
            buttonDone_VEV.Size = new Size(110, 40);
            buttonDone_VEV.TabIndex = 3;
            buttonDone_VEV.Text = "Выполнить";
            buttonDone_VEV.Click += buttonDone_VEV_Click;
            // 
            // buttonSave_VEV
            // 
            buttonSave_VEV.Location = new Point(754, 12);
            buttonSave_VEV.Name = "buttonSave_VEV";
            buttonSave_VEV.Size = new Size(110, 40);
            buttonSave_VEV.TabIndex = 2;
            buttonSave_VEV.Text = "Сохранить";
            buttonSave_VEV.Click += buttonSave_VEV_Click;
            // 
            // buttonHelp_VEV
            // 
            buttonHelp_VEV.Location = new Point(403, 12);
            buttonHelp_VEV.Name = "buttonHelp_VEV";
            buttonHelp_VEV.Size = new Size(110, 40);
            buttonHelp_VEV.TabIndex = 1;
            buttonHelp_VEV.Text = "Справка";
            buttonHelp_VEV.Click += buttonHelp_VEV_Click;
            // 
            // chartFunction_VEV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_VEV.ChartAreas.Add(chartArea1);
            chartFunction_VEV.Location = new Point(240, 80);
            chartFunction_VEV.Name = "chartFunction_VEV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            chartFunction_VEV.Series.Add(series1);
            chartFunction_VEV.Size = new Size(740, 350);
            chartFunction_VEV.TabIndex = 0;
            title1.Name = "Title1";
            title1.Text = "График функции F(x) = sin(x) + 2/(3x+0.5) - 4x*cos(x)";
            chartFunction_VEV.Titles.Add(title1);
            // 
            // FormMain
            // 
            ClientSize = new Size(1000, 460);
            Controls.Add(chartFunction_VEV);
            Controls.Add(buttonHelp_VEV);
            Controls.Add(buttonSave_VEV);
            Controls.Add(buttonDone_VEV);
            Controls.Add(textBoxResult_VEV);
            Controls.Add(labelCond_VEV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 12 | Вашумирская Е.В.";
            ((System.ComponentModel.ISupportInitialize)chartFunction_VEV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
