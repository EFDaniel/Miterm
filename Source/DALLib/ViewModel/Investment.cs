using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Learning to use git - prob delete before turn in.

namespace DALLib.ViewModel
{
    public class Investment
    {
        #region [ Properties ]

        public double MonthlyInvestment { get; set; }
        public double YearlyInterestRate { get; set; }
        public int NumberOfYears { get; set; }
        public double FutureValue { get; set; }

        #endregion [ Properties ]

        #region [ Constructors ]

        public Investment()
        {
        }

        public Investment(
            double monthlyInvestmen, 
            double yearlyInterestRate, 
            int numberOfYears)
        {
            MonthlyInvestment=monthlyInvestmen;
            YearlyInterestRate=yearlyInterestRate;
            NumberOfYears=numberOfYears;
            FutureValue=CalculateFutureValue();
        }

        #endregion [ Constructors ]

         #region [ Methods ]

        public double CalculateFutureValue()
        {
            double MonthlyInterestRate = YearlyInterestRate / 12 / 100;
            int Months = NumberOfYears * 12;

            double FutureValue =
     MonthlyInvestment * (Math.Pow(1 + MonthlyInterestRate, Months) - 1) / MonthlyInterestRate;

            return FutureValue;

        }


        #endregion [ Methods ]

    }

}
