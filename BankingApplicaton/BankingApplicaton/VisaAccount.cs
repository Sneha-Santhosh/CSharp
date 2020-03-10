using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    class VisaAccount : Account,ITransaction
    {
        private double creditLimit;
        private static double INTEREST_RATE = 0.1995;

        public VisaAccount(double balance =0, double creditLimit=1200)
            :base("VS-",balance)
        {
            this.creditLimit = creditLimit;
        }
        public void DoPayment(double amount, Person person)
        {
            base.Deposit(amount, person);
        }
        public void DoPurchase(double amount,Person person)
        {
            if (!base.IsUser(person.Name))
            {
                AccountException accountException = new AccountException(ExceptionEnum.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);
            }
            if (!person.IsAuthenticated)
            {
                AccountException accountException = new AccountException(ExceptionEnum.USER_NOT_LOGGED_IN);
            }
            if (amount > Balance)
            {
                AccountException accountException = new AccountException(ExceptionEnum.NO_OVERDRAFT);
            }
            base.Deposit(-amount, person);
        }
        public override void PrepareMonthlyReport()
        {
            double interest = (LowestBalance * INTEREST_RATE) / 12;
            Balance = Balance - interest;
            transactions.Clear();
        }

        public void Withdraw(double amount, Person person)
        {
            throw new NotImplementedException();
        }
    }
}
