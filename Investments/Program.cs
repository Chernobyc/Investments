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
            var account = context.Accounts[0];
            var statementBuilder = new AccountStatementBuilder(account);
            var statement = statementBuilder.Build(DateTime.Parse("01.01.2023"), DateTime.Now);
            IAccountStatementPrinter printer;

            printer = new ConsoleAccountStatementPrinter(statement);
            printer.Print();

            printer = new HtmlAccountStatementPrinter(statement, "statement.html");
            printer.Print();

        }
    }
}