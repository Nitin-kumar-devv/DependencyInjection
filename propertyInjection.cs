using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyInjectionByProperty
{
    interface IAcccount
    {
        void printDetails();
    }
    class SavingAccount : IAcccount
    {
        public void printDetails()
        {
            Console.WriteLine("Printing the details of Saving Account");
        }
    }
    class CurrentAccount : IAcccount
    {
        public void printDetails()
        {
            Console.WriteLine("Printing the details of Current Accounts");
        }
    }
    class Account
    {
        public IAcccount account { get; set; }//property to inject dependency
        public void showDetails()
        {
            account.printDetails();
        }
    }
    class propertyInjection
    {
        static void Main(string[] args)
        {
            Account sa = new Account();
            sa.account = new SavingAccount();
            sa.showDetails();

            Account ca = new Account();
            ca.account = new CurrentAccount();
            ca.showDetails();
        }
    }
    
}
