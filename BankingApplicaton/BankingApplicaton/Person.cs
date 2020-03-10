using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    class Person
    {
        private string password;

        public bool IsAuthenticated { get; private set; }

        public string SIN { get; }

        public string Name { get; }

        public Person(string name, string sin)
        {
            Name = name;
           SIN = sin;
            //sets the password first 3 letters of 
            password = SIN.Substring(0, 3);
        }
        public void Login(string password)
        {
            if (this.password == password)
            {
                IsAuthenticated = true;
            }

            else
            {
                IsAuthenticated = false;
              //  AccountException.PASSWORD_iNCORRECT;throw exception

            }

        }
        public void Logout()
        {
            IsAuthenticated = false;
        }
        public override string ToString()
        {
            return $"Name of the person is: {Name}" ;
        } 
    }
}
