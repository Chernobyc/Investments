using System;
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
        public void Report()
        {
            string path = Path.GetFullPath(_fileName);
            Console.WriteLine("\n"+ $"HTML HAS BEEN CREATED IN {path}" + "\n");
        }

        public void Print() // должен выводить html код
        {
            PrintHeader();
            PrintEntries();
            Report();
        }


        private void PrintHeader()
        {
            //  Kasuta File.AppendText, näiteks:
            using StreamWriter file = new StreamWriter(_fileName, false); // File.AppendText(); 
            file.WriteLine("<html>");
            file.WriteLine("<head><title>Account Statement</title></head>");
            file.WriteLine("<body>");
            file.WriteLine("<h1>Account Statement</h1>");
            file.WriteLine("<table border='1'>");
            file.WriteLine("<tr><th>Transaction ID</th><th>Date</th><th>Balance</th><th>Description</th></tr>");

            file.WriteLine("<p>Account: " + _statement.Account + "</p>");
            file.WriteLine("<p>From: " + _statement.From + "</p>");
            file.WriteLine("<p>To: " + _statement.To + "</p>");
            file.WriteLine("<p>Starting balance: " + _statement.StartingBalance + "</p>");
            file.WriteLine("<p>Entries: </p>");

            //file.WriteLine("Account: " + _statement.Account);
            //file.WriteLine("From: " + _statement.From);
            //file.WriteLine("To: " + _statement.To);
            //file.WriteLine("Starting balance: " + _statement.StartingBalance);
            //file.WriteLine("Entries: " + "\n");

        }
            private void PrintEntries()
        {
            using StreamWriter file = File.AppendText(_fileName);

            foreach (var entry in _statement.Entries)
            {
                file.WriteLine($"<tr><td>{entry.TransactionId}</td><td>{entry.Time}</td><td>{entry.Balance}</td><td>{entry.Description}</td></tr>");


                //File.AppendText($"Transaction Id: {entry.TransactionId}");
                //File.AppendText($"Date of transaction: {entry.Time}");
                //File.AppendText($"Left balance: {entry.Balance}");
                //File.AppendText($"Descritpion: {entry.Description}" + "\n");
            }
            file.WriteLine("</table>");
            file.WriteLine("</body>");
            file.WriteLine("</html>");
        }
    }
}
