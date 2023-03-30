using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingMiniProject
{
    class ExceptionBanking
    {
        
    }
    public class MinimunBalanceException : Exception
    {
        public MinimunBalanceException(string msg) : base(msg)
        {

        }
    }
}

