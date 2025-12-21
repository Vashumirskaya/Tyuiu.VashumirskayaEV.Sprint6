using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using Font = System.Drawing.Font;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task7.V25
{
    partial class FormAbout_VEV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_VEV));
            pictureBox_VEV = new PictureBox();
            textBox_VEV = new TextBox();
            button_VEV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_VEV).BeginInit();
            SuspendLayout();



            pictureBox_VEV.Image = Properties.Resources.me;
            pictureBox_VEV.Location = new Point(12, 12);
            pictureBox_VEV.Name = "pictureBox_VEV";
            pictureBox_VEV.Size = new Size(151, 206);
            pictureBox_VEV.TabIndex = 0;
            pictureBox_VEV.TabStop = false;



            textBox_VEV.BackColor = SystemColors.Control;
            textBox_VEV.BorderStyle = BorderStyle.None;
            textBox_VEV.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_VEV.Location = new Point(181, 12);
            textBox_VEV.Multiline = true;
            textBox_VEV.Name = "textBox_VEV";
            textBox_VEV.ReadOnly = true;
            textBox_VEV.Size = new Size(376, 172);
            textBox_VEV.TabIndex = 1;
            textBox_VEV.Text = resources.GetString("textBox_VEV.Text");



            button_VEV.Location = new Point(489, 190);
            button_VEV.Name = "button_VEV";
            button_VEV.Size = new Size(68, 35);
            button_VEV.TabIndex = 2;
            button_VEV.Text = "OK";
            button_VEV.UseVisualStyleBackColor = true;
            button_VEV.Click += button_VEV_Click;



            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 241);
            Controls.Add(button_VEV);
            Controls.Add(textBox_VEV);
            Controls.Add(pictureBox_VEV);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout_VEV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox_VEV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_VEV;
        private TextBox textBox_VEV;
        private Button button_VEV;
        
    }
}