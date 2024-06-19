namespace Conversions
{
    /*
     * Uses methods to convert between metric system (centimeters) and imperial (feet and inches)
     * Author: Jolanta
     * When:  June 2024
     */
    public partial class frmConversions : Form
    {
        // conversion constants
        const double CM_IN_INCH = 2.54;
        const int INCHES_IN_FOOT = 12;
        public frmConversions()
        {
            InitializeComponent();
        }

        // converting from metric to imperial
        private void btnToMetric_Click(object sender, EventArgs e)
        {
            int feet, inches;
            double centimeters;

            if (Validator.IsPresent(txtFeet) && Validator.isNonNegativeDouble(txtFeet) && Validator.IsPresent(txtInches) && Validator.isNonNegativeDouble(txtInches))
            {
                // get feet and inches
                feet = Convert.ToInt32(txtFeet.Text);
                inches = Convert.ToInt32(txtInches.Text);

                // convert to centimeters
                centimeters = ToCentimeters(feet, inches);

                // display centimeters
                txtCentimeters.Text = centimeters.ToString("f2"); 
            }
        }

        /// <summary>
        /// converts from feet and inches to centimeters
        /// </summary>
        /// <param name="f">feet</param>
        /// <param name="i">inches</param>
        /// <returns>same length in centimeters</returns>
        private double ToCentimeters(int f, int i)
        {
            int totalInches = f * INCHES_IN_FOOT + i;
            double cm = totalInches * CM_IN_INCH;
            return cm;
        }

        // convert from imperial to metric
        private void btnToImperial_Click(object sender, EventArgs e)
        {
            double centimeters;
            int feet, inches;

            if (Validator.IsPresent(txtCentimeters) && Validator.isNonNegativeDouble(txtCentimeters))
            {
                // get centimeters
                centimeters = Convert.ToDouble(txtCentimeters.Text);

                // convert to feet and inches
                ToFeetAndInches(centimeters, out feet, out inches);

                // display feet and inches
                txtFeet.Text = feet.ToString();
                txtInches.Text = inches.ToString(); 
            }
        }

        /// <summary>
        /// converts from centimeters to feet and inches
        /// </summary>
        /// <param name="cm">centimeters</param>
        /// <param name="f">feet (out)</param>
        /// <param name="i">inches (out)</param>
        private void ToFeetAndInches(double cm, out int f, out int i)
        {
            int totalInches = (int) Math.Round(cm / CM_IN_INCH);
            f = totalInches / INCHES_IN_FOOT;
            i = totalInches % INCHES_IN_FOOT;
        }
    }// end class
}// end namespace
