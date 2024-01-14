using lab5.lab5.z1;
using lab5.lab5.z2;

internal class Program
{
 
    private static void Main(string[] args)
    {
      
            Kwadrat kwadrat1 = new Kwadrat(4);
            kwadrat1.CalculateArea();
            Koło koło1 = new Koło(6);
            koło1.CalculateArea();
            Trójkąt trójkąt1 = new Trójkąt(3, 7);
            trójkąt1.CalculateArea();
        
        IncomeTransaction przychód1 = new IncomeTransaction();
        przychód1.Amount = 20.5;
        przychód1.ProcessTransaction();
        Account.AddTransaction(przychód1);
        IncomeTransaction przychód2 = new IncomeTransaction();
        przychód2.Amount = 10.0;
        przychód2.ProcessTransaction();
       Account.AddTransaction(przychód2);
        ExpenseTransaction wydatek1 = new ExpenseTransaction();
        wydatek1.Amount = 12.0;
        wydatek1.ProcessTransaction();
        Account.AddTransaction(wydatek1);
        ExpenseTransaction wydatek2 = new ExpenseTransaction();
        wydatek2.Amount = 6.0;
        wydatek2.ProcessTransaction();
       Account.AddTransaction(wydatek2);
        Account.TransactHistory();
        Account.AccountBalance();



    }
    
}