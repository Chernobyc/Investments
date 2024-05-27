using System;
using System.Linq;
using Investments.Data;
using Investments.Reporting;

namespace Investments
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DataContext();

            InstitutionsGenerator.GenerateInstitutions(context);
            BankAccountsGenerator.GenerateBankAccounts(context);
            SecurablesGenerator.GenerateSecurables(context);
            ExchangeRatesGenerator.GenerateExchangeRates(context);
            TransactionsGenerator.GenerateTransactions(context);
            TransactionEntriesGenerator.GenerateTransactionEntries(context);

            // Lisage sellele kontole piisavalt kandeid
            // Добавьте достаточно записей в этот аккаунт
            var account = context.Accounts[0];
            //System.Collections.Generic.List<TransactionEntry> entries = context.Accounts[0].Entries;
            var statementBuilder = new AccountStatementBuilder(account);
            var statement = statementBuilder.Build(DateTime.Parse("01.01.2022"), DateTime.Now); //statementBuilder.Build(DateTime.Now.AddDays(-30), DateTime.Now)
            IAccountStatementPrinter printer;


            printer = new HtmlAccountStatementPrinter(statement, "statement.html");
            printer.Print();

            printer = new ConsoleAccountStatementPrinter(statement);
            printer.Print();
        }
    }
}