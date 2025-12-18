namespace Tyuiu.VashumirskayaEV.Sprint6.Task6.V26
{
    partial class FormAbout_VEV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_VEV));
            pictureBoxLogo_VEV = new PictureBox();
            labelDeveloper_VEV = new Label();
            labelGroup_VEV = new Label();
            labelPurpose_VEV = new Label();
            labelUniversity_VEV = new Label();
            labelInternalName_VEV = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_VEV).BeginInit();
            SuspendLayout();

            pictureBoxLogo_VEV.Image = Properties.Resources.logo; 
            pictureBoxLogo_VEV.Location = new Point(12, 12);
            pictureBoxLogo_VEV.Name = "pictureBoxLogo_VEV";
            pictureBoxLogo_VEV.Size = new Size(200, 200);
            pictureBoxLogo_VEV.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo_VEV.TabIndex = 0;
            pictureBoxLogo_VEV.TabStop = false;

            labelDeveloper_VEV.AutoSize = true;
            labelDeveloper_VEV.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDeveloper_VEV.Location = new Point(218, 20);
            labelDeveloper_VEV.Name = "labelDeveloper_VEV";
            labelDeveloper_VEV.Size = new Size(311, 23);
            labelDeveloper_VEV.TabIndex = 1;
            labelDeveloper_VEV.Text = "Разработчик: Вашумирская Елизавета Владимировна";

            labelGroup_VEV.AutoSize = true;
            labelGroup_VEV.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelGroup_VEV.Location = new Point(218, 55);
            labelGroup_VEV.Name = "labelGroup_VEV";
            labelGroup_VEV.Size = new Size(111, 23);
            labelGroup_VEV.TabIndex = 2;
            labelGroup_VEV.Text = "Группа: СМАРТб-25-1";

            labelPurpose_VEV.AutoSize = true;
            labelPurpose_VEV.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPurpose_VEV.Location = new Point(218, 90);
            labelPurpose_VEV.Name = "labelPurpose_VEV";
            labelPurpose_VEV.Size = new Size(336, 23);
            labelPurpose_VEV.TabIndex = 3;
            labelPurpose_VEV.Text = "Программа разработана в рамках изучения языка С#";

            labelUniversity_VEV.AutoSize = true;
            labelUniversity_VEV.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUniversity_VEV.Location = new Point(218, 125);
            labelUniversity_VEV.Name = "labelUniversity_VEV";
            labelUniversity_VEV.Size = new Size(257, 23);
            labelUniversity_VEV.TabIndex = 4;
            labelUniversity_VEV.Text = "Тюменский индустриальный университет";

            labelInternalName_VEV.AutoSize = true;
            labelInternalName_VEV.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInternalName_VEV.Location = new Point(218, 160);
            labelInternalName_VEV.Name = "labelInternalName_VEV";
            labelInternalName_VEV.Size = new Size(308, 23);
            labelInternalName_VEV.TabIndex = 5;
            labelInternalName_VEV.Text = "Внутреннее имя: Tyuiu.VashumirskayaEV.Sprint6.Task6.V26";

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 225);
            Controls.Add(labelInternalName_VEV);
            Controls.Add(labelUniversity_VEV);
            Controls.Add(labelPurpose_VEV);
            Controls.Add(labelGroup_VEV);
            Controls.Add(labelDeveloper_VEV);
            Controls.Add(pictureBoxLogo_VEV);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout_VEV";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_VEV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo_VEV;
        private Label labelDeveloper_VEV;
        private Label labelGroup_VEV;
        private Label labelPurpose_VEV;
        private Label labelUniversity_VEV;
        private Label labelInternalName_VEV;
    }
}