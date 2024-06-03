using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investments.Reporting
{
    public class ConsoleAccountStatementPrinter : IAccountStatementPrinter
    {
        private readonly AccountStatement _statement;

        public ConsoleAccountStatementPrinter(AccountStatement statement)
        {
            _statement = statement;
        }

        public void Print()
        {
            PrintHeader();
            PrintEntries();
        }

        private void PrintHeader()
        {
            Console.WriteLine("Account: " + _statement.Account);
            Console.WriteLine("From: " + _statement.From);
            Console.WriteLine("To: " + _statement.To);
            Console.WriteLine("Starting balance: " + _statement.StartingBalance);
            Console.WriteLine("Entries: " + "\n");
        }

        private void PrintEntries()
        {
            foreach(var entry in _statement.Entries)
            {                
                Console.WriteLine($"Transaction Id: {entry.TransactionId}");
                Console.WriteLine($"Date of transaction: {entry.Time}");
                Console.WriteLine($"Left balance: {entry.Balance}");
                Console.WriteLine($"Descritpion: {entry.Description}" + "\n");
                
            }
        }
    }
}
