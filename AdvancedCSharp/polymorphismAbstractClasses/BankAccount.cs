using System;

namespace polymorphismAbstractClasses
{
    public abstract class BankAccount
    {
        public void getMessage()
        {
            Console.WriteLine("Welcome to the Killeen bank!");
        }
        public abstract void Deposit();

        public abstract void Withdraw();

        public abstract void Balance();
    }

    public class SavingsAccount : BankAccount
    {
        public override void Deposit() 
        {
            Console.WriteLine("Balance in Account.");    

        }

        public override void Withdraw()
        {
            Console.WriteLine("Deposit into account.");
        }

        public override void Balance() 
        {
            Console.WriteLine("Withdraw from account.");
        }
    }
}