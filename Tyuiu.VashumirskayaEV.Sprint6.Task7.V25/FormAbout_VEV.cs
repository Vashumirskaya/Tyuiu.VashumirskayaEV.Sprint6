using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.VashumirskayaEV.Sprint6.Task7.V25
{
    public partial class FormAbout_VEV : Form
    {
        public FormAbout_VEV()
        {
            InitializeComponent();
            pictureBox_VEV.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_VEV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
