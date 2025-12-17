namespace Tyuiu.VashumirskayaEV.Sprint6.Task0.V27
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
            textBoxVarX_VEV = new TextBox();
            labelX_VEV = new Label();
            textBoxResult_VEV = new TextBox();
            labelResult_VEV = new Label();
            buttonCalc_VEV = new Button();
            buttonHelp_VEV = new Button();
            pictureBoxFormula_VEV = new PictureBox();
            groupBoxCondition_VEV = new GroupBox();
            groupBoxInput_VEV = new GroupBox();
            groupBoxOutput_VEV = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_VEV).BeginInit();
            groupBoxCondition_VEV.SuspendLayout();
            groupBoxInput_VEV.SuspendLayout();
            groupBoxOutput_VEV.SuspendLayout();
            SuspendLayout();
            // 
            // labelCond_VEV
            // 
            labelCond_VEV.AutoSize = true;
            labelCond_VEV.Font = new Font("Microsoft Sans Serif", 12F);
            labelCond_VEV.Location = new Point(11, 37);
            labelCond_VEV.Name = "labelCond_VEV";
            labelCond_VEV.Size = new Size(354, 25);
            labelCond_VEV.TabIndex = 7;
            labelCond_VEV.Text = "Вычислить выражение по формуле:";
            // 
            // textBoxVarX_VEV
            // 
            textBoxVarX_VEV.Location = new Point(48, 69);
            textBoxVarX_VEV.Name = "textBoxVarX_VEV";
            textBoxVarX_VEV.Size = new Size(114, 27);
            textBoxVarX_VEV.TabIndex = 4;
            textBoxVarX_VEV.KeyPress += textBoxVarX_VEV_KeyPress;
            // 
            // labelX_VEV
            // 
            labelX_VEV.AutoSize = true;
            labelX_VEV.Location = new Point(48, 33);
            labelX_VEV.Name = "labelX_VEV";
            labelX_VEV.Size = new Size(114, 20);
            labelX_VEV.TabIndex = 5;
            labelX_VEV.Text = "Переменная X:";
            // 
            // textBoxResult_VEV
            // 
            textBoxResult_VEV.Location = new Point(128, 37);
            textBoxResult_VEV.Name = "textBoxResult_VEV";
            textBoxResult_VEV.ReadOnly = true;
            textBoxResult_VEV.Size = new Size(100, 27);
            textBoxResult_VEV.TabIndex = 2;
            // 
            // labelResult_VEV
            // 
            labelResult_VEV.AutoSize = true;
            labelResult_VEV.Location = new Point(21, 44);
            labelResult_VEV.Name = "labelResult_VEV";
            labelResult_VEV.Size = new Size(78, 20);
            labelResult_VEV.TabIndex = 3;
            labelResult_VEV.Text = "Результат:";
            // 
            // buttonCalc_VEV
            // 
            buttonCalc_VEV.Location = new Point(427, 257);
            buttonCalc_VEV.Name = "buttonCalc_VEV";
            buttonCalc_VEV.Size = new Size(100, 30);
            buttonCalc_VEV.TabIndex = 1;
            buttonCalc_VEV.Text = "Вычислить";
            buttonCalc_VEV.Click += buttonCalc_VEV_Click;
            // 
            // buttonHelp_VEV
            // 
            buttonHelp_VEV.Location = new Point(320, 257);
            buttonHelp_VEV.Name = "buttonHelp_VEV";
            buttonHelp_VEV.Size = new Size(80, 30);
            buttonHelp_VEV.TabIndex = 0;
            buttonHelp_VEV.Text = "?";
            buttonHelp_VEV.Click += buttonHelp_VEV_Click;
            // 
            // pictureBoxFormula_VEV
            // 
            pictureBoxFormula_VEV.Image = Properties.Resources.formula;
            pictureBoxFormula_VEV.Location = new


            Point(382, 26);
            pictureBoxFormula_VEV.Name = "pictureBoxFormula_VEV";
            pictureBoxFormula_VEV.Size = new Size(169, 98);
            pictureBoxFormula_VEV.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula_VEV.TabIndex = 6;
            pictureBoxFormula_VEV.TabStop = false;
            // 
            // groupBoxCondition_VEV
            // 
            groupBoxCondition_VEV.Controls.Add(labelCond_VEV);
            groupBoxCondition_VEV.Controls.Add(pictureBoxFormula_VEV);
            groupBoxCondition_VEV.Location = new Point(1, 8);
            groupBoxCondition_VEV.Name = "groupBoxCondition_VEV";
            groupBoxCondition_VEV.Size = new Size(566, 138);
            groupBoxCondition_VEV.TabIndex = 8;
            groupBoxCondition_VEV.TabStop = false;
            groupBoxCondition_VEV.Text = "Условие";
            groupBoxCondition_VEV.Enter += groupBox1_Enter;
            // 
            // groupBoxInput_VEV
            // 
            groupBoxInput_VEV.Controls.Add(labelX_VEV);
            groupBoxInput_VEV.Controls.Add(textBoxVarX_VEV);
            groupBoxInput_VEV.Location = new Point(12, 162);
            groupBoxInput_VEV.Name = "groupBoxInput_VEV";
            groupBoxInput_VEV.Size = new Size(250, 125);
            groupBoxInput_VEV.TabIndex = 9;
            groupBoxInput_VEV.TabStop = false;
            groupBoxInput_VEV.Text = "Ввод данных";
            // 
            // groupBoxOutput_VEV
            // 
            groupBoxOutput_VEV.Controls.Add(labelResult_VEV);
            groupBoxOutput_VEV.Controls.Add(textBoxResult_VEV);
            groupBoxOutput_VEV.Location = new Point(299, 162);
            groupBoxOutput_VEV.Name = "groupBoxOutput_VEV";
            groupBoxOutput_VEV.Size = new Size(250, 89);
            groupBoxOutput_VEV.TabIndex = 6;
            groupBoxOutput_VEV.TabStop = false;
            groupBoxOutput_VEV.Text = "Вывод данных";
            // 
            // FormMain
            // 
            ClientSize = new Size(579, 299);
            Controls.Add(groupBoxOutput_VEV);
            Controls.Add(groupBoxInput_VEV);
            Controls.Add(groupBoxCondition_VEV);
            Controls.Add(buttonHelp_VEV);
            Controls.Add(buttonCalc_VEV);
            Name = "FormMain";
            Text = "Спирт 6 | Таск 0 | Вашумирская Е.В. ";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_VEV).EndInit();
            groupBoxCondition_VEV.ResumeLayout(false);
            groupBoxCondition_VEV.PerformLayout();
            groupBoxInput_VEV.ResumeLayout(false);
            groupBoxInput_VEV.PerformLayout();
            groupBoxOutput_VEV.ResumeLayout(false);
            groupBoxOutput_VEV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelCond_VEV;
        private System.Windows.Forms.Label labelX_VEV;
        private System.Windows.Forms.Label labelResult_VEV;
        private System.Windows.Forms.TextBox textBoxVarX_VEV;
        private System.Windows.Forms.TextBox textBoxResult_VEV;
        private System.Windows.Forms.Button buttonCalc_VEV;
        private System.Windows.Forms.Button buttonHelp_VEV;
        private System.Windows.Forms.PictureBox pictureBoxFormula_VEV;
        private GroupBox groupBoxCondition_VEV;
        private GroupBox groupBoxInput_VEV;
        private GroupBox groupBoxOutput_VEV;
    }
}
