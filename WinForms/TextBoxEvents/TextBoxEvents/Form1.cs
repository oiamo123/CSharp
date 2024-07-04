using System.Text.RegularExpressions;

namespace TextBoxEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // allow only ceretain keys
        // e.Key is the key pressed

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar)
                && e.KeyChar != ' '
                && e.KeyChar != '-'
                && e.KeyChar != '\''
                && e.KeyChar != (char)Keys.Back) // if NOT a valid key
            {
                e.Handled = true; // ignore it
            }
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex pattern = new Regex("^\\w\\d\\w\\ ?\\d\\w\\d$");

        }
    }
}
