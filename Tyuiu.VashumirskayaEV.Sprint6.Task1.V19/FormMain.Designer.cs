namespace Tyuiu.VashumirskayaEV.Sprint6.Task1.V19
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelCond_VEV = new Label();
            labelInput_VEV = new Label();
            labelOutput_VEV = new Label();
            labelStartStep_VEV = new Label();
            labelStopStep_VEV = new Label();
            textBoxStartStep_VEV = new TextBox();
            textBoxStopStep_VEV = new TextBox();
            textBoxResult_VEV = new TextBox();
            buttonHelp_VEV = new Button();
            buttonDone_VEV = new Button();
            groupBoxCond_VEV = new GroupBox();
            groupBoxCond_VEV.SuspendLayout();
            SuspendLayout();
            // 
            // labelCond_VEV
            // 
            labelCond_VEV.AutoSize = true;
            labelCond_VEV.Font = new Font("Microsoft Sans Serif", 12F);
            labelCond_VEV.Location = new Point(4, 41);
            labelCond_VEV.Name = "labelCond_VEV";
            labelCond_VEV.Size = new Size(542, 50);
            labelCond_VEV.TabIndex = 0;
            labelCond_VEV.Text = "Протабулировать функцию F(x) на заданном диапазоне.\nРезультат вывести в виде таблицы.";
            labelCond_VEV.Click += labelCond_VEV_Click;
            // 
            // labelInput_VEV
            // 
            labelInput_VEV.AutoSize = true;
            labelInput_VEV.Font = new Font("Microsoft Sans Serif", 10F);
            labelInput_VEV.Location = new Point(24, 224);
            labelInput_VEV.Name = "labelInput_VEV";
            labelInput_VEV.Size = new Size(125, 20);
            labelInput_VEV.TabIndex = 1;
            labelInput_VEV.Text = "Ввод данных:";
            // 
            // labelOutput_VEV
            // 
            labelOutput_VEV.AutoSize = true;
            labelOutput_VEV.Font = new Font("Microsoft Sans Serif", 10F);
            labelOutput_VEV.Location = new Point(642, 12);
            labelOutput_VEV.Name = "labelOutput_VEV";
            labelOutput_VEV.Size = new Size(137, 20);
            labelOutput_VEV.TabIndex = 2;
            labelOutput_VEV.Text = "Вывод данных:";
            // 
            // labelStartStep_VEV
            // 
            labelStartStep_VEV.AutoSize = true;
            labelStartStep_VEV.Location = new Point(20, 269);
            labelStartStep_VEV.Name = "labelStartStep_VEV";
            labelStartStep_VEV.Size = new Size(88, 20);
            labelStartStep_VEV.TabIndex = 3;
            labelStartStep_VEV.Text = "Старт шага:";
            // 
            // labelStopStep_VEV
            // 
            labelStopStep_VEV.AutoSize = true;
            labelStopStep_VEV.Location = new Point(20, 304);
            labelStopStep_VEV.Name = "labelStopStep_VEV";
            labelStopStep_VEV.Size = new Size(94, 20);
            labelStopStep_VEV.TabIndex = 4;
            labelStopStep_VEV.Text = "Конец шага:";
            // 
            // textBoxStartStep_VEV
            // 
            textBoxStartStep_VEV.Location = new Point(120, 262);
            textBoxStartStep_VEV.Name = "textBoxStartStep_VEV";
            textBoxStartStep_VEV.Size = new Size(99, 27);
            textBoxStartStep_VEV.TabIndex = 5;
            // 
            // textBoxStopStep_VEV
            // 
            textBoxStopStep_VEV.Location = new Point(120, 304);
            textBoxStopStep_VEV.Name = "textBoxStopStep_VEV";
            textBoxStopStep_VEV.Size = new Size(99, 27);
            textBoxStopStep_VEV.TabIndex = 6;
            // 
            // textBoxResult_VEV
            // 
            textBoxResult_VEV.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_VEV.Location = new Point(593, 54);
            textBoxResult_VEV.Multiline = true;
            textBoxResult_VEV.Name = "textBoxResult_VEV";
            textBoxResult_VEV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_VEV.Size = new Size(250, 277);
            textBoxResult_VEV.TabIndex = 7;
            // 
            // buttonHelp_VEV
            // 
            buttonHelp_VEV.BackColor = Color.SkyBlue;
            buttonHelp_VEV.Location = new Point(284, 240);
            buttonHelp_VEV.Name = "buttonHelp_VEV";
            buttonHelp_VEV.Size = new Size(123, 70);
            buttonHelp_VEV.TabIndex = 8;
            buttonHelp_VEV.Text = "Справка";
            buttonHelp_VEV.UseVisualStyleBackColor = false;
            buttonHelp_VEV.Click += buttonHelp_VEV_Click;
            // 
            // buttonDone_VEV
            // 
            buttonDone_VEV.BackColor = Color.LightGreen;
            buttonDone_VEV.Location = new Point(413, 232);
            buttonDone_VEV.Name = "buttonDone_VEV";
            buttonDone_VEV.Size = new Size(159, 81);
            buttonDone_VEV.TabIndex = 9;
            buttonDone_VEV.Text = "Выполнить";
            buttonDone_VEV.UseVisualStyleBackColor = false;
            buttonDone_VEV.Click += buttonDone_VEV_Click;
            // 
            // groupBoxCond_VEV
            // 
            groupBoxCond_VEV.Controls.Add(labelCond_VEV);
            groupBoxCond_VEV.Location = new Point(20, 12);
            groupBoxCond_VEV.Name = "groupBoxCond_VEV";
            groupBoxCond_VEV.Size = new Size(552, 195);
            groupBoxCond_VEV.TabIndex = 10;
            groupBoxCond_VEV.TabStop = false;
            groupBoxCond_VEV.Text = "Условие";
            // 
            // FormMain
            // 
            ClientSize = new Size(856, 344);
            Controls.Add(groupBoxCond_VEV);
            Controls.Add(labelOutput_VEV);
            Controls.Add(labelInput_VEV);
            Controls.Add(labelStartStep_VEV);
            Controls.Add(labelStopStep_VEV);
            Controls.Add(textBoxStartStep_VEV);
            Controls.Add(textBoxStopStep_VEV);
            Controls.Add(textBoxResult_VEV);
            Controls.Add(buttonHelp_VEV);
            Controls.Add(buttonDone_VEV);
            Name = "FormMain";
            Text = "Спринт 6 | Task 1 | Вариант 19 | Вашумирская Е.В.";
            groupBoxCond_VEV.ResumeLayout(false);
            groupBoxCond_VEV.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion.

        private System.Windows.Forms.Label labelCond_VEV;
        private System.Windows.Forms.Label labelInput_VEV;
        private System.Windows.Forms.Label labelOutput_VEV;
        private System.Windows.Forms.Label labelStartStep_VEV;
        private System.Windows.Forms.Label labelStopStep_VEV;
        private System.Windows.Forms.TextBox textBoxStartStep_VEV;
        private System.Windows.Forms.TextBox textBoxStopStep_VEV;
        private System.Windows.Forms.TextBox textBoxResult_VEV;
        private System.Windows.Forms.Button buttonHelp_VEV;
        private System.Windows.Forms.Button buttonDone_VEV;
        private GroupBox groupBoxCond_VEV;
    }
}
