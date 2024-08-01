using System.ComponentModel.DataAnnotations;

namespace FutureValueMVC.Models
{
    public class FVModel
    {
        [Required (ErrorMessage = "Monthly investment is required")]
        [Range(10, 10000, ErrorMessage ="Monthly investment must be {1}-{2}")]
        public decimal? MonthlyInvestment { get; set; }

        [Required(ErrorMessage = "Annual interest rate is required")]
        [Range(1,50, ErrorMessage = "Annual interest rate must be {1}-{2}")]
        public decimal? AnnualInterestRate { get; set; }

        [Required(ErrorMessage = "Years is required")]
        [Range(1, 100, ErrorMessage = "Years must be {1}-{2}")]
        public int? Years { get; set; }

        public decimal? CalculateFV()
        {
            decimal? fv = 0;
            // interest accrues monthly
            int? months = Years * 12;
            decimal? monthlyInterestRate = AnnualInterestRate / 12 / 100; // decimal value, not %
            for(int m=0; m< months; m++)
            {
                fv = (fv + MonthlyInvestment) * (1 + monthlyInterestRate);
            }
            return fv;
        }

    }
}
