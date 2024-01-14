using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab5.lab5.z2
{
    public class Account
    {
        public static List<Transaction> TransactionList = new List<Transaction>();
        public static double TotalIncome;
        public static double TotalExpense;
        public static void AddTransaction(Transaction transakcja)
        {
            TransactionList.Add(transakcja);
        }
        public static void TransactHistory()
        {
            foreach (var transact in TransactionList)
            {
                if (transact is IncomeTransaction)
                {
                    Console.WriteLine($"Przychód: {transact.Amount}  zł");
                }
                else if (transact is ExpenseTransaction)
                {
                    Console.WriteLine($"Wydatek: - {transact.Amount} zł");
                }
                else
                {
                    // Dodatkowa obsługa, jeśli pojawią się inne typy transakcji
                    Console.WriteLine($"Inny typ transakcji: {transact.Amount} zł");
                }
            }
        }

        public static void AccountBalance()
        {
            double balance = TotalIncome - TotalExpense;
            Console.WriteLine($"Bieżący stan konta: {balance} zł");
        }




    }
}
