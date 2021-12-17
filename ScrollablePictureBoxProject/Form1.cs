using ScrollablePictureBoxProject.Common;
using System;
using System.Windows.Forms;

namespace ScrollablePictureBoxProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => 
            this.Close();

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e) =>
            new OpenFileDialog().OpenImage(scrollablePictureBox.DisplayImage);
    }
}
