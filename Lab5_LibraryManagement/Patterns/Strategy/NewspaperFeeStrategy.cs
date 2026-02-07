using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_LibraryManagement.Patterns.Strategy
{
    public class NewspaperFeeStrategy : IFeeStrategy
    {
        public decimal CalculateFee(int days)
        {
            return days * 1000;
        }
    }
}
