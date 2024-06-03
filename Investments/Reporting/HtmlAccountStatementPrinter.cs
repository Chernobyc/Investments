﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investments.Reporting
{
    public class HtmlAccountStatementPrinter : IAccountStatementPrinter
    {
        private readonly AccountStatement _statement;
        private readonly string _fileName;

        public HtmlAccountStatementPrinter(AccountStatement statement, string fileName)
        {
            _statement = statement;
            _fileName = fileName;
        }

        public void Print() // должен выводить html код
        {
            PrintHeader();
            PrintEntries();
        }

        private void PrintHeader()
        {
            //  Kasuta File.AppendText, näiteks:
            File.AppendText("Account: " + _statement.Account);
            File.AppendText("From: " + _statement.From);
            File.AppendText("To: " + _statement.To);
            File.AppendText("Starting balance: " + _statement.StartingBalance);
            File.AppendText("Entries: " + "\n");


            //Console.WriteLine("Account: " + _statement.Account);
            //Console.WriteLine("From: " + _statement.From);
            //Console.WriteLine("To: " + _statement.To);
            //Console.WriteLine("Starting balance: " + _statement.StartingBalance);
        }

        private void PrintEntries()
        {
            foreach (var entry in _statement.Entries)
            {
                File.AppendText($"Transaction Id: {entry.TransactionId}");
                File.AppendText($"Date of transaction: {entry.Time}");
                File.AppendText($"Left balance: {entry.Balance}");
                File.AppendText($"Descritpion: {entry.Description}" + "\n");
            }
        }
    }
}
