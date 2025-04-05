using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyInjection
{
    /*Code with problem
    class SavingAccount
    {
        public void printDetails()
        {
            Console.WriteLine("Printing the details of Saving Account");
        }
    }
    class CurrentAccount
    {
        public void printDetails()
        {
            Console.WriteLine("Printing the details of Current Accounts");
        }
    }
    class Account
    {
        SavingAccount s = new SavingAccount();
        CurrentAccount c = new CurrentAccount();
        public void showDetails()
        {
            
            s.printDetails();
            c.printDetails();

        }
    }
*/
    //SOLUTION BY DEPENDENCY INJECTION
    //using Interface
    interface IAcccount
{
    void printDetails();
}
class SavingAccount:IAcccount
{
    public void printDetails()
    {
        Console.WriteLine("Printing the details of Saving Account");
    }
}
class CurrentAccount:IAcccount
{
    public void printDetails()
    {
        Console.WriteLine("Printing the details of Current Accounts");
    }
}
class Account
{
    //private IAcccount account;
    private readonly IAcccount[] account;
        //public Account(IAcccount account)
        //{
        //    this.account = account;
        //}
        public Account(params IAcccount[] account)
        {
            this.account = account;
        }
        //public void showdetails()
        //{
        //    account.printDetails();
        //} 
        public void showdetails()
        {
            foreach(var a in account)
            {
                a.printDetails();
            }
            
        }
    }
class Program
    {
        static void Main(string[] args)
        {
            //Account a = new Account();
            //a.showDetails();

            IAcccount i1 = new SavingAccount();
            Account a1 = new Account(i1);
            a1.showdetails();
        
            i1 = new SavingAccount();
            Account a2 = new Account(i1);
            a2.showdetails();

            SavingAccount s = new SavingAccount();
            CurrentAccount c = new CurrentAccount();

            Account a3 = new Account(s, c);
            a3.showdetails();

        }
    }
}
