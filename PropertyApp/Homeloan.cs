using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    internal class Homeloan : Expenses 
    {
        double Deposit;
        double Price;
        double Repayment;
        double Interest;
        
        public Homeloan(double monthlyrepayment,
            double rental,
            double monthlytaxdectuctions,
            double monthlygross,
            double storage) : base(monthlyrepayment, rental, monthlytaxdectuctions, monthlygross)                   

    }
}
