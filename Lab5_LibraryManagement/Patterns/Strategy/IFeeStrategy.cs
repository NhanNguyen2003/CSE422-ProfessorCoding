using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_LibraryManagement.Patterns.Strategy
{
    public interface IFeeStrategy
    {
        decimal CalculateFee(int days);
    }
}
