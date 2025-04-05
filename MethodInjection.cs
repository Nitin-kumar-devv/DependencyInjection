using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyInjectionByMethodInjection
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
        
        public void showDetails(IAcccount account)//Method Injection
        {
            account.printDetails();
        }
        public void showDetailsAllTogether(params IAcccount[] account)//Method Injection
        {
            foreach(var a in account)
            { 
                a.printDetails();
            }
            
        }
    }

    class MethodInjection
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            a1.showDetails(new SavingAccount());

            
            a1.showDetails(new CurrentAccount());

            Console.WriteLine("Giving both object together");
            SavingAccount sa = new SavingAccount();
            CurrentAccount ca = new CurrentAccount();
            a1.showDetailsAllTogether(sa, ca);
        }
    }
}
