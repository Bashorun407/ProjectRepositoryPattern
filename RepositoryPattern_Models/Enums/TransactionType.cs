using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Models.Enums
{
    public enum TransactionType
    {
        [Description("Local Dishes")]
        Withdrawal = 1, Deposit, Transfer

    }
}
