using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    class Transaction
    {
        public string AccountNumber;
        public double Amount;
        public Person Originator;
        public DateTime Time;

        public Transaction(string accountNumber, double amount, Person originator, DateTime time)
        {
            AccountNumber = accountNumber;
            Amount = amount;
            Originator = originator;
            Time = time;
        }
        public override string ToString()
        {
            return $"{AccountNumber} {Time} {Originator} {Amount} {(Amount<0?"Withraw":"Deposit")}";
           
        }
    }
}
