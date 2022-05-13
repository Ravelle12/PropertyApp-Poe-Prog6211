using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    internal class Expenses
    {
        double grossincome;
        double taxdeductionmonthly;
        double repayment;
        double montlyrentalcosts;

        public Expenses(double grossincome, double taxdeductionmonthly, double repayment, double montlyrentalcosts)
        {
            this.grossincome = grossincome;
            this.taxdeductionmonthly = taxdeductionmonthly;
            this.repayment = repayment;
            this.montlyrentalcosts = montlyrentalcosts;
        }

        public double Grossincome { get => grossincome; set => grossincome = value; }
        public double Taxdeductionmonthly { get => taxdeductionmonthly; set => taxdeductionmonthly = value; }
        public double Repayment { get => repayment; set => repayment = value; }
        public double Montlyrentalcosts { get => montlyrentalcosts; set => montlyrentalcosts = value; }

        public string Aprroval(double monthsincome, double RepaymentLoan)
        {
        if (RepaymentLoan>(monthsincome/3))
            {
            return "loan not accessible";
    }
            else {return " loan is aprroved";}
            }
}
}
