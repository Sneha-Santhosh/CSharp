using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    abstract class Account
    {
        public readonly List<Person> users = new List<Person>() { };

        public readonly List<Transaction> transactions = new List<Transaction>() { };

        private static int LAST_NUMBER = 100_000;

        public string Number { get;  }

        public double Balance { get; protected set; }

        public double LowestBalance { get; protected set; }

        public Account(string type, double balance)
        {
            //this.users = users;
            //this.transactions = transactions;
            Number = type+LAST_NUMBER;
            LAST_NUMBER++;
            Balance = balance;
            LowestBalance = balance; ;
        }
        public void Deposit(double amount,Person person)
        {
            Balance = Balance + amount;
            LowestBalance = Balance;
            Transaction transaction = new Transaction(Number, amount, person, DateTime.Now);
            transactions.Add(transaction);
        }
        public void AddUser(Person person)
        {
            users.Add(person);
        }
        public bool IsUser(string name)
        {
            bool result = false;
            foreach (var u in users)
            {
                if (u.Name.Equals(name))
                {result = true;
                }
                else
                {
                   result = false;
                }

            }
            return result;
            
        }
        public abstract void PrepareMonthlyReport();

        public override string ToString()
        {
            string name="";
            foreach (var u in users)
            {
                name +=" "+ u.Name;

            }
            string trans="";
            foreach (var t in transactions)
            {
                trans += " " + t;

            }

            return $"Account Number:{Number} Balance Remaining:{Balance} User(s):{name} Transctions:{trans}";
        }
    }
}
