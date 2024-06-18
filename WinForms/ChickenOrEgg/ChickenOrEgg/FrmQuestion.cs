using System.Windows.Forms.VisualStyles;

namespace ChickenOrEgg
{
    public partial class FrmQuestion : Form
    {
        public FrmQuestion()
        {
            InitializeComponent();
        }

        private void radChicken_CheckedChanged(object sender, EventArgs e)
        {
            picAnswer.Image = Image.FromFile("..\\..\\..\\Images\\chicken.jpg");
        }

        private void radEgg_CheckedChanged(object sender, EventArgs e)
        {
            picAnswer.Image = Image.FromFile("..\\..\\..\\Images\\egg.jpg");
        }
    }
}
