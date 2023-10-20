using System;

namespace Investments.Reporting
{
    public class AccountStatementEntry
    {
        public string TransactionId { get; set; }
        public DateTime Time { get; set; }
        public Account OtherAccount { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public decimal Balance { get; set; }
    }
}
