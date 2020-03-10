using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using BankingApplication;

namespace BankingApplicaton
{
    static class Bank
    {
        // private static List<Account> ACCOUNTS;
        //private static List<Person> USERS;
        static void Main(String[] args)
        {

            static Bank()
            {
                //initialize the USERS collection
                private static List<Person> USERS = new List<Person>(){
                new Person("Narendra", "1234-5678"),  //0
                new Person("Ilia", "2345-6789"),      //1
                new Person("Tom", "3456-7890"),       //2
                new Person("Syed", "4567-8901"),      //3
                new Person("Arben", "5678-9012"),     //4
                new Person("Patrick", "6789-0123"),   //5
                new Person("Yin", "7890-1234"),       //6
                new Person("Hao", "8901-2345"),       //7
                new Person("Jake", "9012-3456"),      //8
                new Person("Joanne", "1224-5678"),    //9
                new Person("Nicoletta", "2344-6789"), //10
            };
        //initialize the ACCOUNTS collection
        private static List<Account> ACCOUNTS = new List<Account>{
                new VisaAccount(),              //VS-100000
                new VisaAccount(150, -500),     //VS-100001
                new SavingAccount(5000),        //SV-100002
                new SavingAccount(),            //SV-100003
                new CheckingAccount(2000),      //CK-100004
                new CheckingAccount(1500, true),//CK-100005
                new VisaAccount(50, -550),      //VS-100006
                new SavingAccount(1000),        //SV-100007
            };
        //associate users with accounts
        ACCOUNTS[0].AddUser(USERS[0]);
        ACCOUNTS[0].AddUser(USERS[1]);
        ACCOUNTS[0].AddUser(USERS[2]);

        ACCOUNTS[1].AddUser(USERS[3]);
        ACCOUNTS[1].AddUser(USERS[4]);
        ACCOUNTS[1].AddUser(USERS[5]);

        ACCOUNTS[2].AddUser(USERS[6]);
        ACCOUNTS[2].AddUser(USERS[7]);
        ACCOUNTS[2].AddUser(USERS[8]);

        ACCOUNTS[3].AddUser(USERS[9]);
        ACCOUNTS[3].AddUser(USERS[10]);

        ACCOUNTS[4].AddUser(USERS[2]);
        ACCOUNTS[4].AddUser(USERS[4]);
        ACCOUNTS[4].AddUser(USERS[6]);

        ACCOUNTS[5].AddUser(USERS[8]);
        ACCOUNTS[5].AddUser(USERS[10]);

        ACCOUNTS[6].AddUser(USERS[1]);
        ACCOUNTS[6].AddUser(USERS[3]);

        ACCOUNTS[7].AddUser(USERS[5]);
        ACCOUNTS[7].AddUser(USERS[7]); }
            
           // PrintAccounts();
            //PrintPersons();
            //GetPerson("Narendra");
        
        public static void PrintAccounts()
        {
            Console.WriteLine("\nAll Accounts");
            foreach(Account acc in ACCOUNTS)
            {
                Console.WriteLine(acc);
            }

        }
        public static void PrintPersons()
        {
            Console.WriteLine("All Persons");
            foreach (var per in USERS)
            {
                Console.WriteLine(per);
            }

        }
        public static Person GetPerson(String person)
        {
            int result = 0;
            foreach (Person per in USERS)
            {
                if (per.Name.Contains(person))
                {
                    result = 1;
                    return per;
                }
             }
            if (result==1)
            {
                return new Person("Alisha","123434");
            }
            else
            {
                AccountException accountException = new AccountException(ExceptionEnum.USER_DOES_NOT_EXIST);
                Console.WriteLine(accountException);
                return null;
            }

        }
        public static Account GetAccount(String number)
        {
            foreach (Account acc in ACCOUNTS)
            {
                if (acc.Number.Contains(number))
                {
                    Console.WriteLine($"Account number: {number}  exists in the collection");
                    return acc;

                }
                else
                {
                    AccountException accountException = new AccountException(ExceptionEnum.ACCOUNT_DOES_NOT_EXIST);
                    Console.WriteLine(accountException);
                    return null;
                }
               
            }

        }

    }
    

