using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScrollablePictureBoxProject.Common
{
    public static class OpenFileDialogExtensions
    {
        public static void OpenImage(this OpenFileDialog ofd, Action<Image> onSelectedImage)
        {
            ofd.Title = "Open Image";
            ofd.Filter = "Image Files| *.jpg; *.jpeg; *.png; *.bmp; *.tiff;";
            if (ofd.ShowDialog() == DialogResult.OK)
                onSelectedImage(Image.FromFile(ofd.FileName));
        }
    }
}
