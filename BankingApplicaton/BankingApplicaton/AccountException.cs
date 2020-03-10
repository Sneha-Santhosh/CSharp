using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    class AccountException:Exception
    {
        ExceptionEnum reason;
        //Exception
        public AccountException(ExceptionEnum reason)
        {
            this.reason = reason;          
        }
        public override string ToString()
        {
            return $"{reason}";
        }


    }


}
