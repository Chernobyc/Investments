using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Investments.Reporting
{
    public class AccountStatementBuilder
    {
        private readonly Account _account; //

        public AccountStatementBuilder(Account account)
        {
            _account = account;
        }
        //public GetStartingBalance()
        //{
        //    return;
        //}

        public AccountStatement Build(DateTime from, DateTime to)
        {
            var statement = new AccountStatement();

            statement.Account = _account.AccountNo + " (" + _account.Name + ")";
            statement.From = from;
            statement.To = to;

            // Leia konto algseis kuupäeva from jaoks
            // Найди исходный баланс счёта 
            statement.StartingBalance = 1000; // приравнять к входящим на счет средствам (первому переводу)

            statement.Entries.AddRange(GenerateEntries(from, to, statement.StartingBalance));

            return statement;
        }

        private List<AccountStatementEntry> GenerateEntries(DateTime from, DateTime to, decimal startingBalance)
        {
            var list = new List<AccountStatementEntry>();

            foreach(var trans in _account.Entries)
            {
                var entry = new AccountStatementEntry();
                entry.TransactionId = trans.TransactionId;

                entry.OtherAccount = trans.OtherAccount;

                //TimeSpan date = from.Subtract(now);
                //entry.Time = Convert.ToDateTime(date);
                //var date = from.ToString();
                //entry.Time = ;
                //entry.Description =  ;

                // Arvuta kontoseis peale tehingut
                // Рассчитайте баланс счета после транзакции
                entry.Balance = startingBalance - trans.Amount;

                list.Add(entry);
            }

            return list;
        }
    }
}
