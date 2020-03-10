using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theatre
{
   public enum MovieDay
    {
        Sun,
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat

    }

    [Flags]
    public enum MovieGenre
    {
     Unrated =0,
     Action=1,
     Romance = 2,
     Documentary =4,
     Mystery = 8,
     Musical =16,
     Horror = 32,
     Comedy = 64,
     Fantasy = 128,
     Animation = 256,
     Adventure = 512

    }
}
