using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investments
{
    public class Transaction
    {
        // public DateOnly Date {  get; set; }
        public Securable Name { get; set; }
        public TransactionTypeEnum Type { get; set; }
        public DateTime Time { get; set; }
    }
}
