using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismAbstractClasses
{   

    internal interface IManageBank
    {
        void OpenAccount();
        void CloseAccount();
    }


    internal interface IBankAccount
    {
        void Deposit();
        void Withdraw();
        void Balance();

    }

    public class SavingAcc : IBankAccount, IManageBank
    {
        public void OpenAccount()
        {
            Console.WriteLine("Congrats on your new account");
        }

        public void CloseAccount()
        {
            Console.WriteLine("See you later alligator");
        }

        public void Balance()
        {
            Console.WriteLine("Balance is...");
        }

        public void Deposit()
        {
            Console.WriteLine("Deposit into...");
        }

        public void Withdraw()
        {
            Console.WriteLine("Withdraw from...");
        }
    }
}
