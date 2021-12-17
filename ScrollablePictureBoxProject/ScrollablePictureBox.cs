using System.Drawing;
using System.Windows.Forms;

namespace ScrollablePictureBoxProject
{
    public partial class ScrollablePictureBox : UserControl
    {
        public ScrollablePictureBox()
        {
            InitializeComponent();
        }

        public Image Image { get => pictureBox.Image; set => pictureBox.Image = value; }

        public void DisplayImage(Image image) => pictureBox.Image = image;
    }
}
