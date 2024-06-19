using System.Diagnostics;

namespace Temperatures
{
    public partial class Form1 : Form
    {   
        int days = 0;
        double maxTemp = 100;
        double minTemp = -100;

        List<double> temperatures = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {   
                // exceptions
                if (!Double.TryParse(txtTemp.Text, out double value)) throw new Exception("Value must be a number");
                if (value > maxTemp || value < minTemp) throw new Exception("Value is out of range. Choose something between 100 and -100");
                if (txtTemp.Text == "") throw new Exception("Temperature cannot be left empty");

                // increment # of days
                days += 1;

                // add temp to temperatures list
                temperatures.Add(value);

                // sort temperatures from highest to lowest
                List<double> sortedTemps = new List<double>(temperatures);
                sortedTemps.Sort((a, b) => b.CompareTo(a));

                // get number of days
                txtDays.Text = days.ToString();

                // show highest
                txtHigh.Text = sortedTemps[0].ToString();

                // show lowest
                txtLow.Text = sortedTemps[days - 1].ToString();
                
                // calc average
                double sum = 0;
                foreach(double temp in temperatures)
                {
                    Debug.WriteLine(temp);
                    sum += temp;
                }
                double average = sum / days;

                // avg
                txtAvg.Text = Math.Round(average, 3).ToString();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
