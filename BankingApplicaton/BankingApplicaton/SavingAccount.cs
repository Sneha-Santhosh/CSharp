using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    class SavingAccount : Account, ITransaction
    {
        private static double COST_PER_TRANSACTION = 0.05;
        private static double INTEREST_RATE = 0.015;
        

        public SavingAccount(double balance = 0)
            : base("SV-", balance)
        {   }
        public new void Deposit(double amount, Person person)
        {
            base.Deposit(amount, person);
        }
        public void Withdraw(double amount, Person person)
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
            double service_charge = COST_PER_TRANSACTION * transactions.Count();
            double interest = (Balance * INTEREST_RATE) / 12;
            Balance = Balance + interest - service_charge;
            transactions.Clear();
        }
    }
}
