using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.lab5.z2
{
    public abstract class Transaction
    {
        public double Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public abstract void ProcessTransaction();
    }
}
