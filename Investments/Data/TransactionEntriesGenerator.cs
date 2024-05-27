using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Investments.Data
{
    public static class TransactionEntriesGenerator
    {
        static Transaction GetNext( IEnumerator<Transaction> transactions)
        {
            return transactions.MoveNext() ? transactions.Current : null;
        }

        public static void GenerateTransactionEntries(DataContext context)
        {
            var pohikonto = context.Accounts[0]; // oli 1; Swed
            var lhv = context.Accounts[1]; // oli 0
            var aktsiadLhv = context.Accounts[2];

            //DateTime transactionTime;
            var transactions = context.Transactions.AsEnumerable().GetEnumerator(); // хранит список фактических транзакиций и позволяет использовать их с Enumerable

            //foreach (var i in trans)
            //{
            //    transactionTime = i.Time;
            //    return transactionTime;
            //};
            //var firstTrans = trans[0];
            //var transactions = trans;
            //var infiniteTransactions = InfiniteTransactions(trans);
            //Console.WriteLine("{0}", infiniteTransactions.Current.Time);
            //Console.WriteLine("{0}", infiniteTransactions.Current.Time);

            var trans = GetNext(transactions);
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "123456789001",
                Time = trans.Time, // DateTime.Now.AddDays(-90)
                OwningAccount = lhv,
                OtherAccount = pohikonto,
                Amount = 1000,
                Securable = trans.Name, // EUR
                Type = trans.Type, // Tavaline ülekanne
                Transaction = trans,
                Description = "Tasakaalu täiendamine"
            });

            trans = GetNext(transactions);
            // Ülekanne Swed => LHV 50 EUR
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "123456789002",
                Time = trans.Time, // DateTime.Now.AddDays(-90)
                OwningAccount = pohikonto,
                OtherAccount = lhv,
                Amount = 50,
                Securable = trans.Name, // EUR
                Type = trans.Type, // Tavaline ülekanne
                Transaction = trans,
                Description = "Cash-back"
            });

            // Swedis teenustasu
            trans = GetNext(transactions);

            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492343",
                Time = trans.Time, //DateTime.Parse("2023-04-10 17:00:00"),
                OwningAccount = pohikonto,
                Amount = 0.40m,
                Securable = trans.Name, // EUR
                Type = trans.Type, // 
                Transaction = trans,
                Description = "Teenustasu"
            });

            trans = GetNext(transactions);
            // Ülekanne LHV tavakonto => LHV väärtpaberikonto
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "56634563465454",
                Time = trans.Time,
                OwningAccount = lhv,
                OtherAccount = aktsiadLhv,
                Amount = 10,
                Securable = trans.Name, // Apple
                Type = trans.Type,
                Transaction = trans,
                Description = "AAPL ülekanne"
            });

            trans = GetNext(transactions);
            // Microsofti aktsia ostmine (eurod välja)
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "7142234235",
                Time = trans.Time,
                OwningAccount = aktsiadLhv,
                Amount = 45,
                Securable = trans.Name, // EUR
                Type = trans.Type, //
                Transaction = trans,
                Description = "Ostuorder NY388473"
            });

            trans = GetNext(transactions);
            // Microsofti aktsia ostmine (Microsofti aktsiad sisse)
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "7142234236",
                Time = trans.Time,
                OwningAccount = lhv,
                OtherAccount = aktsiadLhv, // Väärtpaberikonto LHV-s
                Amount = 0.171m,
                Securable = trans.Name, // Microsoft
                Type = trans.Type, // Tavaline ülekanne
                Transaction = trans,
                Description = "Ostuorder NY388473"
            });

            trans = GetNext(transactions);
            // Teenustasu LHV-s aktsiate ostmise eest
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492347",
                Time = trans.Time,
                OwningAccount = aktsiadLhv,
                OtherAccount = lhv, // Tavaline konto LHV-s
                Amount = 5,
                Securable = trans.Name, // EUR
                Type = trans.Type, // Teenustasu
                Transaction = trans,
                Description = "Teenustasu"
            });

            trans = GetNext(transactions);
            //1
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492308",
                Time = trans.Time,
                OwningAccount = aktsiadLhv,
                OtherAccount = lhv,
                Amount = 15,
                Securable = trans.Name, // Apple
                Type = trans.Type, // Müümine
                Transaction = trans,
                Description = "AAPL müümine"
            });

            trans = GetNext(transactions);
            //2
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492309",
                Time = trans.Time,
                OwningAccount = pohikonto,
                Amount = 77,
                Securable = trans.Name, // EUR
                Type = trans.Type, // exchange
                Transaction = trans,
                Description = "Raha exchange"
            });

            trans = GetNext(transactions);
            //3
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492310",
                Time = trans.Time,
                OwningAccount = pohikonto,
                OtherAccount = aktsiadLhv,
                Amount = 37,
                Securable = trans.Name, // Google
                Type = trans.Type,    // Ostmine
                Transaction = trans,
                Description = "Google aktsiade ostmine"
            });

            trans = GetNext(transactions);
            //4
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492311",
                Time = trans.Time,
                OwningAccount = pohikonto,
                OtherAccount = aktsiadLhv,
                Amount = 150,
                Securable = trans.Name,
                Type = trans.Type,
                Transaction = trans,
                Description = "Aaple aktsiade ostmine"
            });

            trans = GetNext(transactions);
            //5
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492312",
                Time = trans.Time,
                OwningAccount = pohikonto,
                OtherAccount = aktsiadLhv,
                Amount = 50,
                Securable = trans.Name,
                Type = trans.Type,
                Transaction = trans,
                Description = "Google aktsiade ostmine"
            });

            trans = GetNext(transactions);
            //6
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492313",
                Time = trans.Time,
                OwningAccount = pohikonto,
                OtherAccount = lhv,
                Amount = 29,
                Securable = trans.Name,
                Type = trans.Type,
                Transaction = trans,
                Description = "Tavaline ulekkane"
            });

            trans = GetNext(transactions);
            //7
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492314",
                Time = trans.Time,
                OwningAccount = pohikonto,
                OtherAccount = aktsiadLhv,
                Amount = 10,
                Securable = trans.Name,
                Type = trans.Type,
                Transaction = trans,
                Description = "Microsoft ostmine"
            });

            trans = GetNext(transactions);
            //8
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492315",
                Time = trans.Time,
                OwningAccount = aktsiadLhv,
                OtherAccount = pohikonto,
                Amount = 50,
                Securable = trans.Name,
                Type = trans.Type,
                Transaction = trans,
                Description = "Apple muumine"
            });

            trans = GetNext(transactions);
            //9
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492316",
                Time = DateTime.Parse("2023-05-01 12:50:00"),
                OwningAccount = lhv,
                Amount = 90,
                Securable = context.Securables[0],
                Type = TransactionTypeEnum.Sell,
                Transaction = trans,
                Description = "Tavaline ülekanne"
            });

            //uued
            trans = GetNext(transactions);
            //10
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492317",
                Time = DateTime.Parse("2023-05-03 19:40:00"),
                OwningAccount = lhv,
                Amount = 99,
                Securable = context.Securables[0],
                Type = TransactionTypeEnum.Sell,
                Transaction = trans,
                Description = "Valuuta vahetus"
            });

            trans = GetNext(transactions);
            //11
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492318",
                Time = DateTime.Parse("2023-05-06 17:10:00"),
                OwningAccount = lhv,
                OtherAccount = aktsiadLhv,
                Amount = 150,
                Securable = context.Securables[2],
                Type = TransactionTypeEnum.Transfer,
                Transaction = trans,
                Description = "Aktsiade ülekanne"
            });

            trans = GetNext(transactions);
            //12
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492319",
                Time = DateTime.Parse("2023-05-08 12:15:00"),
                OwningAccount = lhv,
                OtherAccount = aktsiadLhv,
                Amount = 90,
                Securable = context.Securables[3],
                Type = TransactionTypeEnum.Buy,
                Transaction = trans,
                Description = "Google aktsiade ostmine"
            });

            trans = GetNext(transactions);
            //13
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492320",
                Time = DateTime.Parse("2023-05-10 17:40:00"),
                OwningAccount = lhv,
                Amount = 40,
                Securable = context.Securables[0],
                Type = TransactionTypeEnum.ServiceFee,
                Transaction = trans,
                Description = "Teenustasu"
            });

            trans = GetNext(transactions);
            //14
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492321",
                Time = DateTime.Parse("2023-05-13 13:20:00"),
                OwningAccount = lhv,
                OtherAccount = aktsiadLhv,
                Amount = 120,
                Securable = context.Securables[2],
                Type = TransactionTypeEnum.Sell,
                Transaction = trans,
                Description = "Apple aktsiade muumine"
            });

            trans = GetNext(transactions);
            //15
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492322",
                Time = DateTime.Parse("2023-05-15 10:30:00"),
                OwningAccount = lhv,
                OtherAccount = pohikonto,
                Amount = 80,
                Securable = context.Securables[1],
                Type = TransactionTypeEnum.Transfer,
                Transaction = trans,
                Description = "Tavaline ülekanne"
            });

            trans = GetNext(transactions);
            //16
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492323",
                Time = DateTime.Parse("2023-05-18 12:50:00"),
                OwningAccount = lhv,
                OtherAccount = pohikonto,
                Amount = 90,
                Securable = context.Securables[0],
                Type = TransactionTypeEnum.Sell,
                Transaction = trans,
                Description = "Tavaline ülekanne"
            });

            trans = GetNext(transactions);
            //17
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492324",
                Time = DateTime.Parse("2023-05-21 13:10:00"),
                OwningAccount = lhv,
                OtherAccount = aktsiadLhv,
                Amount = 129,
                Securable = context.Securables[3],
                Type = TransactionTypeEnum.Buy,
                Transaction = trans,
                Description = "Google ostmine"
            });

            trans = GetNext(transactions);
            //18
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492325",
                Time = DateTime.Parse("2023-05-24 15:50:00"),
                OwningAccount = lhv,
                Amount = 60,
                Securable = context.Securables[0],
                Type = TransactionTypeEnum.CurrencyExchange,
                Transaction = trans,
                Description = "Aktsiade ülekanne"
            });

            trans = GetNext(transactions);
            //19
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492326",
                Time = DateTime.Parse("2023-05-26 16:45:00"),
                OwningAccount = lhv,
                OtherAccount = aktsiadLhv,
                Amount = 120,
                Securable = context.Securables[1],
                Type = TransactionTypeEnum.Sell,
                Transaction = trans,
                Description = "Microsoft aktsiade muumine"
            });

            trans = GetNext(transactions);
            //20
            context.TransactionEntries.Add(new TransactionEntry
            {
                TransactionId = "234923492327",
                Time = DateTime.Parse("2023-05-30 19:20:00"),
                OwningAccount = lhv,
                Amount = 140,
                Securable = context.Securables[1],
                Type = TransactionTypeEnum.Buy,
                Transaction = trans,
                Description = "Microsoft aktsiade ostmine"
            });

            pohikonto.Entries.AddRange(context.TransactionEntries.Where(t => t.OwningAccount == pohikonto));
            lhv.Entries.AddRange(context.TransactionEntries.Where(t => t.OwningAccount == lhv));
            aktsiadLhv.Entries.AddRange(context.TransactionEntries.Where(t => t.OwningAccount == aktsiadLhv));
        }
    }
}
