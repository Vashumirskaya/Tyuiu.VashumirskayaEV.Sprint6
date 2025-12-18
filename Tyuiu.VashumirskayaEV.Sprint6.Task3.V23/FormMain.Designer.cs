using System.Windows.Forms;
using System.Drawing;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task3.V23
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        // Объявление переменных
        private Label labelCond_VEV;
        private DataGridView dataGridViewMatrix_VEV;
        private Button buttonHelp_VEV;
        private Button buttonDone_VEV;

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
            dataGridViewMatrix_VEV = new DataGridView();
            buttonHelp_VEV = new Button();
            buttonDone_VEV = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_VEV).BeginInit();
            SuspendLayout();

            // 
            // labelCond_VEV
            // 
            labelCond_VEV.AutoSize = true;
            labelCond_VEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F); // Исправлено здесь
            labelCond_VEV.Location = new Point(12, 9);
            labelCond_VEV.Name = "labelCond_VEV";
            labelCond_VEV.Size = new Size(461, 180);
            labelCond_VEV.TabIndex = 4;
            labelCond_VEV.Text = "Условие\nДана матрица 5 на 5:\n  0  -19   25   34    0\n-19  -16    1   -5   34\n  1   13   -5  -17   -5\n  3   -9  -15   -1    0\n  1   20   15   -5   31\n\nВыполнить сортировку по возрастанию 2-го столбца.";

            // 
            // dataGridViewMatrix_VEV
            // 
            dataGridViewMatrix_VEV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_VEV.Location = new Point(492, 12);
            dataGridViewMatrix_VEV.Name = "dataGridViewMatrix_VEV";
            dataGridViewMatrix_VEV.RowHeadersVisible = false;
            dataGridViewMatrix_VEV.RowHeadersWidth = 51;
            dataGridViewMatrix_VEV.Size = new Size(300, 250);
            dataGridViewMatrix_VEV.TabIndex = 1;

            // 
            // buttonHelp_VEV
            // 
            buttonHelp_VEV.BackColor = Color.SkyBlue;
            buttonHelp_VEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F); // Исправлено здесь
            buttonHelp_VEV.Location = new Point(157, 220);
            buttonHelp_VEV.Name = "buttonHelp_VEV";
            buttonHelp_VEV.Size = new Size(133, 42);
            buttonHelp_VEV.TabIndex = 1;
            buttonHelp_VEV.Text = "Справка";
            buttonHelp_VEV.UseVisualStyleBackColor = false;
            buttonHelp_VEV.Click += buttonHelp_VEV_Click;

            // 
            // buttonDone_VEV
            // 
            buttonDone_VEV.BackColor = Color.LightGreen;
            buttonDone_VEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F); // Исправлено здесь
            buttonDone_VEV.Location = new Point(296, 208);
            buttonDone_VEV.Name = "buttonDone_VEV";
            buttonDone_VEV.Size = new Size(177, 54);
            buttonDone_VEV.TabIndex = 0;
            buttonDone_VEV.Text = "Выполнить";
            buttonDone_VEV.UseVisualStyleBackColor = false;
            buttonDone_VEV.Click += buttonDone_VEV_Click;

            // 
            // FormMain
            // 
            ClientSize = new Size(810, 283);
            Controls.Add(buttonDone_VEV);
            Controls.Add(buttonHelp_VEV);
            Controls.Add(dataGridViewMatrix_VEV);
            Controls.Add(labelCond_VEV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 23 | Вашумирская Е.В.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_VEV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}