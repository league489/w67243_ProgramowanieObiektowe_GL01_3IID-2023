using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.lab5.z2
{
    public class IncomeTransaction : Transaction
    {
        public override void ProcessTransaction()
        {
            Account.TotalIncome += Amount;
        }
    }
}
