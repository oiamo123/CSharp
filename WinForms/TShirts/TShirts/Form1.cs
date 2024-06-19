using System.Diagnostics;

namespace TShirts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var textboxes = new List<TextBox> { txtBlack, txtWhite, txtRed };

            var shirts = new Dictionary<string, int[]>()
            {
                { "Black", new int[] { 345, 564, 1245, 1690 } },
                { "White", new int[] { 1232, 1534, 795, 238 } },
                { "Red", new int[] { 1189, 1387, 987, 546 } }
            };

            var sizes = new Dictionary<string, int>()
            {
                { "S", 0 },
                { "M", 0 },
                { "L", 0 },
                { "XL", 0 }
            };

            string largestLabel = "";
            int largestQty = 0;
            
            foreach (var textbox in textboxes)
            {
                string color = textbox.Tag.ToString();

                int sum = shirts[color].Sum();

                textbox.Text = sum.ToString();

                if (sum > largestQty)
                {
                    largestLabel = color;
                    largestQty = sum;
                }

                sizes["S"] += shirts[color][0];
                sizes["M"] += shirts[color][1];
                sizes["L"] += shirts[color][2];
                sizes["XL"] += shirts[color][3];
            }

            var sortedSizes = sizes.OrderBy(size => size.Value).ToList();
            
            lblWinner.Text = $"Shirts sold: {largestLabel}, {largestQty}, Size sold: {sortedSizes.Last().Key}, {sortedSizes.Last().Value}";

        }
    }
}
