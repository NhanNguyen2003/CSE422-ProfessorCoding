using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_LibraryManagement.Patterns.Strategy
{
    public class Loan
    {
        private IFeeStrategy _strategy;

        public Loan(IFeeStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal GetFee(int days)
        {
            return _strategy.CalculateFee(days);
        }
    }
}
