using System;
using System.Collections.Generic;

namespace Investments.Reporting
{
    //выписка по счету
    //аккаунтная ведомость
    public class AccountStatement
    {
        public string Account { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public decimal StartingBalance { get; set; }

        public List<AccountStatementEntry> Entries { get; set; }

        public AccountStatement()
        {
            Entries = new List<AccountStatementEntry>();
        }
    }
}