namespace Tyuiu.VashumirskayaEV.Sprint6.Task7.V25
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons_VEV = new Panel();
            buttonQuestion_VEV = new Button();
            buttonSave_VEV = new Button();
            buttonDown_VEV = new Button();
            buttonOpen_VEV = new Button();
            panelCond_VEV = new Panel();
            groupBoxCond_VEV = new GroupBox();
            textBoxCond_VEV = new TextBox();
            panelIn_VEV = new Panel();
            groupBoxIn_VEV = new GroupBox();
            dataGridViewIn_VEV = new DataGridView();
            splitter_VEV = new Splitter();
            panelOut_VEV = new Panel();
            groupBoxOut_VEV = new GroupBox();
            dataGridViewOut_VEV = new DataGridView();
            openFileDialog_VEV = new OpenFileDialog();
            toolTip_VEV = new ToolTip(components);
            saveFileDialog_VEV = new SaveFileDialog();
            toolTipDown_VEV = new ToolTip(components);
            toolTipSave_VEV = new ToolTip(components);
            toolTipQuestion_VEV = new ToolTip(components);
            panelButtons_VEV.SuspendLayout();
            panelCond_VEV.SuspendLayout();
            groupBoxCond_VEV.SuspendLayout();
            panelIn_VEV.SuspendLayout();
            groupBoxIn_VEV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_VEV).BeginInit();
            panelOut_VEV.SuspendLayout();
            groupBoxOut_VEV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_VEV).BeginInit();
            SuspendLayout();



            panelButtons_VEV.Controls.Add(buttonQuestion_VEV);
            panelButtons_VEV.Controls.Add(buttonSave_VEV);
            panelButtons_VEV.Controls.Add(buttonDown_VEV);
            panelButtons_VEV.Controls.Add(buttonOpen_VEV);
            panelButtons_VEV.Dock = DockStyle.Top;
            panelButtons_VEV.Location = new Point(0, 0);
            panelButtons_VEV.Name = "panelButtons_VEV";
            panelButtons_VEV.Size = new Size(800, 64);
            panelButtons_VEV.TabIndex = 0;



            buttonQuestion_VEV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonQuestion_VEV.Image = Properties.Resources.vopros;
            buttonQuestion_VEV.Location = new Point(741, 12);
            buttonQuestion_VEV.Name = "buttonQuestion_VEV";
            buttonQuestion_VEV.Size = new Size(47, 46);
            buttonQuestion_VEV.TabIndex = 3;
            toolTipQuestion_VEV.SetToolTip(buttonQuestion_VEV, "Сведения о программе\r\n");
            buttonQuestion_VEV.UseVisualStyleBackColor = true;
            buttonQuestion_VEV.Click += buttonQuestion_VEV_Click;



            buttonSave_VEV.Enabled = false;
            buttonSave_VEV.Image = Properties.Resources.save;
            buttonSave_VEV.Location = new Point(120, 12);
            buttonSave_VEV.Name = "buttonSave_VEV";
            buttonSave_VEV.Size = new Size(48, 46);
            buttonSave_VEV.TabIndex = 2;
            toolTipSave_VEV.SetToolTip(buttonSave_VEV, "Сохранить обработанные данные в файл в формате CSV\r\n");
            buttonSave_VEV.UseVisualStyleBackColor = true;
            buttonSave_VEV.Click += buttonSave_VEV_Click;



            buttonDown_VEV.Enabled = false;
            buttonDown_VEV.Location = new Point(67, 12);
            buttonDown_VEV.Image = Properties.Resources.run;
            buttonDown_VEV.Name = "buttonDown_VEV";
            buttonDown_VEV.Size = new Size(47, 46);
            buttonDown_VEV.TabIndex = 1;
            toolTipDown_VEV.SetToolTip(buttonDown_VEV, "Выполнить обработку данных\r\n");
            buttonDown_VEV.UseVisualStyleBackColor = true;
            buttonDown_VEV.Click += buttonDown_VEV_Click;



            buttonOpen_VEV.Image = Properties.Resources.open;
            buttonOpen_VEV.Location = new Point(12, 12);
            buttonOpen_VEV.Name = "buttonOpen_VEV";
            buttonOpen_VEV.Size = new Size(49, 46);
            buttonOpen_VEV.TabIndex = 0;
            toolTip_VEV.SetToolTip(buttonOpen_VEV, "Открыть файл для обработки в формате данных CSV");
            buttonOpen_VEV.UseVisualStyleBackColor = true;
            buttonOpen_VEV.Click += buttonOpen_VEV_Click;



            panelCond_VEV.Controls.Add(groupBoxCond_VEV);
            panelCond_VEV.Dock = DockStyle.Top;
            panelCond_VEV.Location = new Point(0, 64);
            panelCond_VEV.Name = "panelCond_VEV";
            panelCond_VEV.Size = new Size(800, 94);
            panelCond_VEV.TabIndex = 1;



            groupBoxCond_VEV.Controls.Add(textBoxCond_VEV);
            groupBoxCond_VEV.Dock = DockStyle.Fill;
            groupBoxCond_VEV.Location = new Point(0, 0);
            groupBoxCond_VEV.Name = "groupBoxCond_VEV";
            groupBoxCond_VEV.Size = new Size(800, 94);
            groupBoxCond_VEV.TabIndex = 0;
            groupBoxCond_VEV.TabStop = false;
            groupBoxCond_VEV.Text = "Условие";



            textBoxCond_VEV.Dock = DockStyle.Fill;
            textBoxCond_VEV.Location = new Point(3, 23);
            textBoxCond_VEV.Multiline = true;
            textBoxCond_VEV.Name = "textBoxCond_VEV";
            textBoxCond_VEV.ReadOnly = true;
            textBoxCond_VEV.Size = new Size(794, 68);
            textBoxCond_VEV.TabIndex = 0;
            textBoxCond_VEV.Text = resources.GetString("textBoxCond_VEV.Text");



            panelIn_VEV.Controls.Add(groupBoxIn_VEV);
            panelIn_VEV.Dock = DockStyle.Left;
            panelIn_VEV.Location = new Point(0, 158);
            panelIn_VEV.Name = "panelIn_VEV";
            panelIn_VEV.Size = new Size(406, 292);
            panelIn_VEV.TabIndex = 2;



            groupBoxIn_VEV.Controls.Add(dataGridViewIn_VEV);
            groupBoxIn_VEV.Dock = DockStyle.Fill;
            groupBoxIn_VEV.Location = new Point(0, 0);
            groupBoxIn_VEV.Name = "groupBoxIn_VEV";
            groupBoxIn_VEV.Size = new Size(406, 292);
            groupBoxIn_VEV.TabIndex = 0;
            groupBoxIn_VEV.TabStop = false;
            groupBoxIn_VEV.Text = "Ввод";



            dataGridViewIn_VEV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_VEV.ColumnHeadersVisible = false;
            dataGridViewIn_VEV.Dock = DockStyle.Fill;
            dataGridViewIn_VEV.Location = new Point(3, 23);
            dataGridViewIn_VEV.Name = "dataGridViewIn_VEV";
            dataGridViewIn_VEV.ReadOnly = true;
            dataGridViewIn_VEV.RowHeadersVisible = false;
            dataGridViewIn_VEV.RowHeadersWidth = 51;
            dataGridViewIn_VEV.Size = new Size(400, 266);
            dataGridViewIn_VEV.TabIndex = 0;



            splitter_VEV.Location = new Point(406, 158);
            splitter_VEV.Name = "splitter_VEV";
            splitter_VEV.Size = new Size(4, 292);
            splitter_VEV.TabIndex = 3;
            splitter_VEV.TabStop = false;



            panelOut_VEV.Controls.Add(groupBoxOut_VEV);
            panelOut_VEV.Dock = DockStyle.Fill;
            panelOut_VEV.Location = new Point(410, 158);
            panelOut_VEV.Name = "panelOut_VEV";
            panelOut_VEV.Size = new Size(390, 292);
            panelOut_VEV.TabIndex = 4;



            groupBoxOut_VEV.Controls.Add(dataGridViewOut_VEV);
            groupBoxOut_VEV.Dock = DockStyle.Fill;
            groupBoxOut_VEV.Location = new Point(0, 0);
            groupBoxOut_VEV.Name = "groupBoxOut_VEV";
            groupBoxOut_VEV.Size = new Size(390, 292);
            groupBoxOut_VEV.TabIndex = 0;
            groupBoxOut_VEV.TabStop = false;
            groupBoxOut_VEV.Text = "Вывод";



            dataGridViewOut_VEV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_VEV.ColumnHeadersVisible = false;
            dataGridViewOut_VEV.Dock = DockStyle.Fill;
            dataGridViewOut_VEV.Location = new Point(3, 23);
            dataGridViewOut_VEV.Name = "dataGridViewOut_VEV";
            dataGridViewOut_VEV.ReadOnly = true;
            dataGridViewOut_VEV.RowHeadersVisible = false;
            dataGridViewOut_VEV.RowHeadersWidth = 51;
            dataGridViewOut_VEV.Size = new Size(384, 266);
            dataGridViewOut_VEV.TabIndex = 0;



            openFileDialog_VEV.FileName = "openFileDialog1";



            toolTip_VEV.AutomaticDelay = 300;
            toolTip_VEV.ToolTipIcon = ToolTipIcon.Info;
            toolTip_VEV.ToolTipTitle = "Открыть файл";



            toolTipDown_VEV.AutomaticDelay = 300;
            toolTipDown_VEV.ToolTipIcon = ToolTipIcon.Info;
            toolTipDown_VEV.ToolTipTitle = "Выполнить";



            toolTipSave_VEV.AutomaticDelay = 300;
            toolTipSave_VEV.ToolTipIcon = ToolTipIcon.Info;
            toolTipSave_VEV.ToolTipTitle = "Сохранить";



            toolTipQuestion_VEV.AutomaticDelay = 300;
            toolTipQuestion_VEV.ToolTipIcon = ToolTipIcon.Info;
            toolTipQuestion_VEV.ToolTipTitle = "Справка";



            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelOut_VEV);
            Controls.Add(splitter_VEV);
            Controls.Add(panelIn_VEV);
            Controls.Add(panelCond_VEV);
            Controls.Add(panelButtons_VEV);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 25 | Вашумирская Е. В.";
            panelButtons_VEV.ResumeLayout(false);
            panelCond_VEV.ResumeLayout(false);
            groupBoxCond_VEV.ResumeLayout(false);
            groupBoxCond_VEV.PerformLayout();
            panelIn_VEV.ResumeLayout(false);
            groupBoxIn_VEV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_VEV).EndInit();
            panelOut_VEV.ResumeLayout(false);
            groupBoxOut_VEV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_VEV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons_VEV;
        private Panel panelCond_VEV;
        private GroupBox groupBoxCond_VEV;
        private Panel panelIn_VEV;
        private GroupBox groupBoxIn_VEV;
        private DataGridView dataGridViewIn_VEV;
        private Splitter splitter_VEV;
        private Panel panelOut_VEV;
        private GroupBox groupBoxOut_VEV;
        private DataGridView dataGridViewOut_VEV;
        private Button buttonQuestion_VEV;
        private Button buttonSave_VEV;
        private Button buttonDown_VEV;
        private Button buttonOpen_VEV;
        private TextBox textBoxCond_VEV;
        private OpenFileDialog openFileDialog_VEV;
        private ToolTip toolTip_VEV;
        private SaveFileDialog saveFileDialog_VEV;
        private ToolTip toolTipDown_VEV;
        private ToolTip toolTipSave_VEV;
        private ToolTip toolTipQuestion_VEV;
    }
}
