using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

        //private BalanceBuild()
        //{

        //}

        public AccountStatement Build(DateTime from, DateTime to)
        {
            var statement = new AccountStatement();

            statement.Account = _account.AccountNo + " (" + _account.Name + ")";
            statement.From = from;
            statement.To = to;

            // Leia konto algseis kuupäeva from jaoks
            // Найди исходный баланс счёта 

            // приравнять к входящим на счет средствам (первому переводу)
            statement.StartingBalance = 0; //_account.Entries[0].Amount
            //statement.StartingBalance = () =>
            //{
            //    decimal balance = List<AccountStatementEntry>[0] == null ? 0 : _account.Entries[0];
            //    return balance;
            //};

            statement.Entries.AddRange(GenerateEntries(from, to, statement.StartingBalance));

            return statement;
        }

        private List<AccountStatementEntry> GenerateEntries(DateTime from, DateTime to, decimal startingBalance)
        {
            var list = new List<AccountStatementEntry>();
            decimal tempBalance = startingBalance;

            foreach (var trans in _account.Entries)
            {
                var entry = new AccountStatementEntry();
                entry.TransactionId = trans.TransactionId;
                entry.Time = trans.Time;
                entry.OtherAccount = trans.OtherAccount;
                entry.Description = trans.Description;

                // Arvuta kontoseis peale tehingut
                // Рассчитайте баланс счета после транзакции
                if (trans.OtherAccount == _account)
                {
                    tempBalance += trans.Amount;
                }
                else if (trans.OwningAccount == _account)
                {
                    tempBalance -= trans.Amount;
                }

                entry.Balance = tempBalance;

                list.Add(entry);
            }

            return list;
        }
    }
}
